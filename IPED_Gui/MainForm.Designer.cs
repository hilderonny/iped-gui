namespace IPED_Gui_WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button buttonAudioTranslationInputDirectory;
            Button buttonAudioTranslationOutputDirectory;
            Label label3;
            Button buttonImageClassificationOutputDirectory;
            Button buttonImageClassificationInputDirectory;
            Label label4;
            Button buttonSettingsIpedExePath;
            Button buttonSettingsIndexTemp;
            Button buttonSettingsHashesDB;
            Button buttonSettingsPluginFolder;
            GroupBox groupBox3;
            Button buttonAudioTranslationArgosTranslateDirectory;
            Button buttonAudioTranslationFasterWhisperDirectory;
            Button buttonAudioTranslationProcessingDirectory;
            Label label11;
            Button buttonAudioTranslationServiceProgram;
            GroupBox groupBox4;
            Button buttonImageClassificationMobileNetDirectory;
            Button buttonImageClassificationProcessingDirectory;
            Label label20;
            Button buttonImageClassificationServiceProgram;
            checkBox_ProjektErweitern = new CheckBox();
            checkBox_Fortsetzen = new CheckBox();
            checkBox_Portabel = new CheckBox();
            checkBox_InternetdatenLaden = new CheckBox();
            checkBoxAudioTranslationUseGPU = new CheckBox();
            buttonAudioTranslationStartProcess = new Button();
            comboBoxAudioTranslationModelSize = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            textBoxAudioTranslationArgosTranslateDirectory = new TextBox();
            label13 = new Label();
            textBoxAudioTranslationFasterWhisperDirectory = new TextBox();
            label12 = new Label();
            textBoxAudioTranslationProcessingDirectory = new TextBox();
            textBoxAudioTranslationServiceProgram = new TextBox();
            buttonImageClassificationStartProcess = new Button();
            comboBoxImageClassificationLanguage = new ComboBox();
            label16 = new Label();
            label18 = new Label();
            textBoxImageClassificationMobileNetDirectory = new TextBox();
            label19 = new Label();
            textBoxImageClassificationProcessingDirectory = new TextBox();
            textBoxImageClassificationServiceProgram = new TextBox();
            label_Spuren = new Label();
            listBox_Spuren = new ListBox();
            button_VerzeichnisHinzufuegen = new Button();
            button_Entfernen = new Button();
            label_Ausgabeverzeichnis = new Label();
            textBox_Ausgabeverzeichnis = new TextBox();
            button_Auswaehlen = new Button();
            textBoxConsole = new TextBox();
            button_Starten = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_Warnung = new Label();
            button_DateienHinzufuegen = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            checkBoxAudioTranslationProcessVideos = new CheckBox();
            checkBoxIPEDConfigEnableAudioTranslation = new CheckBox();
            checkBoxIPEDConfigEnableImageClassification = new CheckBox();
            checkBoxSettingsEnableCarving = new CheckBox();
            checkBoxFileSystemConfigAddUnallocated = new CheckBox();
            checkBoxSettingsEnableFaceRecognition = new CheckBox();
            tabControl1 = new TabControl();
            tabPageOverview = new TabPage();
            tabPageSettings = new TabPage();
            label10 = new Label();
            textBoxSettingsPluginFolder = new TextBox();
            label9 = new Label();
            textBoxSettingsHashesDB = new TextBox();
            label8 = new Label();
            textBoxSettingsNumThreads = new TextBox();
            checkBoxSettingsOutputOnSSD = new CheckBox();
            checkBoxSettingsIndexTempOnSSD = new CheckBox();
            label7 = new Label();
            textBoxSettingsIndexTemp = new TextBox();
            label6 = new Label();
            comboBoxSettingsLocale = new ComboBox();
            textBoxSettingsIpedExePath = new TextBox();
            label5 = new Label();
            tabPageAudioTranslation = new TabPage();
            textBoxAudioTranslationOutputDirectory = new TextBox();
            textBoxAudioTranslationInputDirectory = new TextBox();
            tabPageImageClassification = new TabPage();
            textBoxImageClassificationOutputDirectory = new TextBox();
            textBoxImageClassificationInputDirectory = new TextBox();
            tabPageProtocol = new TabPage();
            openFileDialogSettingsIpedExePath = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialogSettingsHashesDB = new OpenFileDialog();
            openFileDialogAudioTranslationServiceProgram = new OpenFileDialog();
            openFileDialogImageClassificationServiceProgram = new OpenFileDialog();
            groupBox2 = new GroupBox();
            buttonAudioTranslationInputDirectory = new Button();
            buttonAudioTranslationOutputDirectory = new Button();
            label3 = new Label();
            buttonImageClassificationOutputDirectory = new Button();
            buttonImageClassificationInputDirectory = new Button();
            label4 = new Label();
            buttonSettingsIpedExePath = new Button();
            buttonSettingsIndexTemp = new Button();
            buttonSettingsHashesDB = new Button();
            buttonSettingsPluginFolder = new Button();
            groupBox3 = new GroupBox();
            buttonAudioTranslationArgosTranslateDirectory = new Button();
            buttonAudioTranslationFasterWhisperDirectory = new Button();
            buttonAudioTranslationProcessingDirectory = new Button();
            label11 = new Label();
            buttonAudioTranslationServiceProgram = new Button();
            groupBox4 = new GroupBox();
            buttonImageClassificationMobileNetDirectory = new Button();
            buttonImageClassificationProcessingDirectory = new Button();
            label20 = new Label();
            buttonImageClassificationServiceProgram = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageOverview.SuspendLayout();
            tabPageSettings.SuspendLayout();
            tabPageAudioTranslation.SuspendLayout();
            tabPageImageClassification.SuspendLayout();
            tabPageProtocol.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(checkBox_ProjektErweitern);
            groupBox2.Controls.Add(checkBox_Fortsetzen);
            groupBox2.Controls.Add(checkBox_Portabel);
            groupBox2.Controls.Add(checkBox_InternetdatenLaden);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(163, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 246);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Optionen";
            // 
            // checkBox_ProjektErweitern
            // 
            checkBox_ProjektErweitern.AutoSize = true;
            checkBox_ProjektErweitern.Location = new Point(6, 22);
            checkBox_ProjektErweitern.Name = "checkBox_ProjektErweitern";
            checkBox_ProjektErweitern.Size = new Size(184, 19);
            checkBox_ProjektErweitern.TabIndex = 8;
            checkBox_ProjektErweitern.Text = "Bestehendes Projekt erweitern";
            toolTip1.SetToolTip(checkBox_ProjektErweitern, "Falls sich in dem Ausgabeverzeichnis bereits ein IPED-Projekt befindet, wird dieses hiermit um die angegebenen Spuren erweitert");
            checkBox_ProjektErweitern.UseVisualStyleBackColor = true;
            checkBox_ProjektErweitern.CheckedChanged += checkBox_ProjektErweitern_CheckedChanged;
            // 
            // checkBox_Fortsetzen
            // 
            checkBox_Fortsetzen.AutoSize = true;
            checkBox_Fortsetzen.Location = new Point(6, 72);
            checkBox_Fortsetzen.Name = "checkBox_Fortsetzen";
            checkBox_Fortsetzen.Size = new Size(158, 19);
            checkBox_Fortsetzen.TabIndex = 9;
            checkBox_Fortsetzen.Text = "Nach Abbruch fortsetzen";
            toolTip1.SetToolTip(checkBox_Fortsetzen, resources.GetString("checkBox_Fortsetzen.ToolTip"));
            checkBox_Fortsetzen.UseVisualStyleBackColor = true;
            checkBox_Fortsetzen.CheckedChanged += checkBox_Fortsetzen_CheckedChanged;
            // 
            // checkBox_Portabel
            // 
            checkBox_Portabel.AutoSize = true;
            checkBox_Portabel.Location = new Point(6, 122);
            checkBox_Portabel.Name = "checkBox_Portabel";
            checkBox_Portabel.Size = new Size(70, 19);
            checkBox_Portabel.TabIndex = 10;
            checkBox_Portabel.Text = "Portabel";
            toolTip1.SetToolTip(checkBox_Portabel, "Kopiert alle Beweismitteldateien in das Ausgabeverzeichnis. Damit kann dessen Inhalt an Ermittler ohne die ursprünglichen Spuren weitergegeben werden");
            checkBox_Portabel.UseVisualStyleBackColor = true;
            checkBox_Portabel.CheckedChanged += checkBox_Portabel_CheckedChanged;
            // 
            // checkBox_InternetdatenLaden
            // 
            checkBox_InternetdatenLaden.AutoSize = true;
            checkBox_InternetdatenLaden.Location = new Point(6, 147);
            checkBox_InternetdatenLaden.Name = "checkBox_InternetdatenLaden";
            checkBox_InternetdatenLaden.Size = new Size(129, 19);
            checkBox_InternetdatenLaden.TabIndex = 11;
            checkBox_InternetdatenLaden.Text = "Internetdaten laden";
            toolTip1.SetToolTip(checkBox_InternetdatenLaden, "Falls in bestimmten Dateien Verweise auf Internetdaten existieren (z.B. Chats mit Bildlinks), werden diese heruntergeladen und offline bereitgestellt.");
            checkBox_InternetdatenLaden.UseVisualStyleBackColor = true;
            checkBox_InternetdatenLaden.CheckedChanged += checkBox_InternetdatenLaden_CheckedChanged;
            // 
            // buttonAudioTranslationInputDirectory
            // 
            buttonAudioTranslationInputDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationInputDirectory.Location = new Point(826, 67);
            buttonAudioTranslationInputDirectory.Name = "buttonAudioTranslationInputDirectory";
            buttonAudioTranslationInputDirectory.Size = new Size(120, 23);
            buttonAudioTranslationInputDirectory.TabIndex = 9;
            buttonAudioTranslationInputDirectory.Text = "Auswählen ...";
            buttonAudioTranslationInputDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationInputDirectory.Click += buttonAudioTranslationInputDirectory_Click;
            // 
            // buttonAudioTranslationOutputDirectory
            // 
            buttonAudioTranslationOutputDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationOutputDirectory.Location = new Point(826, 97);
            buttonAudioTranslationOutputDirectory.Name = "buttonAudioTranslationOutputDirectory";
            buttonAudioTranslationOutputDirectory.Size = new Size(120, 23);
            buttonAudioTranslationOutputDirectory.TabIndex = 12;
            buttonAudioTranslationOutputDirectory.Text = "Auswählen ...";
            buttonAudioTranslationOutputDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationOutputDirectory.Click += buttonAudioTranslationOutputDirectory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 100);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 16;
            label3.Text = "Ausgabeverzeichnis";
            toolTip1.SetToolTip(label3, "Aus diesem Verzeichnis werden die Ergebnisse abgeholt");
            // 
            // buttonImageClassificationOutputDirectory
            // 
            buttonImageClassificationOutputDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonImageClassificationOutputDirectory.Location = new Point(829, 97);
            buttonImageClassificationOutputDirectory.Name = "buttonImageClassificationOutputDirectory";
            buttonImageClassificationOutputDirectory.Size = new Size(120, 23);
            buttonImageClassificationOutputDirectory.TabIndex = 18;
            buttonImageClassificationOutputDirectory.Text = "Auswählen ...";
            buttonImageClassificationOutputDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationOutputDirectory.Click += buttonImageClassificationOutputDirectory_Click_1;
            // 
            // buttonImageClassificationInputDirectory
            // 
            buttonImageClassificationInputDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonImageClassificationInputDirectory.Location = new Point(829, 68);
            buttonImageClassificationInputDirectory.Name = "buttonImageClassificationInputDirectory";
            buttonImageClassificationInputDirectory.Size = new Size(120, 23);
            buttonImageClassificationInputDirectory.TabIndex = 15;
            buttonImageClassificationInputDirectory.Text = "Auswählen ...";
            buttonImageClassificationInputDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationInputDirectory.Click += buttonImageClassificationInputDirectory_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 71);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 19;
            label4.Text = "Eingabeverzeichnis";
            toolTip1.SetToolTip(label4, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // buttonSettingsIpedExePath
            // 
            buttonSettingsIpedExePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSettingsIpedExePath.Location = new Point(827, 43);
            buttonSettingsIpedExePath.Name = "buttonSettingsIpedExePath";
            buttonSettingsIpedExePath.Size = new Size(120, 23);
            buttonSettingsIpedExePath.TabIndex = 10;
            buttonSettingsIpedExePath.Text = "Auswählen ...";
            buttonSettingsIpedExePath.UseVisualStyleBackColor = true;
            buttonSettingsIpedExePath.Click += buttonSettingsIpedExePath_Click;
            // 
            // buttonSettingsIndexTemp
            // 
            buttonSettingsIndexTemp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSettingsIndexTemp.Location = new Point(827, 101);
            buttonSettingsIndexTemp.Name = "buttonSettingsIndexTemp";
            buttonSettingsIndexTemp.Size = new Size(120, 23);
            buttonSettingsIndexTemp.TabIndex = 14;
            buttonSettingsIndexTemp.Text = "Auswählen ...";
            buttonSettingsIndexTemp.UseVisualStyleBackColor = true;
            buttonSettingsIndexTemp.Click += buttonSettingsIndexTemp_Click;
            // 
            // buttonSettingsHashesDB
            // 
            buttonSettingsHashesDB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSettingsHashesDB.Location = new Point(827, 209);
            buttonSettingsHashesDB.Name = "buttonSettingsHashesDB";
            buttonSettingsHashesDB.Size = new Size(120, 23);
            buttonSettingsHashesDB.TabIndex = 21;
            buttonSettingsHashesDB.Text = "Auswählen ...";
            buttonSettingsHashesDB.UseVisualStyleBackColor = true;
            buttonSettingsHashesDB.Click += buttonSettingsHashesDB_Click;
            // 
            // buttonSettingsPluginFolder
            // 
            buttonSettingsPluginFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSettingsPluginFolder.Location = new Point(827, 238);
            buttonSettingsPluginFolder.Name = "buttonSettingsPluginFolder";
            buttonSettingsPluginFolder.Size = new Size(120, 23);
            buttonSettingsPluginFolder.TabIndex = 24;
            buttonSettingsPluginFolder.Text = "Auswählen ...";
            buttonSettingsPluginFolder.UseVisualStyleBackColor = true;
            buttonSettingsPluginFolder.Click += buttonSettingsPluginFolder_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxAudioTranslationUseGPU);
            groupBox3.Controls.Add(buttonAudioTranslationStartProcess);
            groupBox3.Controls.Add(comboBoxAudioTranslationModelSize);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBoxAudioTranslationArgosTranslateDirectory);
            groupBox3.Controls.Add(buttonAudioTranslationArgosTranslateDirectory);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBoxAudioTranslationFasterWhisperDirectory);
            groupBox3.Controls.Add(buttonAudioTranslationFasterWhisperDirectory);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBoxAudioTranslationProcessingDirectory);
            groupBox3.Controls.Add(buttonAudioTranslationProcessingDirectory);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBoxAudioTranslationServiceProgram);
            groupBox3.Controls.Add(buttonAudioTranslationServiceProgram);
            groupBox3.Location = new Point(3, 151);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(984, 386);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lokale Verarbeitung";
            // 
            // checkBoxAudioTranslationUseGPU
            // 
            checkBoxAudioTranslationUseGPU.AutoSize = true;
            checkBoxAudioTranslationUseGPU.Location = new Point(196, 167);
            checkBoxAudioTranslationUseGPU.Name = "checkBoxAudioTranslationUseGPU";
            checkBoxAudioTranslationUseGPU.Size = new Size(110, 19);
            checkBoxAudioTranslationUseGPU.TabIndex = 16;
            checkBoxAudioTranslationUseGPU.Text = "GPU verwenden";
            toolTip1.SetToolTip(checkBoxAudioTranslationUseGPU, "Verwenden Sie diese Option, wenn Ihr PC über eine Grafikkarte mit mindestens 8GB Video-RAM verfügt");
            checkBoxAudioTranslationUseGPU.UseVisualStyleBackColor = true;
            checkBoxAudioTranslationUseGPU.CheckedChanged += checkBoxAudioTranslationUseGPU_CheckedChanged;
            // 
            // buttonAudioTranslationStartProcess
            // 
            buttonAudioTranslationStartProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationStartProcess.Location = new Point(196, 192);
            buttonAudioTranslationStartProcess.Name = "buttonAudioTranslationStartProcess";
            buttonAudioTranslationStartProcess.Size = new Size(154, 23);
            buttonAudioTranslationStartProcess.TabIndex = 30;
            buttonAudioTranslationStartProcess.Text = "Prozess starten";
            buttonAudioTranslationStartProcess.UseVisualStyleBackColor = true;
            buttonAudioTranslationStartProcess.Click += buttonAudioTranslationStartProcess_Click;
            // 
            // comboBoxAudioTranslationModelSize
            // 
            comboBoxAudioTranslationModelSize.FormattingEnabled = true;
            comboBoxAudioTranslationModelSize.Items.AddRange(new object[] { "tiny", "base", "small", "medium", "large-v2" });
            comboBoxAudioTranslationModelSize.Location = new Point(196, 138);
            comboBoxAudioTranslationModelSize.Name = "comboBoxAudioTranslationModelSize";
            comboBoxAudioTranslationModelSize.Size = new Size(121, 23);
            comboBoxAudioTranslationModelSize.TabIndex = 29;
            comboBoxAudioTranslationModelSize.SelectedIndexChanged += comboBoxAudioTranslationModelSize_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(39, 141);
            label15.Name = "label15";
            label15.Size = new Size(75, 15);
            label15.TabIndex = 28;
            label15.Text = "Modellgröße";
            toolTip1.SetToolTip(label15, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 112);
            label14.Name = "label14";
            label14.Size = new Size(148, 15);
            label14.TabIndex = 25;
            label14.Text = "Argos Translate Verzeichnis";
            toolTip1.SetToolTip(label14, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxAudioTranslationArgosTranslateDirectory
            // 
            textBoxAudioTranslationArgosTranslateDirectory.Location = new Point(196, 109);
            textBoxAudioTranslationArgosTranslateDirectory.Name = "textBoxAudioTranslationArgosTranslateDirectory";
            textBoxAudioTranslationArgosTranslateDirectory.ReadOnly = true;
            textBoxAudioTranslationArgosTranslateDirectory.Size = new Size(621, 23);
            textBoxAudioTranslationArgosTranslateDirectory.TabIndex = 26;
            // 
            // buttonAudioTranslationArgosTranslateDirectory
            // 
            buttonAudioTranslationArgosTranslateDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationArgosTranslateDirectory.Location = new Point(823, 108);
            buttonAudioTranslationArgosTranslateDirectory.Name = "buttonAudioTranslationArgosTranslateDirectory";
            buttonAudioTranslationArgosTranslateDirectory.Size = new Size(120, 23);
            buttonAudioTranslationArgosTranslateDirectory.TabIndex = 27;
            buttonAudioTranslationArgosTranslateDirectory.Text = "Auswählen ...";
            buttonAudioTranslationArgosTranslateDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationArgosTranslateDirectory.Click += buttonAudioTranslationArgosTranslateDirectory_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 83);
            label13.Name = "label13";
            label13.Size = new Size(145, 15);
            label13.TabIndex = 22;
            label13.Text = "Faster Whisper Verzeichnis";
            toolTip1.SetToolTip(label13, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxAudioTranslationFasterWhisperDirectory
            // 
            textBoxAudioTranslationFasterWhisperDirectory.Location = new Point(196, 80);
            textBoxAudioTranslationFasterWhisperDirectory.Name = "textBoxAudioTranslationFasterWhisperDirectory";
            textBoxAudioTranslationFasterWhisperDirectory.ReadOnly = true;
            textBoxAudioTranslationFasterWhisperDirectory.Size = new Size(621, 23);
            textBoxAudioTranslationFasterWhisperDirectory.TabIndex = 23;
            // 
            // buttonAudioTranslationFasterWhisperDirectory
            // 
            buttonAudioTranslationFasterWhisperDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationFasterWhisperDirectory.Location = new Point(823, 79);
            buttonAudioTranslationFasterWhisperDirectory.Name = "buttonAudioTranslationFasterWhisperDirectory";
            buttonAudioTranslationFasterWhisperDirectory.Size = new Size(120, 23);
            buttonAudioTranslationFasterWhisperDirectory.TabIndex = 24;
            buttonAudioTranslationFasterWhisperDirectory.Text = "Auswählen ...";
            buttonAudioTranslationFasterWhisperDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationFasterWhisperDirectory.Click += buttonAudioTranslationFasterWhisperDirectory_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 54);
            label12.Name = "label12";
            label12.Size = new Size(137, 15);
            label12.TabIndex = 19;
            label12.Text = "Verarbeitungsverzeichnis";
            toolTip1.SetToolTip(label12, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxAudioTranslationProcessingDirectory
            // 
            textBoxAudioTranslationProcessingDirectory.Location = new Point(196, 51);
            textBoxAudioTranslationProcessingDirectory.Name = "textBoxAudioTranslationProcessingDirectory";
            textBoxAudioTranslationProcessingDirectory.ReadOnly = true;
            textBoxAudioTranslationProcessingDirectory.Size = new Size(621, 23);
            textBoxAudioTranslationProcessingDirectory.TabIndex = 20;
            // 
            // buttonAudioTranslationProcessingDirectory
            // 
            buttonAudioTranslationProcessingDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationProcessingDirectory.Location = new Point(823, 50);
            buttonAudioTranslationProcessingDirectory.Name = "buttonAudioTranslationProcessingDirectory";
            buttonAudioTranslationProcessingDirectory.Size = new Size(120, 23);
            buttonAudioTranslationProcessingDirectory.TabIndex = 21;
            buttonAudioTranslationProcessingDirectory.Text = "Auswählen ...";
            buttonAudioTranslationProcessingDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationProcessingDirectory.Click += buttonAudioTranslationProcessingDirectory_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 25);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 16;
            label11.Text = "Dienstprogramm";
            toolTip1.SetToolTip(label11, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxAudioTranslationServiceProgram
            // 
            textBoxAudioTranslationServiceProgram.Location = new Point(196, 22);
            textBoxAudioTranslationServiceProgram.Name = "textBoxAudioTranslationServiceProgram";
            textBoxAudioTranslationServiceProgram.ReadOnly = true;
            textBoxAudioTranslationServiceProgram.Size = new Size(621, 23);
            textBoxAudioTranslationServiceProgram.TabIndex = 17;
            // 
            // buttonAudioTranslationServiceProgram
            // 
            buttonAudioTranslationServiceProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationServiceProgram.Location = new Point(823, 21);
            buttonAudioTranslationServiceProgram.Name = "buttonAudioTranslationServiceProgram";
            buttonAudioTranslationServiceProgram.Size = new Size(120, 23);
            buttonAudioTranslationServiceProgram.TabIndex = 18;
            buttonAudioTranslationServiceProgram.Text = "Auswählen ...";
            buttonAudioTranslationServiceProgram.UseVisualStyleBackColor = true;
            buttonAudioTranslationServiceProgram.Click += buttonAudioTranslationServiceProgram_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonImageClassificationStartProcess);
            groupBox4.Controls.Add(comboBoxImageClassificationLanguage);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(textBoxImageClassificationMobileNetDirectory);
            groupBox4.Controls.Add(buttonImageClassificationMobileNetDirectory);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(textBoxImageClassificationProcessingDirectory);
            groupBox4.Controls.Add(buttonImageClassificationProcessingDirectory);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(textBoxImageClassificationServiceProgram);
            groupBox4.Controls.Add(buttonImageClassificationServiceProgram);
            groupBox4.Location = new Point(3, 151);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(984, 386);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lokale Verarbeitung";
            // 
            // buttonImageClassificationStartProcess
            // 
            buttonImageClassificationStartProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonImageClassificationStartProcess.Location = new Point(196, 138);
            buttonImageClassificationStartProcess.Name = "buttonImageClassificationStartProcess";
            buttonImageClassificationStartProcess.Size = new Size(154, 23);
            buttonImageClassificationStartProcess.TabIndex = 31;
            buttonImageClassificationStartProcess.Text = "Prozess starten";
            buttonImageClassificationStartProcess.UseVisualStyleBackColor = true;
            buttonImageClassificationStartProcess.Click += buttonImageClassificationStartProcess_Click;
            // 
            // comboBoxImageClassificationLanguage
            // 
            comboBoxImageClassificationLanguage.FormattingEnabled = true;
            comboBoxImageClassificationLanguage.Items.AddRange(new object[] { "de", "en" });
            comboBoxImageClassificationLanguage.Location = new Point(196, 109);
            comboBoxImageClassificationLanguage.Name = "comboBoxImageClassificationLanguage";
            comboBoxImageClassificationLanguage.Size = new Size(121, 23);
            comboBoxImageClassificationLanguage.TabIndex = 29;
            comboBoxImageClassificationLanguage.SelectedIndexChanged += comboBoxImageClassificationLanguage_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(39, 112);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 28;
            label16.Text = "Sprache";
            toolTip1.SetToolTip(label16, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(39, 83);
            label18.Name = "label18";
            label18.Size = new Size(124, 15);
            label18.TabIndex = 22;
            label18.Text = "MobileNet Verzeichnis";
            toolTip1.SetToolTip(label18, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxImageClassificationMobileNetDirectory
            // 
            textBoxImageClassificationMobileNetDirectory.Location = new Point(196, 80);
            textBoxImageClassificationMobileNetDirectory.Name = "textBoxImageClassificationMobileNetDirectory";
            textBoxImageClassificationMobileNetDirectory.ReadOnly = true;
            textBoxImageClassificationMobileNetDirectory.Size = new Size(621, 23);
            textBoxImageClassificationMobileNetDirectory.TabIndex = 23;
            // 
            // buttonImageClassificationMobileNetDirectory
            // 
            buttonImageClassificationMobileNetDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonImageClassificationMobileNetDirectory.Location = new Point(823, 79);
            buttonImageClassificationMobileNetDirectory.Name = "buttonImageClassificationMobileNetDirectory";
            buttonImageClassificationMobileNetDirectory.Size = new Size(123, 23);
            buttonImageClassificationMobileNetDirectory.TabIndex = 24;
            buttonImageClassificationMobileNetDirectory.Text = "Auswählen ...";
            buttonImageClassificationMobileNetDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationMobileNetDirectory.Click += buttonImageClassificationMobileNetDirectory_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(39, 54);
            label19.Name = "label19";
            label19.Size = new Size(137, 15);
            label19.TabIndex = 19;
            label19.Text = "Verarbeitungsverzeichnis";
            toolTip1.SetToolTip(label19, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxImageClassificationProcessingDirectory
            // 
            textBoxImageClassificationProcessingDirectory.Location = new Point(196, 51);
            textBoxImageClassificationProcessingDirectory.Name = "textBoxImageClassificationProcessingDirectory";
            textBoxImageClassificationProcessingDirectory.ReadOnly = true;
            textBoxImageClassificationProcessingDirectory.Size = new Size(621, 23);
            textBoxImageClassificationProcessingDirectory.TabIndex = 20;
            // 
            // buttonImageClassificationProcessingDirectory
            // 
            buttonImageClassificationProcessingDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonImageClassificationProcessingDirectory.Location = new Point(823, 50);
            buttonImageClassificationProcessingDirectory.Name = "buttonImageClassificationProcessingDirectory";
            buttonImageClassificationProcessingDirectory.Size = new Size(123, 23);
            buttonImageClassificationProcessingDirectory.TabIndex = 21;
            buttonImageClassificationProcessingDirectory.Text = "Auswählen ...";
            buttonImageClassificationProcessingDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationProcessingDirectory.Click += buttonImageClassificationProcessingDirectory_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(39, 25);
            label20.Name = "label20";
            label20.Size = new Size(97, 15);
            label20.TabIndex = 16;
            label20.Text = "Dienstprogramm";
            toolTip1.SetToolTip(label20, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // textBoxImageClassificationServiceProgram
            // 
            textBoxImageClassificationServiceProgram.Location = new Point(196, 22);
            textBoxImageClassificationServiceProgram.Name = "textBoxImageClassificationServiceProgram";
            textBoxImageClassificationServiceProgram.ReadOnly = true;
            textBoxImageClassificationServiceProgram.Size = new Size(621, 23);
            textBoxImageClassificationServiceProgram.TabIndex = 17;
            // 
            // buttonImageClassificationServiceProgram
            // 
            buttonImageClassificationServiceProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonImageClassificationServiceProgram.Location = new Point(823, 21);
            buttonImageClassificationServiceProgram.Name = "buttonImageClassificationServiceProgram";
            buttonImageClassificationServiceProgram.Size = new Size(123, 23);
            buttonImageClassificationServiceProgram.TabIndex = 18;
            buttonImageClassificationServiceProgram.Text = "Auswählen ...";
            buttonImageClassificationServiceProgram.UseVisualStyleBackColor = true;
            buttonImageClassificationServiceProgram.Click += buttonImageClassificationServiceProgram_Click;
            // 
            // label_Spuren
            // 
            label_Spuren.AutoSize = true;
            label_Spuren.Location = new Point(3, 0);
            label_Spuren.Name = "label_Spuren";
            label_Spuren.Size = new Size(44, 15);
            label_Spuren.TabIndex = 0;
            label_Spuren.Text = "Spuren";
            // 
            // listBox_Spuren
            // 
            tableLayoutPanel1.SetColumnSpan(listBox_Spuren, 2);
            listBox_Spuren.Dock = DockStyle.Fill;
            listBox_Spuren.FormattingEnabled = true;
            listBox_Spuren.ItemHeight = 15;
            listBox_Spuren.Location = new Point(163, 3);
            listBox_Spuren.Name = "listBox_Spuren";
            tableLayoutPanel1.SetRowSpan(listBox_Spuren, 3);
            listBox_Spuren.SelectionMode = SelectionMode.MultiExtended;
            listBox_Spuren.Size = new Size(658, 154);
            listBox_Spuren.TabIndex = 1;
            toolTip1.SetToolTip(listBox_Spuren, "Auflistung aller Spuren, die beim Starten verarbeitet werden. Mehrfachselektion zum Entfernen möglich.");
            listBox_Spuren.SelectedIndexChanged += listBox_Spuren_SelectedIndexChanged;
            // 
            // button_VerzeichnisHinzufuegen
            // 
            button_VerzeichnisHinzufuegen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_VerzeichnisHinzufuegen.Location = new Point(827, 3);
            button_VerzeichnisHinzufuegen.Name = "button_VerzeichnisHinzufuegen";
            button_VerzeichnisHinzufuegen.Size = new Size(154, 23);
            button_VerzeichnisHinzufuegen.TabIndex = 2;
            button_VerzeichnisHinzufuegen.Text = "Verzeichnis hinzufügen";
            toolTip1.SetToolTip(button_VerzeichnisHinzufuegen, "Auswahl eines Verzeichnisses, deren Inhalt als Spur aufgenommen werden soll");
            button_VerzeichnisHinzufuegen.UseVisualStyleBackColor = true;
            button_VerzeichnisHinzufuegen.Click += button_VerzeichnisHinzufuegen_Click;
            // 
            // button_Entfernen
            // 
            button_Entfernen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_Entfernen.Enabled = false;
            button_Entfernen.Location = new Point(827, 63);
            button_Entfernen.Name = "button_Entfernen";
            button_Entfernen.Size = new Size(154, 23);
            button_Entfernen.TabIndex = 3;
            button_Entfernen.Text = "Entfernen";
            toolTip1.SetToolTip(button_Entfernen, "Entfernt alle selektierten Spuren aus der Spurenliste");
            button_Entfernen.UseVisualStyleBackColor = true;
            button_Entfernen.Click += button_Entfernen_Click;
            // 
            // label_Ausgabeverzeichnis
            // 
            label_Ausgabeverzeichnis.AutoSize = true;
            label_Ausgabeverzeichnis.Location = new Point(3, 160);
            label_Ausgabeverzeichnis.Name = "label_Ausgabeverzeichnis";
            label_Ausgabeverzeichnis.Size = new Size(111, 15);
            label_Ausgabeverzeichnis.TabIndex = 4;
            label_Ausgabeverzeichnis.Text = "Ausgabeverzeichnis";
            // 
            // textBox_Ausgabeverzeichnis
            // 
            tableLayoutPanel1.SetColumnSpan(textBox_Ausgabeverzeichnis, 2);
            textBox_Ausgabeverzeichnis.Dock = DockStyle.Fill;
            textBox_Ausgabeverzeichnis.Location = new Point(163, 163);
            textBox_Ausgabeverzeichnis.Name = "textBox_Ausgabeverzeichnis";
            textBox_Ausgabeverzeichnis.ReadOnly = true;
            textBox_Ausgabeverzeichnis.Size = new Size(658, 23);
            textBox_Ausgabeverzeichnis.TabIndex = 5;
            toolTip1.SetToolTip(textBox_Ausgabeverzeichnis, "Verzeichnis, in welchem das IPED-Projekt erstellt bzw. erweitert wird");
            // 
            // button_Auswaehlen
            // 
            button_Auswaehlen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_Auswaehlen.Location = new Point(827, 163);
            button_Auswaehlen.Name = "button_Auswaehlen";
            button_Auswaehlen.Size = new Size(154, 23);
            button_Auswaehlen.TabIndex = 6;
            button_Auswaehlen.Text = "Auswählen ...";
            toolTip1.SetToolTip(button_Auswaehlen, "Auswahl des Ausgabeverzeichnisses für das IPED-Projekt");
            button_Auswaehlen.UseVisualStyleBackColor = true;
            button_Auswaehlen.Click += button_GeneralOutputDirectory_Click;
            // 
            // textBoxConsole
            // 
            textBoxConsole.AcceptsReturn = true;
            textBoxConsole.Dock = DockStyle.Fill;
            textBoxConsole.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsole.Location = new Point(3, 3);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.ScrollBars = ScrollBars.Vertical;
            textBoxConsole.Size = new Size(984, 534);
            textBoxConsole.TabIndex = 15;
            toolTip1.SetToolTip(textBoxConsole, "Ausgabe des IPED-Programmdurchlaufs");
            // 
            // button_Starten
            // 
            button_Starten.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Starten.Location = new Point(827, 508);
            button_Starten.Name = "button_Starten";
            button_Starten.Size = new Size(154, 23);
            button_Starten.TabIndex = 16;
            button_Starten.Text = "Starten";
            toolTip1.SetToolTip(button_Starten, "Startet IPED und verarbeitet die gegebenen Spuren mit den gegebenen Einstellungen");
            button_Starten.UseVisualStyleBackColor = true;
            button_Starten.Click += button_Starten_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.Controls.Add(label_Spuren, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox_Spuren, 1, 0);
            tableLayoutPanel1.Controls.Add(button_VerzeichnisHinzufuegen, 3, 0);
            tableLayoutPanel1.Controls.Add(button_Entfernen, 3, 2);
            tableLayoutPanel1.Controls.Add(label_Ausgabeverzeichnis, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox_Ausgabeverzeichnis, 1, 3);
            tableLayoutPanel1.Controls.Add(button_Auswaehlen, 3, 3);
            tableLayoutPanel1.Controls.Add(button_Starten, 3, 6);
            tableLayoutPanel1.Controls.Add(label_Warnung, 1, 4);
            tableLayoutPanel1.Controls.Add(button_DateienHinzufuegen, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 252F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(984, 534);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // label_Warnung
            // 
            label_Warnung.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label_Warnung, 2);
            label_Warnung.Dock = DockStyle.Fill;
            label_Warnung.ForeColor = Color.Red;
            label_Warnung.Location = new Point(163, 190);
            label_Warnung.Name = "label_Warnung";
            label_Warnung.Size = new Size(658, 60);
            label_Warnung.TabIndex = 17;
            // 
            // button_DateienHinzufuegen
            // 
            button_DateienHinzufuegen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_DateienHinzufuegen.Location = new Point(827, 33);
            button_DateienHinzufuegen.Name = "button_DateienHinzufuegen";
            button_DateienHinzufuegen.Size = new Size(154, 23);
            button_DateienHinzufuegen.TabIndex = 18;
            button_DateienHinzufuegen.Text = "Dateien hinzufügen";
            toolTip1.SetToolTip(button_DateienHinzufuegen, "Auswahl einer Datei als Spur. Das können Container (dd, e01, zip, ,...) oder ganz normale Dateien sein");
            button_DateienHinzufuegen.UseVisualStyleBackColor = true;
            button_DateienHinzufuegen.Click += button_DateienHinzufuegen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 71);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Eingabeverzeichnis";
            toolTip1.SetToolTip(label1, "In diesem Verzeichnis werden die zu verarbeitenden Dateien abgelegt");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 10;
            label2.Text = "Ausgabeverzeichnis";
            toolTip1.SetToolTip(label2, "Aus diesem Verzeichnis werden die Ergebnisse abgeholt");
            // 
            // checkBoxAudioTranslationProcessVideos
            // 
            checkBoxAudioTranslationProcessVideos.AutoSize = true;
            checkBoxAudioTranslationProcessVideos.Location = new Point(199, 126);
            checkBoxAudioTranslationProcessVideos.Name = "checkBoxAudioTranslationProcessVideos";
            checkBoxAudioTranslationProcessVideos.Size = new Size(123, 19);
            checkBoxAudioTranslationProcessVideos.TabIndex = 13;
            checkBoxAudioTranslationProcessVideos.Text = "Videos verarbeiten";
            toolTip1.SetToolTip(checkBoxAudioTranslationProcessVideos, "Die Videoverarbeitung kann sehr lange dauern, wenn sich auf der Spur Kinofilme befinden");
            checkBoxAudioTranslationProcessVideos.UseVisualStyleBackColor = true;
            checkBoxAudioTranslationProcessVideos.CheckedChanged += checkBoxAudioTranslationProcessVideos_CheckedChanged;
            // 
            // checkBoxIPEDConfigEnableAudioTranslation
            // 
            checkBoxIPEDConfigEnableAudioTranslation.AutoSize = true;
            checkBoxIPEDConfigEnableAudioTranslation.Location = new Point(199, 43);
            checkBoxIPEDConfigEnableAudioTranslation.Name = "checkBoxIPEDConfigEnableAudioTranslation";
            checkBoxIPEDConfigEnableAudioTranslation.Size = new Size(222, 19);
            checkBoxIPEDConfigEnableAudioTranslation.TabIndex = 14;
            checkBoxIPEDConfigEnableAudioTranslation.Text = "Audio Transkription und Übersetzung";
            toolTip1.SetToolTip(checkBoxIPEDConfigEnableAudioTranslation, "Führt bei Audio- und Videodateien Transkriptionen und Übersetzung ins Deutsche mit Hilfe des Auswerteservers durch.");
            checkBoxIPEDConfigEnableAudioTranslation.UseVisualStyleBackColor = true;
            checkBoxIPEDConfigEnableAudioTranslation.CheckedChanged += checkBoxIPEDConfigEnabelAudioTranslation_CheckedChanged;
            // 
            // checkBoxIPEDConfigEnableImageClassification
            // 
            checkBoxIPEDConfigEnableImageClassification.AutoSize = true;
            checkBoxIPEDConfigEnableImageClassification.Location = new Point(202, 43);
            checkBoxIPEDConfigEnableImageClassification.Name = "checkBoxIPEDConfigEnableImageClassification";
            checkBoxIPEDConfigEnableImageClassification.Size = new Size(125, 19);
            checkBoxIPEDConfigEnableImageClassification.TabIndex = 20;
            checkBoxIPEDConfigEnableImageClassification.Text = "Bilder klassifizieren";
            toolTip1.SetToolTip(checkBoxIPEDConfigEnableImageClassification, "Führt eine Klassifizierung von Bilddateien mit Hilfe des Auswerteservers durch.");
            checkBoxIPEDConfigEnableImageClassification.UseVisualStyleBackColor = true;
            checkBoxIPEDConfigEnableImageClassification.CheckedChanged += checkBoxIPEDConfigEnableImageClassification_CheckedChanged;
            // 
            // checkBoxSettingsEnableCarving
            // 
            checkBoxSettingsEnableCarving.AutoSize = true;
            checkBoxSettingsEnableCarving.Location = new Point(250, 267);
            checkBoxSettingsEnableCarving.Name = "checkBoxSettingsEnableCarving";
            checkBoxSettingsEnableCarving.Size = new Size(121, 19);
            checkBoxSettingsEnableCarving.TabIndex = 26;
            checkBoxSettingsEnableCarving.Text = "Carving aktivieren";
            toolTip1.SetToolTip(checkBoxSettingsEnableCarving, "Durchsucht die Sektoren eines Images nach gelöschten Dateien anhand ihrer Kopfsignaturen.");
            checkBoxSettingsEnableCarving.UseVisualStyleBackColor = true;
            checkBoxSettingsEnableCarving.CheckedChanged += checkBoxSettingsEnableCarving_CheckedChanged;
            // 
            // checkBoxFileSystemConfigAddUnallocated
            // 
            checkBoxFileSystemConfigAddUnallocated.AutoSize = true;
            checkBoxFileSystemConfigAddUnallocated.Location = new Point(250, 292);
            checkBoxFileSystemConfigAddUnallocated.Name = "checkBoxFileSystemConfigAddUnallocated";
            checkBoxFileSystemConfigAddUnallocated.Size = new Size(253, 19);
            checkBoxFileSystemConfigAddUnallocated.TabIndex = 27;
            checkBoxFileSystemConfigAddUnallocated.Text = "Unbenutzten Speicherbereich durchsuchen";
            toolTip1.SetToolTip(checkBoxFileSystemConfigAddUnallocated, "Durchsucht den Speicherbereich eines Images, welcher nicht durch eine Partition belegt ist. Nur sinnvoll in Zusammenhang mit \"Carving aktivieren\"");
            checkBoxFileSystemConfigAddUnallocated.UseVisualStyleBackColor = true;
            checkBoxFileSystemConfigAddUnallocated.CheckedChanged += checkBoxFileSystemConfigAddUnallocated_CheckedChanged;
            // 
            // checkBoxSettingsEnableFaceRecognition
            // 
            checkBoxSettingsEnableFaceRecognition.AutoSize = true;
            checkBoxSettingsEnableFaceRecognition.Location = new Point(250, 317);
            checkBoxSettingsEnableFaceRecognition.Name = "checkBoxSettingsEnableFaceRecognition";
            checkBoxSettingsEnableFaceRecognition.Size = new Size(180, 19);
            checkBoxSettingsEnableFaceRecognition.TabIndex = 28;
            checkBoxSettingsEnableFaceRecognition.Text = "Gesichtserkennung in Bildern";
            toolTip1.SetToolTip(checkBoxSettingsEnableFaceRecognition, "Beinhaltet sowohl Bilder als auch Thumbnails bei Videos. Dazu muss bei Videos die Thumbnail-Generierung eingeschaltet sein");
            checkBoxSettingsEnableFaceRecognition.UseVisualStyleBackColor = true;
            checkBoxSettingsEnableFaceRecognition.CheckedChanged += checkBoxSettingsEnableFaceRecognition_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOverview);
            tabControl1.Controls.Add(tabPageSettings);
            tabControl1.Controls.Add(tabPageAudioTranslation);
            tabControl1.Controls.Add(tabPageImageClassification);
            tabControl1.Controls.Add(tabPageProtocol);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 568);
            tabControl1.TabIndex = 19;
            // 
            // tabPageOverview
            // 
            tabPageOverview.Controls.Add(tableLayoutPanel1);
            tabPageOverview.Location = new Point(4, 24);
            tabPageOverview.Name = "tabPageOverview";
            tabPageOverview.Padding = new Padding(3);
            tabPageOverview.Size = new Size(990, 540);
            tabPageOverview.TabIndex = 0;
            tabPageOverview.Text = "Übersicht";
            tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(checkBoxSettingsEnableFaceRecognition);
            tabPageSettings.Controls.Add(checkBoxFileSystemConfigAddUnallocated);
            tabPageSettings.Controls.Add(checkBoxSettingsEnableCarving);
            tabPageSettings.Controls.Add(label10);
            tabPageSettings.Controls.Add(buttonSettingsPluginFolder);
            tabPageSettings.Controls.Add(textBoxSettingsPluginFolder);
            tabPageSettings.Controls.Add(label9);
            tabPageSettings.Controls.Add(buttonSettingsHashesDB);
            tabPageSettings.Controls.Add(textBoxSettingsHashesDB);
            tabPageSettings.Controls.Add(label8);
            tabPageSettings.Controls.Add(textBoxSettingsNumThreads);
            tabPageSettings.Controls.Add(checkBoxSettingsOutputOnSSD);
            tabPageSettings.Controls.Add(checkBoxSettingsIndexTempOnSSD);
            tabPageSettings.Controls.Add(label7);
            tabPageSettings.Controls.Add(buttonSettingsIndexTemp);
            tabPageSettings.Controls.Add(textBoxSettingsIndexTemp);
            tabPageSettings.Controls.Add(label6);
            tabPageSettings.Controls.Add(comboBoxSettingsLocale);
            tabPageSettings.Controls.Add(buttonSettingsIpedExePath);
            tabPageSettings.Controls.Add(textBoxSettingsIpedExePath);
            tabPageSettings.Controls.Add(label5);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(40);
            tabPageSettings.Size = new Size(990, 540);
            tabPageSettings.TabIndex = 10;
            tabPageSettings.Text = "Einstellungen";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 241);
            label10.Name = "label10";
            label10.Size = new Size(125, 15);
            label10.TabIndex = 25;
            label10.Text = "Verzeichnis für Plugins";
            // 
            // textBoxSettingsPluginFolder
            // 
            textBoxSettingsPluginFolder.Location = new Point(250, 238);
            textBoxSettingsPluginFolder.Name = "textBoxSettingsPluginFolder";
            textBoxSettingsPluginFolder.ReadOnly = true;
            textBoxSettingsPluginFolder.Size = new Size(571, 23);
            textBoxSettingsPluginFolder.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 212);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 22;
            label9.Text = "Hash Datenbank";
            // 
            // textBoxSettingsHashesDB
            // 
            textBoxSettingsHashesDB.Location = new Point(250, 209);
            textBoxSettingsHashesDB.Name = "textBoxSettingsHashesDB";
            textBoxSettingsHashesDB.ReadOnly = true;
            textBoxSettingsHashesDB.Size = new Size(571, 23);
            textBoxSettingsHashesDB.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 183);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 19;
            label8.Text = "Anzahl Threads";
            // 
            // textBoxSettingsNumThreads
            // 
            textBoxSettingsNumThreads.Location = new Point(250, 180);
            textBoxSettingsNumThreads.Name = "textBoxSettingsNumThreads";
            textBoxSettingsNumThreads.Size = new Size(100, 23);
            textBoxSettingsNumThreads.TabIndex = 18;
            textBoxSettingsNumThreads.TextChanged += textBoxSettingsNumThreads_TextChanged;
            // 
            // checkBoxSettingsOutputOnSSD
            // 
            checkBoxSettingsOutputOnSSD.AutoSize = true;
            checkBoxSettingsOutputOnSSD.Location = new Point(250, 155);
            checkBoxSettingsOutputOnSSD.Name = "checkBoxSettingsOutputOnSSD";
            checkBoxSettingsOutputOnSSD.Size = new Size(298, 19);
            checkBoxSettingsOutputOnSSD.TabIndex = 17;
            checkBoxSettingsOutputOnSSD.Text = "Ausgabeverzeichnis befindet sich auf SSD Festplatte";
            checkBoxSettingsOutputOnSSD.UseVisualStyleBackColor = true;
            checkBoxSettingsOutputOnSSD.CheckedChanged += checkBoxSettingsOutputOnSSD_CheckedChanged;
            // 
            // checkBoxSettingsIndexTempOnSSD
            // 
            checkBoxSettingsIndexTempOnSSD.AutoSize = true;
            checkBoxSettingsIndexTempOnSSD.Location = new Point(250, 130);
            checkBoxSettingsIndexTempOnSSD.Name = "checkBoxSettingsIndexTempOnSSD";
            checkBoxSettingsIndexTempOnSSD.Size = new Size(316, 19);
            checkBoxSettingsIndexTempOnSSD.TabIndex = 16;
            checkBoxSettingsIndexTempOnSSD.Text = "Temporäres Verzeichnis befindet sich auf SSD Festplatte";
            checkBoxSettingsIndexTempOnSSD.UseVisualStyleBackColor = true;
            checkBoxSettingsIndexTempOnSSD.CheckedChanged += checkBoxSettingsIndexTempOnSSD_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 104);
            label7.Name = "label7";
            label7.Size = new Size(184, 15);
            label7.TabIndex = 15;
            label7.Text = "Verzeichnis für temporäre Dateien";
            // 
            // textBoxSettingsIndexTemp
            // 
            textBoxSettingsIndexTemp.Location = new Point(250, 101);
            textBoxSettingsIndexTemp.Name = "textBoxSettingsIndexTemp";
            textBoxSettingsIndexTemp.ReadOnly = true;
            textBoxSettingsIndexTemp.Size = new Size(571, 23);
            textBoxSettingsIndexTemp.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 75);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 12;
            label6.Text = "Sprache der Oberfläche";
            // 
            // comboBoxSettingsLocale
            // 
            comboBoxSettingsLocale.FormattingEnabled = true;
            comboBoxSettingsLocale.Items.AddRange(new object[] { "en", "pt-BR", "it-IT", "de-DE", "es-AR" });
            comboBoxSettingsLocale.Location = new Point(250, 72);
            comboBoxSettingsLocale.Name = "comboBoxSettingsLocale";
            comboBoxSettingsLocale.Size = new Size(100, 23);
            comboBoxSettingsLocale.TabIndex = 11;
            comboBoxSettingsLocale.SelectedIndexChanged += comboBoxSettingsLocale_SelectedIndexChanged;
            // 
            // textBoxSettingsIpedExePath
            // 
            textBoxSettingsIpedExePath.Location = new Point(250, 43);
            textBoxSettingsIpedExePath.Name = "textBoxSettingsIpedExePath";
            textBoxSettingsIpedExePath.ReadOnly = true;
            textBoxSettingsIpedExePath.Size = new Size(571, 23);
            textBoxSettingsIpedExePath.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 46);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 0;
            label5.Text = "Pfad zu iped.exe";
            // 
            // tabPageAudioTranslation
            // 
            tabPageAudioTranslation.Controls.Add(groupBox3);
            tabPageAudioTranslation.Controls.Add(checkBoxIPEDConfigEnableAudioTranslation);
            tabPageAudioTranslation.Controls.Add(checkBoxAudioTranslationProcessVideos);
            tabPageAudioTranslation.Controls.Add(label2);
            tabPageAudioTranslation.Controls.Add(textBoxAudioTranslationOutputDirectory);
            tabPageAudioTranslation.Controls.Add(buttonAudioTranslationOutputDirectory);
            tabPageAudioTranslation.Controls.Add(label1);
            tabPageAudioTranslation.Controls.Add(textBoxAudioTranslationInputDirectory);
            tabPageAudioTranslation.Controls.Add(buttonAudioTranslationInputDirectory);
            tabPageAudioTranslation.Location = new Point(4, 24);
            tabPageAudioTranslation.Name = "tabPageAudioTranslation";
            tabPageAudioTranslation.Padding = new Padding(40);
            tabPageAudioTranslation.Size = new Size(990, 540);
            tabPageAudioTranslation.TabIndex = 8;
            tabPageAudioTranslation.Text = "Audioübersetzung";
            tabPageAudioTranslation.UseVisualStyleBackColor = true;
            // 
            // textBoxAudioTranslationOutputDirectory
            // 
            textBoxAudioTranslationOutputDirectory.Location = new Point(199, 97);
            textBoxAudioTranslationOutputDirectory.Name = "textBoxAudioTranslationOutputDirectory";
            textBoxAudioTranslationOutputDirectory.ReadOnly = true;
            textBoxAudioTranslationOutputDirectory.Size = new Size(621, 23);
            textBoxAudioTranslationOutputDirectory.TabIndex = 11;
            // 
            // textBoxAudioTranslationInputDirectory
            // 
            textBoxAudioTranslationInputDirectory.Location = new Point(199, 68);
            textBoxAudioTranslationInputDirectory.Name = "textBoxAudioTranslationInputDirectory";
            textBoxAudioTranslationInputDirectory.ReadOnly = true;
            textBoxAudioTranslationInputDirectory.Size = new Size(621, 23);
            textBoxAudioTranslationInputDirectory.TabIndex = 8;
            // 
            // tabPageImageClassification
            // 
            tabPageImageClassification.Controls.Add(groupBox4);
            tabPageImageClassification.Controls.Add(checkBoxIPEDConfigEnableImageClassification);
            tabPageImageClassification.Controls.Add(label4);
            tabPageImageClassification.Controls.Add(label3);
            tabPageImageClassification.Controls.Add(textBoxImageClassificationOutputDirectory);
            tabPageImageClassification.Controls.Add(buttonImageClassificationOutputDirectory);
            tabPageImageClassification.Controls.Add(textBoxImageClassificationInputDirectory);
            tabPageImageClassification.Controls.Add(buttonImageClassificationInputDirectory);
            tabPageImageClassification.Location = new Point(4, 24);
            tabPageImageClassification.Name = "tabPageImageClassification";
            tabPageImageClassification.Padding = new Padding(40);
            tabPageImageClassification.Size = new Size(990, 540);
            tabPageImageClassification.TabIndex = 9;
            tabPageImageClassification.Text = "Bildklassifizierung";
            tabPageImageClassification.UseVisualStyleBackColor = true;
            // 
            // textBoxImageClassificationOutputDirectory
            // 
            textBoxImageClassificationOutputDirectory.Location = new Point(202, 97);
            textBoxImageClassificationOutputDirectory.Name = "textBoxImageClassificationOutputDirectory";
            textBoxImageClassificationOutputDirectory.ReadOnly = true;
            textBoxImageClassificationOutputDirectory.Size = new Size(621, 23);
            textBoxImageClassificationOutputDirectory.TabIndex = 17;
            // 
            // textBoxImageClassificationInputDirectory
            // 
            textBoxImageClassificationInputDirectory.Location = new Point(202, 68);
            textBoxImageClassificationInputDirectory.Name = "textBoxImageClassificationInputDirectory";
            textBoxImageClassificationInputDirectory.ReadOnly = true;
            textBoxImageClassificationInputDirectory.Size = new Size(621, 23);
            textBoxImageClassificationInputDirectory.TabIndex = 14;
            // 
            // tabPageProtocol
            // 
            tabPageProtocol.Controls.Add(textBoxConsole);
            tabPageProtocol.Location = new Point(4, 24);
            tabPageProtocol.Name = "tabPageProtocol";
            tabPageProtocol.Padding = new Padding(3);
            tabPageProtocol.Size = new Size(990, 540);
            tabPageProtocol.TabIndex = 1;
            tabPageProtocol.Text = "Protokoll";
            tabPageProtocol.UseVisualStyleBackColor = true;
            // 
            // openFileDialogSettingsIpedExePath
            // 
            openFileDialogSettingsIpedExePath.Filter = "IPED|iped.exe";
            // 
            // openFileDialogSettingsHashesDB
            // 
            openFileDialogSettingsHashesDB.Filter = "IPED Hash Datenbankl|iped-hashes.db";
            // 
            // openFileDialogAudioTranslationServiceProgram
            // 
            openFileDialogAudioTranslationServiceProgram.Filter = "Audiotranskription Dienstprogramml|background-media-translator.py";
            // 
            // openFileDialogImageClassificationServiceProgram
            // 
            openFileDialogImageClassificationServiceProgram.Filter = "Bildklassifizierung Dienstprogramml|image-classificator.py";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 578);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Padding = new Padding(5);
            Text = "IPED GUI";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageOverview.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            tabPageAudioTranslation.ResumeLayout(false);
            tabPageAudioTranslation.PerformLayout();
            tabPageImageClassification.ResumeLayout(false);
            tabPageImageClassification.PerformLayout();
            tabPageProtocol.ResumeLayout(false);
            tabPageProtocol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Spuren;
        private ListBox listBox_Spuren;
        private Button button_VerzeichnisHinzufuegen;
        private Button button_Entfernen;
        private Label label_Ausgabeverzeichnis;
        private TextBox textBox_Ausgabeverzeichnis;
        private Button button_Auswaehlen;
        private CheckBox checkBox_ProjektErweitern;
        private CheckBox checkBox_Fortsetzen;
        private CheckBox checkBox_Portabel;
        private CheckBox checkBox_InternetdatenLaden;
        private TextBox textBoxConsole;
        private Button button_Starten;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Warnung;
        private Button button_DateienHinzufuegen;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPageOverview;
        private TabPage tabPageProtocol;
        private TabPage tabPageAudioTranslation;
        private TabPage tabPageImageClassification;
        private Label label2;
        private TextBox textBoxAudioTranslationOutputDirectory;
        private Label label1;
        private TextBox textBoxAudioTranslationInputDirectory;
        private CheckBox checkBoxAudioTranslationProcessVideos;
        private TextBox textBoxImageClassificationInputDirectory;
        private TextBox textBoxImageClassificationOutputDirectory;
        private TabPage tabPageSettings;
        private TextBox textBoxSettingsIndexTemp;
        private Label label6;
        private ComboBox comboBoxSettingsLocale;
        private TextBox textBoxSettingsIpedExePath;
        private Label label5;
        private Label label10;
        private TextBox textBoxSettingsPluginFolder;
        private Label label9;
        private TextBox textBoxSettingsHashesDB;
        private Label label8;
        private TextBox textBoxSettingsNumThreads;
        private CheckBox checkBoxSettingsOutputOnSSD;
        private CheckBox checkBoxSettingsIndexTempOnSSD;
        private Label label7;
        private OpenFileDialog openFileDialogSettingsIpedExePath;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialogSettingsHashesDB;
        private CheckBox checkBoxIPEDConfigEnableAudioTranslation;
        private GroupBox groupBox3;
        private Label label13;
        private TextBox textBoxAudioTranslationFasterWhisperDirectory;
        private Label label12;
        private TextBox textBoxAudioTranslationProcessingDirectory;
        private Label label11;
        private TextBox textBoxAudioTranslationServiceProgram;
        private ComboBox comboBoxAudioTranslationModelSize;
        private Label label15;
        private Label label14;
        private TextBox textBoxAudioTranslationArgosTranslateDirectory;
        private Button buttonAudioTranslationStartProcess;
        private OpenFileDialog openFileDialogAudioTranslationServiceProgram;
        private CheckBox checkBoxAudioTranslationUseGPU;
        private CheckBox checkBoxIPEDConfigEnableImageClassification;
        private Button buttonImageClassificationStartProcess;
        private ComboBox comboBoxImageClassificationLanguage;
        private Label label16;
        private Label label18;
        private TextBox textBoxImageClassificationMobileNetDirectory;
        private Label label19;
        private TextBox textBoxImageClassificationProcessingDirectory;
        private TextBox textBoxImageClassificationServiceProgram;
        private OpenFileDialog openFileDialogImageClassificationServiceProgram;
        private CheckBox checkBoxFileSystemConfigAddUnallocated;
        private CheckBox checkBoxSettingsEnableCarving;
        private CheckBox checkBoxSettingsEnableFaceRecognition;
    }
}