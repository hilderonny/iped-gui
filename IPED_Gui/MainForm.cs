using IPED_Gui_WinForms.Helper;
using IPED_Gui_WinForms.Properties;
using IPED_Gui_WinForms.UserControls;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

// Tabs verstecken: Siehe https://stackoverflow.com/questions/552579/how-to-hide-tabpage-from-tabcontrol
// Tabs und deren Inhalte sollten eigene Controls mit DataBinding werden, die dynmisch durch Datensatzerweiterung erweitert werden können
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

            tabPageLocalConfig.Controls.Add(new SettingsUserControl(ConfigType.LocalConfig));
            tabPageIPEDConfig.Controls.Add(new SettingsUserControl(ConfigType.IPEDConfig));
            tabPageFileSystem.Controls.Add(new SettingsUserControl(ConfigType.FileSystemConfig));
            panelAudioTranslationConfig.Controls.Add(new SettingsUserControl(ConfigType.AudioTranslation));
            panelImageClassificationConfig.Controls.Add(new SettingsUserControl(ConfigType.ImageClassification));

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
                return;
            }
            if (!Directory.Exists(outputPath))
            {
                label_Warnung.Text = "Das Ausgabeverzeichnis existiert nicht (mehr). Bitte wählen Sie ein existierendes Verzeichnis!";
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
        /// Lädt die zuletzt gültigen Einstellungen und aktualisiert die UI-Elemente entsprechend
        /// </summary>
        private void LoadSettings()
        {
            Settings settings = Settings.Default;

            // Übersicht
            textBox_Ausgabeverzeichnis.Text = settings.General_Output_Directory;
            checkBox_ProjektErweitern.Checked = settings.General_Append;
            checkBox_Fortsetzen.Checked = settings.General_Continue;
            checkBox_Portabel.Checked = settings.General_Portable;
            checkBox_InternetdatenLaden.Checked = settings.General_Download_Internet_Data;

            // Einstellungen
            textBoxSettingsIpedExePath.Text = settings.SettingsIpedExePath;

            // Audioübersetzung
            textBoxAudioTranslationServiceProgram.Text = settings.AudioTranslationServiceProgram;
            textBoxAudioTranslationProcessingDirectory.Text = settings.AudioTranslationProcessingDirectory;
            textBoxAudioTranslationFasterWhisperDirectory.Text = settings.AudioTranslationFasterWhisperDirectory;
            textBoxAudioTranslationArgosTranslateDirectory.Text = settings.AudioTranslationArgosTranslateDirectory;
            comboBoxAudioTranslationModelSize.SelectedIndex = comboBoxAudioTranslationModelSize.FindStringExact(settings.AudioTranslationModelSize);
            checkBoxAudioTranslationUseGPU.Checked = settings.AudioTranslationUseGPU;

            // Bildklassifizierung
            textBoxImageClassificationServiceProgram.Text = settings.ImageClassificationServiceProgram;
            textBoxImageClassificationProcessingDirectory.Text = settings.ImageClassificationProcessingDirectory;
            textBoxImageClassificationMobileNetDirectory.Text = settings.ImageClassificationMobileNetDirectory;
            comboBoxImageClassificationLanguage.SelectedIndex = comboBoxImageClassificationLanguage.FindStringExact(settings.ImageClassificationLanguage);
        }

        /// <summary>
        /// Gibt die gegebene Zeichenkette in der Protokoll-Textbox aus und fügt einen Zeilenumbruch ein
        /// </summary>
        private void WriteToConsole(string? line)
        {
            textBoxConsole.AppendText(line);
            textBoxConsole.AppendText(Environment.NewLine);
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
        /// Öffnet nach dem Anklicken des Buttons Auswaehlen einen Verzeichnisauswahldialog.
        /// Wird ein Verzeichnis darin selektiert, wird dieses als Ausgabeverzeichnis festgelegt,
        /// im entsprechenden Textfeld angezeigt und in den Einstellungen unter General_Output_Directory
        /// gespeichert.
        /// </summary>
        private void button_GeneralOutputDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = textBox_Ausgabeverzeichnis.Text
            };
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
            OpenFileDialog fileDialog = new()
            {
                Multiselect = true
            };
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
            ConfigHelper.WriteProfileToDisk(profileName);

            string ipedCommand = Settings.Default.SettingsIpedExePath;
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
        /// Beim Klicken auf den VerzeichnisHinzufügen Button wird ein 
        /// Verzeichnisauswahldialog angezeigt, mit dem man ein Verzeichnis
        /// zur Spurenliste hinzufügen kann.
        /// </summary>
        private void button_VerzeichnisHinzufuegen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
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
    }
}