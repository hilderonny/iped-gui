using IPED_Gui_WinForms.Properties;
using System.Diagnostics;
using System.Reflection;

namespace IPED_Gui_WinForms
{
    public partial class MainForm : Form
    {
        private readonly SynchronizationContext? synchronizationContext;

        /// <summary>
        /// Konstruktor. Erstellt das Hauptfenster
        /// </summary>
        public MainForm()
        {
            synchronizationContext = SynchronizationContext.Current;
            InitializeComponent();
            LoadSettings();
            CheckForWarning();

            Version? version = Assembly.GetExecutingAssembly().GetName().Version;
            Text += " " + version?.Major + "." + version?.Minor + "." + version?.Build;
        }

        /// <summary>
        /// Prüft, ob anhand der Einstellungen die Warnung bezüglich des nicht-leeren
        /// Ausgabeverzeichnisses angezeigt werden soll:
        /// Ausgabeverzeichnis leer oder Projekt erweitern angeklickt oder Nach Abbruch fortsetzen angeklickt == Warnung ausblenden, andernfalls anzeigen
        /// </summary>
        private void CheckForWarning()
        {
            label_Warnung.Text = string.Empty;
            string outputPath = textBox_Ausgabeverzeichnis.Text;
            if (outputPath.Length == 0)
            {
                label_Warnung.Text = "Bitte geben Sie ein Ausgabeverzeichnis an!";
                button_Starten.Enabled = false;
                return;
            }
            if (!Directory.Exists(outputPath))
            {
                label_Warnung.Text = "Das Ausgabeverzeichnis existiert nicht (mehr). Bitte wählen Sie ein existierendes Verzeichnis!";
                button_Starten.Enabled = false;
                return;
            }
            if (!checkBox_ProjektErweitern.Checked && !checkBox_Fortsetzen.Checked && Directory.GetFileSystemEntries(outputPath).Any())
            {
                label_Warnung.Text = "Das Ausgabeverzeichnis ist nicht leer. Soll das bestehende Projekt erweitert oder ein vorher abgebrochener Vorgang fortgesetzt werden?";
                return;
            }
        }

        /// <summary>
        /// Erstellt die Argumentenliste für den Aufruf von IPED und gibt diese als Zeichenkette zurück
        /// </summary>
        private string CreateIpedArguments()
        {
            List<string> argumentParts = new List<string>();
            if (checkBox_Fortsetzen.Checked) argumentParts.Add("--continue");
            if (checkBox_InternetdatenLaden.Checked) argumentParts.Add("--downloadInternetData");
            if (checkBox_Portabel.Checked) argumentParts.Add("--portable");
            if (checkBox_ProjektErweitern.Checked) argumentParts.Add("--append");
            foreach (var path in listBox_Spuren.Items)
            {
                argumentParts.Add("-d");
                argumentParts.Add("\"" + path + "\"");
            }
            argumentParts.Add("-o");
            argumentParts.Add("\"" + textBox_Ausgabeverzeichnis.Text + "\"");
            return string.Join(" ", argumentParts);
        }

        /// <summary>
        /// Erstellt den Inhalt der IPEDConfig.txt - Datei anhand der Einstellungen und gibt diesen als Zeichenkette zurück
        /// </summary>
        private string CreateIPEDConfig()
        {
            List<string> configLines = new List<string>
            {
                "enableHash = true",
                "enablePhotoDNA = false",
                "enableHashDBLookup = true",
                "enablePhotoDNALookup = false",
                "enableLedDie = true",
                "enableYahooNSFWDetection = false",
                "enableQRCode = true",
                "ignoreDuplicates = false",
                "exportFileProps = false",
                "processFileSignatures = true",
                "enableFileParsing = true",
                "expandContainers = true",
                "processEmbeddedDisks = true",
                "enableRegexSearch = true",
                "enableAutomaticExportFiles = true",
                "enableLanguageDetect = true",
                "enableNamedEntityRecogniton = false",
                "enableGraphGeneration = true",
                "entropyTest = true",
                "indexFileContents = true",
                "enableIndexToElasticSearch = false",
                "enableMinIO = false",
                "enableAudioTranscription = false",
                "enableCarving = true",
                "enableLedCarving = false",
                "enableKnownMetCarving = false",
                "enableImageThumbs = true",
                "enableImageSimilarity = true",
                "enableFaceRecognition = true",
                "enableVideoThumbs = true",
                "enableDocThumbs = true",
                "enableHTMLReport = true",
                "enableAudioTranslation = " + (checkBox_AudioTranslation.Checked ? "true" : "false"),
                "enableTextTranslation = false",
                "enableImageClassification = " + (checkBox_BildKlassifizierung.Checked ? "true" : "false")
            };
            return string.Join("\n", configLines);
        }

        /// <summary>
        /// Erstellt den Inhalt der conf/OcrConfig.txt - Datei anhand der Einstellungen und gibt diesen als Zeichenkette zurück
        /// </summary>
        private string CreateOcrConfig()
        {
            List<string> configLines = new List<string>
            {
                "enableOCR = " + (checkBox_Ocr.Checked ? "true" : "false"),
                "OCRLanguage = eng+deu",
                "pageSegMode = 1",
                "minFileSize2OCR = 1000",
                "maxFileSize2OCR = 200000000",
                "pdfToImgResolution = 250",
                "maxPDFTextSize2OCR = 100",
                "pdfToImgLib = icepdf",
                "externalPdfToImgConv = true",
                "externalConvMaxMem = 512M",
                "processNonStandard = false",
                "maxConvImageSize = 3000"
            };
            return string.Join("\n", configLines);
        }

        /// <summary>
        /// Lädt die zuletzt gültigen Einstellungen und aktualisiert die UI-Elemente entsprechend
        /// </summary>
        private void LoadSettings()
        {
            Settings settings = Settings.Default;
            textBox_Ausgabeverzeichnis.Text = settings.General_Output_Directory;
            checkBox_ProjektErweitern.Checked = settings.General_Append;
            checkBox_Fortsetzen.Checked = settings.General_Continue;
            checkBox_Portabel.Checked = settings.General_Portable;
            checkBox_InternetdatenLaden.Checked = settings.General_Download_Internet_Data;
            checkBox_AudioTranslation.Checked = settings.IPEDConfig_enableAudioTranslation;
            checkBox_BildKlassifizierung.Checked = settings.IPEDConfig_enableImageClassification;
            checkBox_Ocr.Checked = settings.General_Ocr;
        }

        /// <summary>
        /// Gibt die gegebene Zeichenkette in der Protokoll-Textbox aus und fügt einen Zeilenumbruch ein
        /// </summary>
        private void WriteToConsole(string? line)
        {
            textBox_Konsole.AppendText(line);
            textBox_Konsole.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox AudioTranslation angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter IPEDConfig_enableAudioTranslation.
        /// </summary>
        private void checkBox_AudioTranslation_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.IPEDConfig_enableAudioTranslation = checkBox_AudioTranslation.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox BildKlassifizierung angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter IPEDConfig_enableImageClassification.
        /// </summary>
        private void checkBox_BildKlassifizierung_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.IPEDConfig_enableImageClassification = checkBox_BildKlassifizierung.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox Fortsetzen angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Append.
        /// Deselektiert die Checkbox ProjektErweitern, da sich beide Einstellungen
        /// gegenseitig ausschließen und speichert auch deren Zustand in den Einstellungen.
        /// </summary>
        private void checkBox_Fortsetzen_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            if (checkBox_Fortsetzen.Checked)
            {
                checkBox_ProjektErweitern.Checked = false;
                settings.General_Append = false;
            }
            settings.General_Continue = checkBox_Fortsetzen.Checked;
            settings.Save();
            CheckForWarning();
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox InternetdatenLaden angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Download_Internet_Data.
        /// </summary>
        private void checkBox_InternetdatenLaden_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Download_Internet_Data = checkBox_InternetdatenLaden.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox Portabel angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Portable.
        /// </summary>
        private void checkBox_Portabel_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Portable = checkBox_Portabel.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox ProjektErweitern angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Continue.
        /// Deselektiert die Checkbox Fortsetzen, da sich beide Einstellungen
        /// gegenseitig ausschließen und speichert auch deren Zustand in den Einstellungen.
        /// </summary>
        private void checkBox_ProjektErweitern_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            if (checkBox_ProjektErweitern.Checked)
            {
                checkBox_Fortsetzen.Checked = false;
                settings.General_Continue = false;
            }
            settings.General_Append = checkBox_ProjektErweitern.Checked;
            settings.Save();
            CheckForWarning();
        }

        /// <summary>
        /// Wird ausgeführt, wenn die CheckBox Ocr angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Ocr.
        /// </summary>
        private void checkBox_Ocr_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Ocr = checkBox_Ocr.Checked;
            settings.Save();
        }

        /// <summary>
        /// Öffnet nach dem Anklicken des Buttons Auswaehlen einen Verzeichnisauswahldialog.
        /// Wird ein Verzeichnis darin selektiert, wird dieses als Ausgabeverzeichnis festgelegt,
        /// im entsprechenden Textfeld angezeigt und in den Einstellungen unter General_Output_Directory
        /// gespeichert.
        /// </summary>
        private void button_Auswaehlen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = textBox_Ausgabeverzeichnis.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_Ausgabeverzeichnis.Text = folderBrowserDialog.SelectedPath;
                Settings settings = Settings.Default;
                settings.General_Output_Directory = folderBrowserDialog.SelectedPath;
                settings.Save();
                CheckForWarning();
            }
        }

        /// <summary>
        /// Beim Klicken auf den DateienHinzufügen Button wird ein Dateiauswahldialog angezeigt,
        /// mit dem man mehrere Dateien zur Spurenliste hinzufügen kann.
        /// </summary>
        private void button_DateienHinzufuegen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in fileDialog.FileNames)
                {
                    listBox_Spuren.Items.Add(fileName);
                }
            }
        }

        /// <summary>
        /// Entfernt alle markierten Spuren aus der Spurenliste
        /// </summary>
        private void button_Entfernen_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = listBox_Spuren.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox_Spuren.Items.Remove(selectedItems[i]);
            }
        }

        /// <summary>
        /// Startet IPED mit den gegebenen Einstellungen in einem separaten Prozess.
        /// </summary>
        private void button_Starten_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;

            string cfgIPEDConfig = CreateIPEDConfig();
            File.WriteAllText(settings.General_Iped_Exe_Path + settings.General_Relative_IPEDConfig_File_Path, cfgIPEDConfig);

            string cfgOcrConfig = CreateOcrConfig();
            File.WriteAllText(settings.General_Iped_Exe_Path + settings.General_Relative_OCRConfig_File_Path, cfgOcrConfig);

            string ipedCommand = Settings.Default.General_Iped_Exe_Path + "jre\\bin\\java.exe";
            string ipedArguments = " -jar " + Settings.Default.General_Iped_Exe_Path + "iped.jar " + CreateIpedArguments();
            textBox_Konsole.Clear();
            WriteToConsole(ipedCommand + " " + ipedArguments + "\n");

            using (var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ipedCommand,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = ipedArguments,
                }
            })
            {
                button_Starten.Enabled = false;

                process.OutputDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);
                process.ErrorDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                button_Starten.Enabled = true;

            }
        }

        /// <summary>
        /// Beim Klicken auf den VerzeichnisHinzufügen Button wird ein 
        /// Verzeichnisauswahldialog angezeigt, mit dem man ein Verzeichnis
        /// zur Spurenliste hinzufügen kann.
        /// </summary>
        private void button_VerzeichnisHinzufuegen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox_Spuren.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        /// <summary>
        /// Sobald in der Spurenliste eine Spur markiert wird, wird der Button
        /// Entfernen aktiviert. Wird die Markierung entfernt, wird auch der
        /// Button wieder deaktiviert.
        /// </summary>
        private void listBox_Spuren_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Entfernen.Enabled = listBox_Spuren.SelectedItems.Count > 0;
        }

    }
}