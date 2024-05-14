using System.Diagnostics;
using System.Reflection;

// Tabs verstecken: Siehe https://stackoverflow.com/questions/552579/how-to-hide-tabpage-from-tabcontrol
// Tabs und deren Inhalte sollten eigene Controls mit DataBinding werden, die dynmisch durch Datensatzerweiterung erweitert werden können
// Wie kann man sowas mit Settings synchronisieren? Eigenes Settings-Handling?

namespace IPED_Gui_Simple
{
    public partial class MainForm : Form
    {
        private readonly SynchronizationContext? synchronizationContext;

        private Process? audioProcess;
        private Process? imageProcess;

        /// <summary>
        /// Konstruktor. Erstellt das Hauptfenster
        /// </summary>
        public MainForm()
        {
            synchronizationContext = SynchronizationContext.Current;
            InitializeComponent();

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
            if (Directory.GetFileSystemEntries(outputPath).Any())
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
            List<string> argumentParts = new() { "--downloadInternetData", "-profile " + profileName };
            foreach (var path in listBox_Spuren.Items)
            {
                argumentParts.Add("-d \"" + path + "\"");
            }
            argumentParts.Add("-o \"" + textBox_Ausgabeverzeichnis.Text + "\"");
            return string.Join(" ", argumentParts);
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
            string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string ipedPath = Path.Join(currentDirectory, "iped-4.1.5");
            string profileName = "ipedgui-simple";
            WriteProfileToDisk(ipedPath, profileName);

            string ipedCommand = Path.Join(ipedPath, "iped.exe");
            string ipedArguments = CreateIpedArguments(profileName);
            textBoxConsole.Clear();
            WriteToConsole(ipedCommand + " " + ipedArguments + "\n");

            if (checkBoxAudioProcessing.Checked) audioProcess = startAudioProcessingBackgroundWorker(currentDirectory);
            if (checkBoxImageClassification.Checked) imageProcess = startImageClassificationBackgroundProcess(currentDirectory);

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
            process.EnableRaisingEvents = true;
            process.Exited += Iped_Process_Exited;

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            tabControl1.SelectedTab = tabPageProtocol;

        }

        private void Iped_Process_Exited(object? sender, EventArgs e)
        {
            string profileDirectory = Path.Join(textBox_Ausgabeverzeichnis.Text, "iped", "profile");

            File.WriteAllText(Path.Join(profileDirectory, "IPEDConfig.txt"), string.Join("\n", new string[] {
                "enableAudioTranslation=false",
                "enableImageClassification=false",
            }));

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

        private void buttonSelectSearchTermFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFileDialog.FileName;
                textBoxSearchTermFilePath.Text = selectedFile;
            }
        }

        private Process startAudioProcessingBackgroundWorker(string currentDirectory)
        {
            var workingDirectory = Path.Join(currentDirectory, "background-media-translator");
            var inputDirectory = Path.Join(workingDirectory, "input");
            var processingDirectory = Path.Join(workingDirectory, "processing");
            var outputDirectory = Path.Join(workingDirectory, "output");
            var fasterWhisperDirectory = Path.Join(workingDirectory, "faster-whisper");
            var argosTranslateDirectory = Path.Join(workingDirectory, "argos-translate");

            Directory.CreateDirectory(inputDirectory);
            Directory.CreateDirectory(processingDirectory);
            Directory.CreateDirectory(outputDirectory);

            foreach (FileInfo file in new DirectoryInfo(processingDirectory).EnumerateFiles()) file.Delete();
            foreach (FileInfo file in new DirectoryInfo(outputDirectory).EnumerateFiles()) file.Delete();

            var pythonCommand = Path.Join(workingDirectory, "python", "python.exe");

            List<string> pythonArgumentList = new()
            {
                "\"" + Path.Join(workingDirectory, "background-media-translator.py") + "\"",
                "-i \"" + inputDirectory + "\"",
                "-p \"" + processingDirectory + "\"",
                "-o \"" + outputDirectory + "\"",
                "-w \"" + fasterWhisperDirectory + "\"",
                "-a \"" + argosTranslateDirectory + "\"",
                "-m large-v2",
                "-g"
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
            return process;
        }

        private Process startImageClassificationBackgroundProcess(string currentDirectory)
        {
            var workingDirectory = Path.Join(currentDirectory, "image-classificator");
            var inputDirectory = Path.Join(workingDirectory, "input");
            var processingDirectory = Path.Join(workingDirectory, "processing");
            var outputDirectory = Path.Join(workingDirectory, "output");
            var mobileNetDirectory = Path.Join(workingDirectory, "mobilenet");

            Directory.CreateDirectory(inputDirectory);
            Directory.CreateDirectory(processingDirectory);
            Directory.CreateDirectory(outputDirectory);

            foreach (FileInfo file in new DirectoryInfo(processingDirectory).EnumerateFiles()) file.Delete();
            foreach (FileInfo file in new DirectoryInfo(outputDirectory).EnumerateFiles()) file.Delete();

            var pythonCommand = Path.Join(workingDirectory, "python", "python.exe");

            List<string> pythonArgumentList = new()
            {
                "\"" + Path.Join(workingDirectory, "image-classificator.py") + "\"",
                "-i \"" + inputDirectory + "\"",
                "-p \"" + processingDirectory + "\"",
                "-o \"" + outputDirectory + "\"",
                "-m \"" + mobileNetDirectory + "\"",
                "-l de"
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
            return process;
        }

        private string? CreateRegexConfigTxt()
        {
            var searchTermFilePath = textBoxSearchTermFilePath.Text;
            if (string.IsNullOrEmpty(searchTermFilePath))
            {
                return null;
            }
            var lines = File.ReadLines(searchTermFilePath);
            var regex = $"SEARCHTERMS, true = \\b({string.Join("|", lines)})\\b";
            return regex;
        }

        private void WriteProfileToDisk(string ipedDirectory, string profileName)
        {
            string profileDirectory = Path.Join(ipedDirectory, "profiles", profileName);
            string confDirectory = Path.Join(profileDirectory, "conf");
            Directory.CreateDirectory(confDirectory);

            File.WriteAllText(Path.Join(profileDirectory, "IPEDConfig.txt"), string.Join("\n", new string[] {
                "enableAudioTranslation=" + (checkBoxAudioProcessing.Checked ? "true" : "false"),
                "enableImageClassification=" + (checkBoxImageClassification.Checked ? "true" : "false"),
            }));

            File.WriteAllText(Path.Join(confDirectory, "AudioTranslation.txt"), string.Join("\n", new string[] {
                "inputDirectory=background-media-translator\\input",
                "outputDirectory=background-media-translator\\output",
                "processVideo=true",
                "useForensicTaskBridge=false",
            }));

            File.WriteAllText(Path.Join(confDirectory, "ImageClassification.txt"), string.Join("\n", new string[] {
                "inputDirectory=image-classificator\\input",
                "outputDirectory=image-classificator\\output",
                "useForensicTaskBridge=false",
            }));

            var regexConfig = CreateRegexConfigTxt();
            if (regexConfig != null)
            {
                File.WriteAllText(Path.Join(confDirectory, "RegexConfig.txt"), regexConfig);
            }
        }


    }
}