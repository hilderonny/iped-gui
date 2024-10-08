using IPED_Gui_WinForms.Helper;
using IPED_Gui_WinForms.Properties;
using IPED_Gui_WinForms.UserControls;
using System.Configuration;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

// Tabs verstecken: Siehe https://stackoverflow.com/questions/552579/how-to-hide-tabpage-from-tabcontrol
// Tabs und deren Inhalte sollten eigene Controls mit DataBinding werden, die dynmisch durch Datensatzerweiterung erweitert werden k�nnen
// Wie kann man sowas mit Settings synchronisieren? Eigenes Settings-Handling?

namespace IPED_Gui_WinForms
{
    public partial class MainForm : Form
    {
        private readonly SynchronizationContext? synchronizationContext;
        private readonly SettingsUserControl localConfigSettingsUserControl;
        private readonly SettingsUserControl ipedConfigSettingsUserControl;
        private readonly SettingsUserControl fileSystemConfigSettingsUserControl;
        private readonly SettingsUserControl audioTranslationSettingsUserControl;
        private readonly SettingsUserControl imageClassificationSettingsUserControl;

        /// <summary>
        /// Konstruktor. Erstellt das Hauptfenster
        /// </summary>
        public MainForm()
        {
            synchronizationContext = SynchronizationContext.Current;
            InitializeComponent();

            localConfigSettingsUserControl = new SettingsUserControl(ConfigType.LocalConfig);
            tabPageLocalConfig.Controls.Add(localConfigSettingsUserControl);
            ipedConfigSettingsUserControl = new SettingsUserControl(ConfigType.IPEDConfig);
            tabPageIPEDConfig.Controls.Add(ipedConfigSettingsUserControl);
            fileSystemConfigSettingsUserControl = new SettingsUserControl(ConfigType.FileSystemConfig);
            tabPageFileSystem.Controls.Add(fileSystemConfigSettingsUserControl);
            audioTranslationSettingsUserControl = new SettingsUserControl(ConfigType.AudioTranslation);
            panelAudioTranslationConfig.Controls.Add(audioTranslationSettingsUserControl);
            imageClassificationSettingsUserControl = new SettingsUserControl(ConfigType.ImageClassification);
            panelImageClassificationConfig.Controls.Add(imageClassificationSettingsUserControl);

            LoadSettings();
            categoriesUserControl.LoadCategories();
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
            textBoxSearchTermFilePath.Text = settings.GeneralSearchTermFilePath;

            // Einstellungen
            textBoxSettingsIpedExePath.Text = settings.SettingsIpedExePath;
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
        /// Beim Klicken auf den DateienHinzuf�gen Button wird ein Dateiauswahldialog angezeigt,
        /// mit dem man mehrere Dateien zur Spurenliste hinzuf�gen kann.
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
        /// Beim Klicken auf den VerzeichnisHinzuf�gen Button wird ein 
        /// Verzeichnisauswahldialog angezeigt, mit dem man ein Verzeichnis
        /// zur Spurenliste hinzuf�gen kann.
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
                categoriesUserControl.LoadCategories();
            }
        }

        private void buttonSelectSearchTermFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFileDialog.FileName;
                textBoxSearchTermFilePath.Text = selectedFile;
                Settings.Default.GeneralSearchTermFilePath = selectedFile;
                Settings.Default.Save();
            }
        }

        private void buttonSettingsSaveSettings_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                Filter = "IPED Settings|*.ipedsettings",
                Title = "Einstellungen speichern"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dynamic settingsObject = new ExpandoObject();
                foreach (SettingsProperty property in Settings.Default.Properties)
                {
                    ((IDictionary<string, object>)settingsObject).Add(property.Name, Settings.Default[property.Name]);
                }
                var json = JsonSerializer.Serialize(settingsObject, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(saveFileDialog.FileName, json);
                MessageBox.Show("Einstellungen gespeichert.");
            }
        }

        private void buttonSettingsLoadSettings_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "IPED Settings|*.ipedsettings",
                Title = "Einstellungen laden"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonString = File.ReadAllText(openFileDialog.FileName);
                var settingsObject = JsonSerializer.Deserialize<ExpandoObject>(jsonString);
                if (settingsObject == null)
                {
                    MessageBox.Show("Lesen der Einstellungen fehlgeschlagen!", "Fehler");
                    return;
                }
                else
                {
                    foreach (var kvp in settingsObject)
                    {
                        var property = Settings.Default.Properties[kvp.Key];
                        var valueString = kvp.Value?.ToString();
                        if (property.PropertyType == typeof(bool))
                        {
                            Settings.Default[kvp.Key] = valueString?.Equals("True");
                        }
                        else
                        {
                            Settings.Default[kvp.Key] = valueString;
                        }
                    }
                    Settings.Default.Save();
                    LoadSettings();
                    localConfigSettingsUserControl.Reload();
                    ipedConfigSettingsUserControl.Reload();
                    fileSystemConfigSettingsUserControl.Reload();
                    audioTranslationSettingsUserControl.Reload();
                    imageClassificationSettingsUserControl.Reload();
                    categoriesUserControl.LoadCategories();
                    CheckForWarning();
                    MessageBox.Show("Einstellungen geladen.");
                }
            }
        }

        private void textBoxSearchTermFilePath_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.GeneralSearchTermFilePath = textBoxSearchTermFilePath.Text;
            Settings.Default.Save();
        }

        private void buttonExportProfile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFolder = folderBrowserDialog.SelectedPath;
                ConfigHelper.WriteProfileToPath(selectedFolder);
                MessageBox.Show("Profil gespeichert.");
            }
        }
    }
}