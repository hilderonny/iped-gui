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
            GroupBox groupBox2;
            Button buttonSettingsIpedExePath;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSelectSearchTermFile = new Button();
            textBoxSearchTermFilePath = new TextBox();
            label1 = new Label();
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
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPageOverview = new TabPage();
            tabPageSettings = new TabPage();
            buttonSettingsSaveSettings = new Button();
            buttonSettingsLoadSettings = new Button();
            textBoxSettingsIpedExePath = new TextBox();
            label5 = new Label();
            tabPageLocalConfig = new TabPage();
            tabPageIPEDConfig = new TabPage();
            tabPageCategories = new TabPage();
            categoriesUserControl = new UserControls.CategoriesUserControl();
            tabPageFileSystem = new TabPage();
            tabPageAudioTranslation = new TabPage();
            panelAudioTranslationConfig = new Panel();
            tabPageImageClassification = new TabPage();
            panelImageClassificationConfig = new Panel();
            tabPageProtocol = new TabPage();
            openFileDialogSettingsIpedExePath = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialogSettingsHashesDB = new OpenFileDialog();
            openFileDialogAudioTranslationServiceProgram = new OpenFileDialog();
            openFileDialogImageClassificationServiceProgram = new OpenFileDialog();
            groupBox2 = new GroupBox();
            buttonSettingsIpedExePath = new Button();
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
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageOverview.SuspendLayout();
            tabPageSettings.SuspendLayout();
            tabPageCategories.SuspendLayout();
            tabPageAudioTranslation.SuspendLayout();
            tabPageImageClassification.SuspendLayout();
            tabPageProtocol.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(tableLayoutPanel2);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.91786F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.08214F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel2.Controls.Add(buttonSelectSearchTermFile, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxSearchTermFilePath, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(6, 172);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(646, 36);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // buttonSelectSearchTermFile
            // 
            buttonSelectSearchTermFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSelectSearchTermFile.Location = new Point(490, 3);
            buttonSelectSearchTermFile.Name = "buttonSelectSearchTermFile";
            buttonSelectSearchTermFile.Size = new Size(153, 23);
            buttonSelectSearchTermFile.TabIndex = 7;
            buttonSelectSearchTermFile.Text = "Auswählen ...";
            buttonSelectSearchTermFile.UseVisualStyleBackColor = true;
            buttonSelectSearchTermFile.Click += buttonSelectSearchTermFile_Click;
            // 
            // textBoxSearchTermFilePath
            // 
            textBoxSearchTermFilePath.Dock = DockStyle.Fill;
            textBoxSearchTermFilePath.Location = new Point(100, 3);
            textBoxSearchTermFilePath.Name = "textBoxSearchTermFilePath";
            textBoxSearchTermFilePath.Size = new Size(384, 23);
            textBoxSearchTermFilePath.TabIndex = 6;
            textBoxSearchTermFilePath.TextChanged += textBoxSearchTermFilePath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Schlagwortliste";
            // 
            // checkBox_ProjektErweitern
            // 
            checkBox_ProjektErweitern.AutoSize = true;
            checkBox_ProjektErweitern.Location = new Point(6, 22);
            checkBox_ProjektErweitern.Margin = new Padding(0);
            checkBox_ProjektErweitern.Name = "checkBox_ProjektErweitern";
            checkBox_ProjektErweitern.Size = new Size(184, 19);
            checkBox_ProjektErweitern.TabIndex = 8;
            checkBox_ProjektErweitern.Text = "Bestehendes Projekt erweitern";
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
            checkBox_InternetdatenLaden.UseVisualStyleBackColor = true;
            checkBox_InternetdatenLaden.CheckedChanged += checkBox_InternetdatenLaden_CheckedChanged;
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
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox3.Location = new Point(3, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(980, 226);
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
            checkBoxAudioTranslationUseGPU.UseVisualStyleBackColor = true;
            checkBoxAudioTranslationUseGPU.CheckedChanged += checkBoxAudioTranslationUseGPU_CheckedChanged;
            // 
            // buttonAudioTranslationStartProcess
            // 
            buttonAudioTranslationStartProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAudioTranslationStartProcess.Location = new Point(196, 192);
            buttonAudioTranslationStartProcess.Name = "buttonAudioTranslationStartProcess";
            buttonAudioTranslationStartProcess.Size = new Size(146, 23);
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
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 112);
            label14.Name = "label14";
            label14.Size = new Size(148, 15);
            label14.TabIndex = 25;
            label14.Text = "Argos Translate Verzeichnis";
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
            buttonAudioTranslationArgosTranslateDirectory.Location = new Point(823, 108);
            buttonAudioTranslationArgosTranslateDirectory.Name = "buttonAudioTranslationArgosTranslateDirectory";
            buttonAudioTranslationArgosTranslateDirectory.Size = new Size(112, 23);
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
            buttonAudioTranslationFasterWhisperDirectory.Location = new Point(823, 79);
            buttonAudioTranslationFasterWhisperDirectory.Name = "buttonAudioTranslationFasterWhisperDirectory";
            buttonAudioTranslationFasterWhisperDirectory.Size = new Size(112, 23);
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
            buttonAudioTranslationProcessingDirectory.Location = new Point(823, 50);
            buttonAudioTranslationProcessingDirectory.Name = "buttonAudioTranslationProcessingDirectory";
            buttonAudioTranslationProcessingDirectory.Size = new Size(112, 23);
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
            buttonAudioTranslationServiceProgram.Location = new Point(823, 21);
            buttonAudioTranslationServiceProgram.Name = "buttonAudioTranslationServiceProgram";
            buttonAudioTranslationServiceProgram.Size = new Size(112, 23);
            buttonAudioTranslationServiceProgram.TabIndex = 18;
            buttonAudioTranslationServiceProgram.Text = "Auswählen ...";
            buttonAudioTranslationServiceProgram.UseVisualStyleBackColor = true;
            buttonAudioTranslationServiceProgram.Click += buttonAudioTranslationServiceProgram_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox4.Location = new Point(3, 369);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(984, 168);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lokale Verarbeitung";
            // 
            // buttonImageClassificationStartProcess
            // 
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
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(39, 83);
            label18.Name = "label18";
            label18.Size = new Size(124, 15);
            label18.TabIndex = 22;
            label18.Text = "MobileNet Verzeichnis";
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
            button_VerzeichnisHinzufuegen.UseVisualStyleBackColor = true;
            button_VerzeichnisHinzufuegen.Click += button_VerzeichnisHinzufuegen_Click;
            // 
            // button_Entfernen
            // 
            button_Entfernen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_Entfernen.Enabled = false;
            button_Entfernen.FlatAppearance.BorderSize = 0;
            button_Entfernen.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button_Entfernen.FlatStyle = FlatStyle.Flat;
            button_Entfernen.Location = new Point(827, 63);
            button_Entfernen.Name = "button_Entfernen";
            button_Entfernen.Size = new Size(154, 23);
            button_Entfernen.TabIndex = 3;
            button_Entfernen.Text = "Entfernen";
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
            // 
            // button_Auswaehlen
            // 
            button_Auswaehlen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_Auswaehlen.Location = new Point(827, 163);
            button_Auswaehlen.Name = "button_Auswaehlen";
            button_Auswaehlen.Size = new Size(154, 23);
            button_Auswaehlen.TabIndex = 6;
            button_Auswaehlen.Text = "Auswählen ...";
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
            // 
            // button_Starten
            // 
            button_Starten.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Starten.Location = new Point(827, 508);
            button_Starten.Name = "button_Starten";
            button_Starten.Size = new Size(154, 23);
            button_Starten.TabIndex = 16;
            button_Starten.Text = "Starten";
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
            tableLayoutPanel1.Controls.Add(label2, 3, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 3, 4);
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
            button_DateienHinzufuegen.UseVisualStyleBackColor = true;
            button_DateienHinzufuegen.Click += button_DateienHinzufuegen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(827, 250);
            label2.Name = "label2";
            label2.Size = new Size(23, 16);
            label2.TabIndex = 21;
            label2.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(827, 193);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(154, 54);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 61);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOverview);
            tabControl1.Controls.Add(tabPageSettings);
            tabControl1.Controls.Add(tabPageLocalConfig);
            tabControl1.Controls.Add(tabPageIPEDConfig);
            tabControl1.Controls.Add(tabPageCategories);
            tabControl1.Controls.Add(tabPageFileSystem);
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
            tabPageSettings.Controls.Add(buttonSettingsSaveSettings);
            tabPageSettings.Controls.Add(buttonSettingsLoadSettings);
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
            // buttonSettingsSaveSettings
            // 
            buttonSettingsSaveSettings.Location = new Point(250, 101);
            buttonSettingsSaveSettings.Name = "buttonSettingsSaveSettings";
            buttonSettingsSaveSettings.Size = new Size(213, 23);
            buttonSettingsSaveSettings.TabIndex = 12;
            buttonSettingsSaveSettings.Text = "Einstellungen in Datei speichern ...";
            buttonSettingsSaveSettings.UseVisualStyleBackColor = true;
            buttonSettingsSaveSettings.Click += buttonSettingsSaveSettings_Click;
            // 
            // buttonSettingsLoadSettings
            // 
            buttonSettingsLoadSettings.Location = new Point(250, 72);
            buttonSettingsLoadSettings.Name = "buttonSettingsLoadSettings";
            buttonSettingsLoadSettings.Size = new Size(213, 23);
            buttonSettingsLoadSettings.TabIndex = 11;
            buttonSettingsLoadSettings.Text = "Einstellungen aus Datei laden ...";
            buttonSettingsLoadSettings.UseVisualStyleBackColor = true;
            buttonSettingsLoadSettings.Click += buttonSettingsLoadSettings_Click;
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
            // tabPageLocalConfig
            // 
            tabPageLocalConfig.Location = new Point(4, 24);
            tabPageLocalConfig.Name = "tabPageLocalConfig";
            tabPageLocalConfig.Size = new Size(990, 540);
            tabPageLocalConfig.TabIndex = 13;
            tabPageLocalConfig.Text = "Local config";
            tabPageLocalConfig.UseVisualStyleBackColor = true;
            // 
            // tabPageIPEDConfig
            // 
            tabPageIPEDConfig.Location = new Point(4, 24);
            tabPageIPEDConfig.Name = "tabPageIPEDConfig";
            tabPageIPEDConfig.Size = new Size(990, 540);
            tabPageIPEDConfig.TabIndex = 12;
            tabPageIPEDConfig.Text = "Funktionen";
            tabPageIPEDConfig.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(categoriesUserControl);
            tabPageCategories.Location = new Point(4, 24);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Size = new Size(990, 540);
            tabPageCategories.TabIndex = 14;
            tabPageCategories.Text = "Kategorien";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // categoriesUserControl
            // 
            categoriesUserControl.Dock = DockStyle.Fill;
            categoriesUserControl.Location = new Point(0, 0);
            categoriesUserControl.Name = "categoriesUserControl";
            categoriesUserControl.Size = new Size(990, 540);
            categoriesUserControl.TabIndex = 0;
            // 
            // tabPageFileSystem
            // 
            tabPageFileSystem.Location = new Point(4, 24);
            tabPageFileSystem.Name = "tabPageFileSystem";
            tabPageFileSystem.Size = new Size(990, 540);
            tabPageFileSystem.TabIndex = 11;
            tabPageFileSystem.Text = "File system";
            tabPageFileSystem.UseVisualStyleBackColor = true;
            // 
            // tabPageAudioTranslation
            // 
            tabPageAudioTranslation.Controls.Add(groupBox3);
            tabPageAudioTranslation.Controls.Add(panelAudioTranslationConfig);
            tabPageAudioTranslation.Location = new Point(4, 24);
            tabPageAudioTranslation.Name = "tabPageAudioTranslation";
            tabPageAudioTranslation.Size = new Size(990, 540);
            tabPageAudioTranslation.TabIndex = 8;
            tabPageAudioTranslation.Text = "Audioübersetzung";
            tabPageAudioTranslation.UseVisualStyleBackColor = true;
            // 
            // panelAudioTranslationConfig
            // 
            panelAudioTranslationConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAudioTranslationConfig.Location = new Point(3, 0);
            panelAudioTranslationConfig.Name = "panelAudioTranslationConfig";
            panelAudioTranslationConfig.Size = new Size(980, 305);
            panelAudioTranslationConfig.TabIndex = 16;
            // 
            // tabPageImageClassification
            // 
            tabPageImageClassification.Controls.Add(panelImageClassificationConfig);
            tabPageImageClassification.Controls.Add(groupBox4);
            tabPageImageClassification.Location = new Point(4, 24);
            tabPageImageClassification.Name = "tabPageImageClassification";
            tabPageImageClassification.Padding = new Padding(40);
            tabPageImageClassification.Size = new Size(990, 540);
            tabPageImageClassification.TabIndex = 9;
            tabPageImageClassification.Text = "Bildklassifizierung";
            tabPageImageClassification.UseVisualStyleBackColor = true;
            // 
            // panelImageClassificationConfig
            // 
            panelImageClassificationConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelImageClassificationConfig.Location = new Point(3, 3);
            panelImageClassificationConfig.Name = "panelImageClassificationConfig";
            panelImageClassificationConfig.Size = new Size(984, 360);
            panelImageClassificationConfig.TabIndex = 22;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageOverview.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            tabPageCategories.ResumeLayout(false);
            tabPageAudioTranslation.ResumeLayout(false);
            tabPageImageClassification.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPageOverview;
        private TabPage tabPageProtocol;
        private TabPage tabPageAudioTranslation;
        private TabPage tabPageImageClassification;
        private TabPage tabPageSettings;
        private TextBox textBoxSettingsIpedExePath;
        private Label label5;
        private OpenFileDialog openFileDialogSettingsIpedExePath;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialogSettingsHashesDB;
        private Label label13;
        private TextBox textBoxAudioTranslationFasterWhisperDirectory;
        private Label label12;
        private TextBox textBoxAudioTranslationProcessingDirectory;
        private TextBox textBoxAudioTranslationServiceProgram;
        private ComboBox comboBoxAudioTranslationModelSize;
        private Label label15;
        private Label label14;
        private TextBox textBoxAudioTranslationArgosTranslateDirectory;
        private Button buttonAudioTranslationStartProcess;
        private OpenFileDialog openFileDialogAudioTranslationServiceProgram;
        private CheckBox checkBoxAudioTranslationUseGPU;
        private Button buttonImageClassificationStartProcess;
        private ComboBox comboBoxImageClassificationLanguage;
        private Label label16;
        private Label label18;
        private TextBox textBoxImageClassificationMobileNetDirectory;
        private Label label19;
        private TextBox textBoxImageClassificationProcessingDirectory;
        private TextBox textBoxImageClassificationServiceProgram;
        private OpenFileDialog openFileDialogImageClassificationServiceProgram;
        private TabPage tabPageFileSystem;
        private TabPage tabPageIPEDConfig;
        private TabPage tabPageLocalConfig;
        private Panel panelAudioTranslationConfig;
        private Panel panelImageClassificationConfig;
        private TabPage tabPageCategories;
        private UserControls.CategoriesUserControl categoriesUserControl;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button buttonSelectSearchTermFile;
        private TextBox textBoxSearchTermFilePath;
        private Button buttonSettingsSaveSettings;
        private Button buttonSettingsLoadSettings;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}