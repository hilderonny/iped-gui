using IPED_Gui_WinForms.Properties;
using System.Diagnostics;
using System.Reflection;

namespace IPED_Gui_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            synchronizationContext = SynchronizationContext.Current;
            InitializeComponent();
            LoadSettings();
            CheckForWarning();

            Text += " " + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private SynchronizationContext? synchronizationContext;

        private void CheckForWarning()
        {
            lblWarnung.Text = string.Empty;
            string outputPath = tbAusgabeverzeichnis.Text;
            if (outputPath.Length == 0)
            {
                lblWarnung.Text = "Bitte geben Sie ein Ausgabeverzeichnis an!";
                btnStarten.Enabled = false;
                return;
            }
            if (!Directory.Exists(outputPath))
            {
                lblWarnung.Text = "Das Ausgabeverzeichnis existiert nicht (mehr). Bitte wählen Sie ein existierendes Verzeichnis!";
                btnStarten.Enabled = false;
                return;
            }
            if (!cbProjektErweitern.Checked && !cbFortsetzen.Checked && Directory.GetFileSystemEntries(outputPath).Any())
            {
                lblWarnung.Text = "Das Ausgabeverzeichnis ist nicht leer. Soll das bestehende Projekt erweitert oder ein vorher abgebrochener Vorgang fortgesetzt werden?";
                return;
            }
        }

        private string CreateIpedArguments()
        {
            List<string> argumentParts = new List<string>();
            if (cbFortsetzen.Checked) argumentParts.Add("--continue");
            if (cbInternetdatenLaden.Checked) argumentParts.Add("--downloadInternetData");
            if (cbPortabel.Checked) argumentParts.Add("--portable");
            if (cbProjektErweitern.Checked) argumentParts.Add("--append");
            foreach (var path in lstSpuren.Items)
            {
                argumentParts.Add("-d");
                argumentParts.Add("\"" + path + "\"");
            }
            argumentParts.Add("-o");
            argumentParts.Add("\"" + tbAusgabeverzeichnis.Text + "\"");
            return string.Join(" ", argumentParts);
        }

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
                "enableAudioTranslation = " + (cbAudioTranslation.Checked ? "true" : "false"),
                "enableTextTranslation = false",
                "enableImageClassification = " + (cbBildKlassifizierung.Checked ? "true" : "false")
            };
            return string.Join("\n", configLines);
        }

        private string CreateOcrConfig()
        {
            List<string> configLines = new List<string>
            {
                "enableOCR = " + (cbOcr.Checked ? "true" : "false"),
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

        private void LoadSettings()
        {
            Settings settings = Settings.Default;
            tbAusgabeverzeichnis.Text = settings.General_Output_Directory;
            cbProjektErweitern.Checked = settings.General_Append;
            cbFortsetzen.Checked = settings.General_Continue;
            cbPortabel.Checked = settings.General_Portable;
            cbInternetdatenLaden.Checked = settings.General_Download_Internet_Data;
            cbAudioTranslation.Checked = settings.IPEDConfig_enableAudioTranslation;
            cbBildKlassifizierung.Checked = settings.IPEDConfig_enableImageClassification;
            cbOcr.Checked = settings.General_Ocr;
        }

        private void WriteToConsole(string? line)
        {
            tbKonsole.AppendText(line + "\n");
        }

        private void cbProjektErweitern_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            if (cbProjektErweitern.Checked)
            {
                cbFortsetzen.Checked = false;
                settings.General_Continue = false;
            }
            settings.General_Append = cbProjektErweitern.Checked;
            settings.Save();
            CheckForWarning();
        }

        private void cbFortsetzen_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            if (cbFortsetzen.Checked)
            {
                cbProjektErweitern.Checked = false;
                settings.General_Append = false;
            }
            settings.General_Continue = cbFortsetzen.Checked;
            settings.Save();
            CheckForWarning();
        }

        private void cbPortabel_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Portable = cbPortabel.Checked;
            settings.Save();
        }

        private void cbInternetdatenLaden_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Download_Internet_Data = cbInternetdatenLaden.Checked;
            settings.Save();
        }

        private void cbAudioTranslation_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.IPEDConfig_enableAudioTranslation = cbAudioTranslation.Checked;
            settings.Save();
        }

        private void cbBildKlassifizierung_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.IPEDConfig_enableImageClassification = cbBildKlassifizierung.Checked;
            settings.Save();
        }

        private void cbOcr_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.General_Ocr = cbOcr.Checked;
            settings.Save();
        }

        private void btnAuswaehlen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = tbAusgabeverzeichnis.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbAusgabeverzeichnis.Text = folderBrowserDialog.SelectedPath;
                Settings settings = Settings.Default;
                settings.General_Output_Directory = folderBrowserDialog.SelectedPath;
                settings.Save();
                CheckForWarning();
            }
        }

        private void btnVerzeichnisHinzufuegen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lstSpuren.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        private void btnDateienHinzufuegen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in fileDialog.FileNames)
                {
                    lstSpuren.Items.Add(fileName);
                }
            }
        }

        private void lstSpuren_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEntfernen.Enabled = lstSpuren.SelectedItems.Count > 0;
        }

        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = lstSpuren.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                lstSpuren.Items.Remove(selectedItems[i]);
            }
        }

        private void btnStarten_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;

            string cfgIPEDConfig = CreateIPEDConfig();
            File.WriteAllText(settings.General_Iped_Exe_Path + settings.General_Relative_IPEDConfig_File_Path, cfgIPEDConfig);

            string cfgOcrConfig = CreateOcrConfig();
            File.WriteAllText(settings.General_Iped_Exe_Path + settings.General_Relative_OCRConfig_File_Path, cfgOcrConfig);

            string ipedCommand = Settings.Default.General_Iped_Exe_Path + "jre\\bin\\java.exe";
            string ipedArguments = " -jar " + Settings.Default.General_Iped_Exe_Path + "iped.jar " + CreateIpedArguments();
            tbKonsole.Clear();
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
                btnStarten.Enabled = false;

                process.OutputDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);
                process.ErrorDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                btnStarten.Enabled = true;

            }
        }
    }
}