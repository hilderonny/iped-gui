using IPED_Gui_WinForms.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

// Tabs verstecken: Siehe https://stackoverflow.com/questions/552579/how-to-hide-tabpage-from-tabcontrol
// Tabs und deren Inhalte sollten eigene Controls mit DataBinding werden, die dynmisch durch Datensatzerweiterung erweitert werden k�nnen
// Wie kann man sowas mit Settings synchronisieren? Eigenes Settings-Handling?

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
        /// Pr�ft, ob anhand der Einstellungen die Warnung bez�glich des nicht-leeren
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
                return;
            }
            if (!Directory.Exists(outputPath))
            {
                label_Warnung.Text = "Das Ausgabeverzeichnis existiert nicht (mehr). Bitte w�hlen Sie ein existierendes Verzeichnis!";
                return;
            }
            if (!checkBox_ProjektErweitern.Checked && !checkBox_Fortsetzen.Checked && Directory.GetFileSystemEntries(outputPath).Any())
            {
                label_Warnung.Text = "Das Ausgabeverzeichnis ist nicht leer. Soll das bestehende Projekt erweitert oder ein vorher abgebrochener Vorgang fortgesetzt werden?";
                return;
            }
        }

        /// <summary>
        /// Erstellt die Argumentenliste f�r den Aufruf von IPED und gibt diese als Zeichenkette zur�ck
        /// </summary>
        private string CreateIpedArguments(string profileName)
        {
            Settings settings = Settings.Default;
            List<string> argumentParts = new();
            if (checkBox_Fortsetzen.Checked) argumentParts.Add("--continue");
            if (checkBox_InternetdatenLaden.Checked) argumentParts.Add("--downloadInternetData");
            if (checkBox_Portabel.Checked) argumentParts.Add("--portable");
            if (checkBox_ProjektErweitern.Checked) argumentParts.Add("--append");
            argumentParts.Add("-profile " + profileName);
            foreach (var path in listBox_Spuren.Items)
            {
                argumentParts.Add("-d \"" + path + "\"");
            }
            argumentParts.Add("-o \"" + settings.General_Output_Directory + "\"");
            return string.Join(" ", argumentParts);
        }

        /// <summary>
        /// Erstellt den Inhalt der IPEDConfig.txt - Datei anhand der Einstellungen und gibt diesen als Zeichenkette zur�ck
        /// </summary>
        private static string CreateIPEDConfig()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
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
                "enableGraphGeneration = " + (settings.SettingsEnableGraphGeneration ? "true" : "false"),
                "entropyTest = true",
                "indexFileContents = true",
                "enableIndexToElasticSearch = false",
                "enableMinIO = false",
                "enableAudioTranscription = false",
                "enableCarving = " + (settings.SettingsEnableCarving ? "true" : "false"),
                "enableLedCarving = false",
                "enableKnownMetCarving = false",
                "enableImageThumbs = true",
                "enableImageSimilarity = true",
                "enableFaceRecognition = " + (settings.SettingsEnableFaceRecognition ? "true" : "false"),
                "enableVideoThumbs = true",
                "enableDocThumbs = true",
                "enableHTMLReport = true",
                "enableAudioTranslation = " + (settings.IPEDConfigEnableAudioTranslation ? "true" : "false"),
                "enableTextTranslation = false",
                "enableImageClassification = " + (settings.IPEDConfigEnableImageClassification ? "true" : "false")
            });
        }

        private static string CreateLocalConfig()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "locale = " + settings.SettingsLocale,
                "indexTemp = " + settings.SettingsIndexTemp.Replace("\\", "/"),
                "indexTempOnSSD = " + (settings.SettingsIndexTempOnSSD ? "true" : "false"),
                "outputOnSSD = " + (settings.SettingsOutputOnSSD ? "true" : "false"),
                "numThreads = " + settings.SettingsNumThreads,
                "hashesDB = " + settings.SettingsHashesDB.Replace("\\", "/"),
                "pluginFolder = " + Path.GetRelativePath(Path.GetDirectoryName(settings.SettingsIpedExePath) ?? "", settings.SettingsPluginFolder).Replace("\\", "/")
            });
        }

        private static string CreateAudioTranslationTxt()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "inputDirectory = " + settings.AudioTranslationInputDirectory,
                "outputDirectory = " + settings.AudioTranslationOutputDirectory,
                "processVideo = " + (settings.AudioTranslationProcessVideo ? "true" : "false")
            });
        }

        private static string CreateImageClassificationTxt()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "inputDirectory = " + settings.ImageClassificationInputDirectory,
                "outputDirectory = " + settings.ImageClassificationOutputDirectory
            });
        }

        private static string CreateFileSystemConfigTxt()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "robustImageReading = false",
                "numImageReaders = auto",
                "addUnallocated = " + (settings.FileSystemConfigAddUnallocated ? "true" : "false"),
                "addFileSlacks = false",
                "minOrphanSizeToIgnore = -1",
                "unallocatedFragSize = 1073741824",
                "ignoreHardLinks = true",
                "skipFolderRegex ="
            });
        }

        /// <summary>
        /// L�dt die zuletzt g�ltigen Einstellungen und aktualisiert die UI-Elemente entsprechend
        /// </summary>
        private void LoadSettings()
        {
            Settings settings = Settings.Default;

            // �bersicht
            textBox_Ausgabeverzeichnis.Text = settings.General_Output_Directory;
            checkBox_ProjektErweitern.Checked = settings.General_Append;
            checkBox_Fortsetzen.Checked = settings.General_Continue;
            checkBox_Portabel.Checked = settings.General_Portable;
            checkBox_InternetdatenLaden.Checked = settings.General_Download_Internet_Data;

            // Einstellungen
            textBoxSettingsIpedExePath.Text = settings.SettingsIpedExePath;
            comboBoxSettingsLocale.SelectedIndex = comboBoxSettingsLocale.FindStringExact(settings.SettingsLocale);
            textBoxSettingsIndexTemp.Text = settings.SettingsIndexTemp;
            checkBoxSettingsIndexTempOnSSD.Checked = settings.SettingsIndexTempOnSSD;
            checkBoxSettingsOutputOnSSD.Checked = settings.SettingsOutputOnSSD;
            textBoxSettingsNumThreads.Text = settings.SettingsNumThreads;
            textBoxSettingsHashesDB.Text = settings.SettingsHashesDB;
            textBoxSettingsPluginFolder.Text = settings.SettingsPluginFolder;
            checkBoxSettingsEnableCarving.Checked = settings.SettingsEnableCarving;
            checkBoxFileSystemConfigAddUnallocated.Checked = settings.FileSystemConfigAddUnallocated;
            checkBoxSettingsEnableFaceRecognition.Checked = settings.SettingsEnableFaceRecognition;
            checkBoxSettingsEnableGraphGeneration.Checked = settings.SettingsEnableGraphGeneration;

            // Audio�bersetzung
            checkBoxIPEDConfigEnableAudioTranslation.Checked = settings.IPEDConfigEnableAudioTranslation;
            textBoxAudioTranslationInputDirectory.Text = settings.AudioTranslationInputDirectory;
            textBoxAudioTranslationOutputDirectory.Text = settings.AudioTranslationOutputDirectory;
            checkBoxAudioTranslationProcessVideos.Checked = settings.AudioTranslationProcessVideo;
            textBoxAudioTranslationServiceProgram.Text = settings.AudioTranslationServiceProgram;
            textBoxAudioTranslationProcessingDirectory.Text = settings.AudioTranslationProcessingDirectory;
            textBoxAudioTranslationFasterWhisperDirectory.Text = settings.AudioTranslationFasterWhisperDirectory;
            textBoxAudioTranslationArgosTranslateDirectory.Text = settings.AudioTranslationArgosTranslateDirectory;
            comboBoxAudioTranslationModelSize.SelectedIndex = comboBoxAudioTranslationModelSize.FindStringExact(settings.AudioTranslationModelSize);
            checkBoxAudioTranslationUseGPU.Checked = settings.AudioTranslationUseGPU;

            // Bildklassifizierung
            checkBoxIPEDConfigEnableImageClassification.Checked = settings.IPEDConfigEnableImageClassification;
            textBoxImageClassificationInputDirectory.Text = settings.ImageClassificationInputDirectory;
            textBoxImageClassificationOutputDirectory.Text = settings.ImageClassificationOutputDirectory;
            textBoxImageClassificationServiceProgram.Text = settings.ImageClassificationServiceProgram;
            textBoxImageClassificationProcessingDirectory.Text = settings.ImageClassificationProcessingDirectory;
            textBoxImageClassificationMobileNetDirectory.Text = settings.ImageClassificationMobileNetDirectory;
            comboBoxImageClassificationLanguage.SelectedIndex = comboBoxImageClassificationLanguage.FindStringExact(settings.ImageClassificationLanguage);
        }

        /// <summary>
        /// Gibt die gegebene Zeichenkette in der Protokoll-Textbox aus und f�gt einen Zeilenumbruch ein
        /// </summary>
        private void WriteToConsole(string? line)
        {
            textBoxConsole.AppendText(line);
            textBoxConsole.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Wird ausgef�hrt, wenn die CheckBox AudioTranslation angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter IPEDConfig_enableAudioTranslation.
        /// </summary>
        private void checkBoxIPEDConfigEnabelAudioTranslation_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.IPEDConfigEnableAudioTranslation = checkBoxIPEDConfigEnableAudioTranslation.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgef�hrt, wenn die CheckBox BildKlassifizierung angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter IPEDConfig_enableImageClassification.
        /// </summary>
        private void checkBoxIPEDConfigEnableImageClassification_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.IPEDConfigEnableImageClassification = checkBoxIPEDConfigEnableImageClassification.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgef�hrt, wenn die CheckBox Fortsetzen angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Append.
        /// Deselektiert die Checkbox ProjektErweitern, da sich beide Einstellungen
        /// gegenseitig ausschlie�en und speichert auch deren Zustand in den Einstellungen.
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
        /// Wird ausgef�hrt, wenn die CheckBox InternetdatenLaden angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Download_Internet_Data.
        /// </summary>
        private void checkBox_InternetdatenLaden_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Download_Internet_Data = checkBox_InternetdatenLaden.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgef�hrt, wenn die CheckBox Portabel angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Portable.
        /// </summary>
        private void checkBox_Portabel_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Portable = checkBox_Portabel.Checked;
            settings.Save();
        }

        /// <summary>
        /// Wird ausgef�hrt, wenn die CheckBox ProjektErweitern angeklickt wurde.
        /// Speichert deren Zustand in den Einstellungen unter General_Continue.
        /// Deselektiert die Checkbox Fortsetzen, da sich beide Einstellungen
        /// gegenseitig ausschlie�en und speichert auch deren Zustand in den Einstellungen.
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
        /// �ffnet nach dem Anklicken des Buttons Auswaehlen einen Verzeichnisauswahldialog.
        /// Wird ein Verzeichnis darin selektiert, wird dieses als Ausgabeverzeichnis festgelegt,
        /// im entsprechenden Textfeld angezeigt und in den Einstellungen unter General_Output_Directory
        /// gespeichert.
        /// </summary>
        private void button_GeneralOutputDirectory_Click(object sender, EventArgs e)
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
        /// Beim Klicken auf den DateienHinzuf�gen Button wird ein Dateiauswahldialog angezeigt,
        /// mit dem man mehrere Dateien zur Spurenliste hinzuf�gen kann.
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
            var profileName = "ipedgui";
            Settings settings = Settings.Default;

            var ipedDirectory = Path.GetDirectoryName(settings.SettingsIpedExePath);
            var profileDirectory = Path.Join(ipedDirectory, "profiles", profileName);
            var confDirectory = Path.Join(profileDirectory, "conf");
            Directory.CreateDirectory(confDirectory);
            // IPEDConfig.txt
            File.WriteAllText(Path.Join(profileDirectory, "IPEDConfig.txt"), CreateIPEDConfig());
            // LocalConfig.tyt
            File.WriteAllText(Path.Join(profileDirectory, "LocalConfig.txt"), CreateLocalConfig());
            // conf/AudioTranslation.txt
            File.WriteAllText(Path.Join(confDirectory, "AudioTranslation.txt"), CreateAudioTranslationTxt());
            // conf/ImageClassification.txt
            File.WriteAllText(Path.Join(confDirectory, "ImageClassification.txt"), CreateImageClassificationTxt());
            // conf/FileSystemConfig.txt
            File.WriteAllText(Path.Join(confDirectory, "FileSystemConfig.txt"), CreateFileSystemConfigTxt());

            string ipedCommand = settings.SettingsIpedExePath;
            string ipedArguments = CreateIpedArguments(profileName);
            textBoxConsole.Clear();
            WriteToConsole(ipedCommand + " " + ipedArguments + "\n");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ipedCommand,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = ipedArguments,
                }
            };

            process.OutputDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);
            process.ErrorDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            tabControl1.SelectedTab = tabPageProtocol;

        }

        /// <summary>
        /// Beim Klicken auf den VerzeichnisHinzuf�gen Button wird ein 
        /// Verzeichnisauswahldialog angezeigt, mit dem man ein Verzeichnis
        /// zur Spurenliste hinzuf�gen kann.
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

        private void buttonSettingsIpedExePath_Click(object sender, EventArgs e)
        {
            openFileDialogSettingsIpedExePath.FileName = textBoxSettingsIpedExePath.Text;
            if (openFileDialogSettingsIpedExePath.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialogSettingsIpedExePath.FileName;
                textBoxSettingsIpedExePath.Text = fileName;
                Settings settings = Settings.Default;
                settings.SettingsIpedExePath = fileName;
                settings.Save();
            }
        }

        private void comboBoxSettingsLocale_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsLocale = (string)((ComboBox)sender).SelectedItem;
            settings.Save();
        }

        private void buttonSettingsIndexTemp_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxSettingsIndexTemp.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxSettingsIndexTemp.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.SettingsIndexTemp = selectedFolder;
                settings.Save();
            }
        }

        private void checkBoxSettingsIndexTempOnSSD_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsIndexTempOnSSD = checkBoxSettingsIndexTempOnSSD.Checked;
            settings.Save();
        }

        private void checkBoxSettingsOutputOnSSD_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsOutputOnSSD = checkBoxSettingsOutputOnSSD.Checked;
            settings.Save();
        }

        private void textBoxSettingsNumThreads_TextChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsNumThreads = textBoxSettingsNumThreads.Text;
            settings.Save();
        }

        private void buttonSettingsHashesDB_Click(object sender, EventArgs e)
        {
            openFileDialogSettingsHashesDB.FileName = textBoxSettingsHashesDB.Text;
            if (openFileDialogSettingsHashesDB.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialogSettingsHashesDB.FileName;
                textBoxSettingsHashesDB.Text = fileName;
                Settings settings = Settings.Default;
                settings.SettingsHashesDB = fileName;
                settings.Save();
            }
        }

        private void buttonSettingsPluginFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxSettingsPluginFolder.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxSettingsPluginFolder.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.SettingsPluginFolder = selectedFolder;
                settings.Save();
            }
        }

        private void buttonAudioTranslationInputDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxAudioTranslationInputDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxAudioTranslationInputDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.AudioTranslationInputDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void buttonAudioTranslationOutputDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxAudioTranslationOutputDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxAudioTranslationOutputDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.AudioTranslationOutputDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void checkBoxAudioTranslationProcessVideos_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.AudioTranslationProcessVideo = checkBoxAudioTranslationProcessVideos.Checked;
            settings.Save();
        }

        private void buttonImageClassificationInputDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxImageClassificationInputDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxImageClassificationInputDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.ImageClassificationInputDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void buttonImageClassificationOutputDirectory_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxImageClassificationOutputDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxImageClassificationOutputDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.ImageClassificationOutputDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void buttonAudioTranslationServiceProgram_Click(object sender, EventArgs e)
        {
            openFileDialogAudioTranslationServiceProgram.FileName = textBoxAudioTranslationServiceProgram.Text;
            if (openFileDialogAudioTranslationServiceProgram.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialogAudioTranslationServiceProgram.FileName;
                textBoxAudioTranslationServiceProgram.Text = fileName;
                Settings settings = Settings.Default;
                settings.AudioTranslationServiceProgram = fileName;
                settings.Save();
            }
        }

        private void buttonAudioTranslationProcessingDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxAudioTranslationProcessingDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxAudioTranslationProcessingDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.AudioTranslationProcessingDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void buttonAudioTranslationFasterWhisperDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxAudioTranslationFasterWhisperDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxAudioTranslationFasterWhisperDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.AudioTranslationFasterWhisperDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void buttonAudioTranslationArgosTranslateDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxAudioTranslationArgosTranslateDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxAudioTranslationArgosTranslateDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.AudioTranslationArgosTranslateDirectory = selectedFolder;
                settings.Save();
            }
        }

        /// <summary>
        /// Startet den background-service-worker in einem separaten Prozess
        /// </summary>
        private void buttonAudioTranslationStartProcess_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;

            var workingDirectory = Path.GetDirectoryName(settings.AudioTranslationServiceProgram);
            var pythonCommand = Path.Join(workingDirectory, "python", "python.exe");

            List<string> pythonArgumentList = new()
            {
                "\"" + settings.AudioTranslationServiceProgram + "\"",
                "-i \"" + settings.AudioTranslationInputDirectory + "\"",
                "-p \"" + settings.AudioTranslationProcessingDirectory + "\"",
                "-o \"" + settings.AudioTranslationOutputDirectory + "\"",
                "-w \"" + settings.AudioTranslationFasterWhisperDirectory + "\"",
                "-a \"" + settings.AudioTranslationArgosTranslateDirectory + "\"",
                "-m " + settings.AudioTranslationModelSize
            };
            if (checkBoxAudioTranslationUseGPU.Checked) pythonArgumentList.Add("-g");
            var pythonArguments = string.Join(" ", pythonArgumentList);

            WriteToConsole(pythonCommand + " " + pythonArguments + "\n");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = pythonCommand,
                    WorkingDirectory = workingDirectory,
                    UseShellExecute = true,
                    Arguments = pythonArguments,
                }
            };
            process.Start();
            tabControl1.SelectedTab = tabPageProtocol;
        }

        private void checkBoxAudioTranslationUseGPU_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.AudioTranslationUseGPU = checkBoxAudioTranslationUseGPU.Checked;
            settings.Save();
        }

        private void buttonImageClassificationServiceProgram_Click(object sender, EventArgs e)
        {
            openFileDialogImageClassificationServiceProgram.FileName = textBoxImageClassificationServiceProgram.Text;
            if (openFileDialogImageClassificationServiceProgram.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialogImageClassificationServiceProgram.FileName;
                textBoxImageClassificationServiceProgram.Text = fileName;
                Settings settings = Settings.Default;
                settings.ImageClassificationServiceProgram = fileName;
                settings.Save();
            }
        }

        private void buttonImageClassificationProcessingDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxImageClassificationProcessingDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxImageClassificationProcessingDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.ImageClassificationProcessingDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void buttonImageClassificationMobileNetDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxImageClassificationMobileNetDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxImageClassificationMobileNetDirectory.Text = selectedFolder;
                Settings settings = Settings.Default;
                settings.ImageClassificationMobileNetDirectory = selectedFolder;
                settings.Save();
            }
        }

        private void comboBoxAudioTranslationModelSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.AudioTranslationModelSize = (string)((ComboBox)sender).SelectedItem;
            settings.Save();
        }

        private void comboBoxImageClassificationLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.ImageClassificationLanguage = (string)((ComboBox)sender).SelectedItem;
            settings.Save();
        }

        private void buttonImageClassificationStartProcess_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;

            var workingDirectory = Path.GetDirectoryName(settings.ImageClassificationServiceProgram);
            var pythonCommand = Path.Join(workingDirectory, "python", "python.exe");

            List<string> pythonArgumentList = new()
            {
                "\"" + settings.ImageClassificationServiceProgram + "\"",
                "-i \"" + settings.ImageClassificationInputDirectory + "\"",
                "-p \"" + settings.ImageClassificationProcessingDirectory + "\"",
                "-o \"" + settings.ImageClassificationOutputDirectory + "\"",
                "-m \"" + settings.ImageClassificationMobileNetDirectory + "\"",
                "-l " + settings.ImageClassificationLanguage
            };
            var pythonArguments = string.Join(" ", pythonArgumentList);

            WriteToConsole(pythonCommand + " " + pythonArguments + "\n");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = pythonCommand,
                    WorkingDirectory = workingDirectory,
                    UseShellExecute = true,
                    Arguments = pythonArguments,
                }
            };
            process.Start();
            tabControl1.SelectedTab = tabPageProtocol;
        }

        private void checkBoxSettingsEnableCarving_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsEnableCarving = checkBoxSettingsEnableCarving.Checked;
            settings.Save();
        }

        private void checkBoxFileSystemConfigAddUnallocated_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.FileSystemConfigAddUnallocated = checkBoxFileSystemConfigAddUnallocated.Checked;
            settings.Save();
        }

        private void checkBoxSettingsEnableFaceRecognition_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsEnableFaceRecognition = checkBoxSettingsEnableFaceRecognition.Checked;
            settings.Save();
        }

        private void checkBoxSettingsEnableGraphGeneration_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SettingsEnableGraphGeneration = checkBoxSettingsEnableGraphGeneration.Checked;
            settings.Save();
        }
    }
}