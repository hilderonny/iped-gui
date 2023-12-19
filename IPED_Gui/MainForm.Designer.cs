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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            checkBox_ProjektErweitern = new CheckBox();
            checkBox_Fortsetzen = new CheckBox();
            checkBox_Portabel = new CheckBox();
            checkBox_InternetdatenLaden = new CheckBox();
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
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // buttonAudioTranslationInputDirectory
            // 
            resources.ApplyResources(buttonAudioTranslationInputDirectory, "buttonAudioTranslationInputDirectory");
            buttonAudioTranslationInputDirectory.Name = "buttonAudioTranslationInputDirectory";
            buttonAudioTranslationInputDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationInputDirectory.Click += buttonAudioTranslationInputDirectory_Click;
            // 
            // buttonAudioTranslationOutputDirectory
            // 
            resources.ApplyResources(buttonAudioTranslationOutputDirectory, "buttonAudioTranslationOutputDirectory");
            buttonAudioTranslationOutputDirectory.Name = "buttonAudioTranslationOutputDirectory";
            buttonAudioTranslationOutputDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationOutputDirectory.Click += buttonAudioTranslationOutputDirectory_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // buttonImageClassificationOutputDirectory
            // 
            resources.ApplyResources(buttonImageClassificationOutputDirectory, "buttonImageClassificationOutputDirectory");
            buttonImageClassificationOutputDirectory.Name = "buttonImageClassificationOutputDirectory";
            buttonImageClassificationOutputDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationOutputDirectory.Click += buttonImageClassificationOutputDirectory_Click_1;
            // 
            // buttonImageClassificationInputDirectory
            // 
            resources.ApplyResources(buttonImageClassificationInputDirectory, "buttonImageClassificationInputDirectory");
            buttonImageClassificationInputDirectory.Name = "buttonImageClassificationInputDirectory";
            buttonImageClassificationInputDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationInputDirectory.Click += buttonImageClassificationInputDirectory_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // buttonSettingsIpedExePath
            // 
            resources.ApplyResources(buttonSettingsIpedExePath, "buttonSettingsIpedExePath");
            buttonSettingsIpedExePath.Name = "buttonSettingsIpedExePath";
            buttonSettingsIpedExePath.UseVisualStyleBackColor = true;
            buttonSettingsIpedExePath.Click += buttonSettingsIpedExePath_Click;
            // 
            // buttonSettingsIndexTemp
            // 
            resources.ApplyResources(buttonSettingsIndexTemp, "buttonSettingsIndexTemp");
            buttonSettingsIndexTemp.Name = "buttonSettingsIndexTemp";
            buttonSettingsIndexTemp.UseVisualStyleBackColor = true;
            buttonSettingsIndexTemp.Click += buttonSettingsIndexTemp_Click;
            // 
            // buttonSettingsHashesDB
            // 
            resources.ApplyResources(buttonSettingsHashesDB, "buttonSettingsHashesDB");
            buttonSettingsHashesDB.Name = "buttonSettingsHashesDB";
            buttonSettingsHashesDB.UseVisualStyleBackColor = true;
            buttonSettingsHashesDB.Click += buttonSettingsHashesDB_Click;
            // 
            // buttonSettingsPluginFolder
            // 
            resources.ApplyResources(buttonSettingsPluginFolder, "buttonSettingsPluginFolder");
            buttonSettingsPluginFolder.Name = "buttonSettingsPluginFolder";
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
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // checkBoxAudioTranslationUseGPU
            // 
            resources.ApplyResources(checkBoxAudioTranslationUseGPU, "checkBoxAudioTranslationUseGPU");
            checkBoxAudioTranslationUseGPU.Name = "checkBoxAudioTranslationUseGPU";
            toolTip1.SetToolTip(checkBoxAudioTranslationUseGPU, resources.GetString("checkBoxAudioTranslationUseGPU.ToolTip"));
            checkBoxAudioTranslationUseGPU.UseVisualStyleBackColor = true;
            checkBoxAudioTranslationUseGPU.CheckedChanged += checkBoxAudioTranslationUseGPU_CheckedChanged;
            // 
            // buttonAudioTranslationStartProcess
            // 
            resources.ApplyResources(buttonAudioTranslationStartProcess, "buttonAudioTranslationStartProcess");
            buttonAudioTranslationStartProcess.Name = "buttonAudioTranslationStartProcess";
            buttonAudioTranslationStartProcess.UseVisualStyleBackColor = true;
            buttonAudioTranslationStartProcess.Click += buttonAudioTranslationStartProcess_Click;
            // 
            // comboBoxAudioTranslationModelSize
            // 
            comboBoxAudioTranslationModelSize.FormattingEnabled = true;
            comboBoxAudioTranslationModelSize.Items.AddRange(new object[] { resources.GetString("comboBoxAudioTranslationModelSize.Items"), resources.GetString("comboBoxAudioTranslationModelSize.Items1"), resources.GetString("comboBoxAudioTranslationModelSize.Items2"), resources.GetString("comboBoxAudioTranslationModelSize.Items3"), resources.GetString("comboBoxAudioTranslationModelSize.Items4") });
            resources.ApplyResources(comboBoxAudioTranslationModelSize, "comboBoxAudioTranslationModelSize");
            comboBoxAudioTranslationModelSize.Name = "comboBoxAudioTranslationModelSize";
            comboBoxAudioTranslationModelSize.SelectedIndexChanged += comboBoxAudioTranslationModelSize_SelectedIndexChanged;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            toolTip1.SetToolTip(label15, resources.GetString("label15.ToolTip"));
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            toolTip1.SetToolTip(label14, resources.GetString("label14.ToolTip"));
            // 
            // textBoxAudioTranslationArgosTranslateDirectory
            // 
            resources.ApplyResources(textBoxAudioTranslationArgosTranslateDirectory, "textBoxAudioTranslationArgosTranslateDirectory");
            textBoxAudioTranslationArgosTranslateDirectory.Name = "textBoxAudioTranslationArgosTranslateDirectory";
            textBoxAudioTranslationArgosTranslateDirectory.ReadOnly = true;
            // 
            // buttonAudioTranslationArgosTranslateDirectory
            // 
            resources.ApplyResources(buttonAudioTranslationArgosTranslateDirectory, "buttonAudioTranslationArgosTranslateDirectory");
            buttonAudioTranslationArgosTranslateDirectory.Name = "buttonAudioTranslationArgosTranslateDirectory";
            buttonAudioTranslationArgosTranslateDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationArgosTranslateDirectory.Click += buttonAudioTranslationArgosTranslateDirectory_Click;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            toolTip1.SetToolTip(label13, resources.GetString("label13.ToolTip"));
            // 
            // textBoxAudioTranslationFasterWhisperDirectory
            // 
            resources.ApplyResources(textBoxAudioTranslationFasterWhisperDirectory, "textBoxAudioTranslationFasterWhisperDirectory");
            textBoxAudioTranslationFasterWhisperDirectory.Name = "textBoxAudioTranslationFasterWhisperDirectory";
            textBoxAudioTranslationFasterWhisperDirectory.ReadOnly = true;
            // 
            // buttonAudioTranslationFasterWhisperDirectory
            // 
            resources.ApplyResources(buttonAudioTranslationFasterWhisperDirectory, "buttonAudioTranslationFasterWhisperDirectory");
            buttonAudioTranslationFasterWhisperDirectory.Name = "buttonAudioTranslationFasterWhisperDirectory";
            buttonAudioTranslationFasterWhisperDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationFasterWhisperDirectory.Click += buttonAudioTranslationFasterWhisperDirectory_Click;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            toolTip1.SetToolTip(label12, resources.GetString("label12.ToolTip"));
            // 
            // textBoxAudioTranslationProcessingDirectory
            // 
            resources.ApplyResources(textBoxAudioTranslationProcessingDirectory, "textBoxAudioTranslationProcessingDirectory");
            textBoxAudioTranslationProcessingDirectory.Name = "textBoxAudioTranslationProcessingDirectory";
            textBoxAudioTranslationProcessingDirectory.ReadOnly = true;
            // 
            // buttonAudioTranslationProcessingDirectory
            // 
            resources.ApplyResources(buttonAudioTranslationProcessingDirectory, "buttonAudioTranslationProcessingDirectory");
            buttonAudioTranslationProcessingDirectory.Name = "buttonAudioTranslationProcessingDirectory";
            buttonAudioTranslationProcessingDirectory.UseVisualStyleBackColor = true;
            buttonAudioTranslationProcessingDirectory.Click += buttonAudioTranslationProcessingDirectory_Click;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            toolTip1.SetToolTip(label11, resources.GetString("label11.ToolTip"));
            // 
            // textBoxAudioTranslationServiceProgram
            // 
            resources.ApplyResources(textBoxAudioTranslationServiceProgram, "textBoxAudioTranslationServiceProgram");
            textBoxAudioTranslationServiceProgram.Name = "textBoxAudioTranslationServiceProgram";
            textBoxAudioTranslationServiceProgram.ReadOnly = true;
            // 
            // buttonAudioTranslationServiceProgram
            // 
            resources.ApplyResources(buttonAudioTranslationServiceProgram, "buttonAudioTranslationServiceProgram");
            buttonAudioTranslationServiceProgram.Name = "buttonAudioTranslationServiceProgram";
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
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // buttonImageClassificationStartProcess
            // 
            resources.ApplyResources(buttonImageClassificationStartProcess, "buttonImageClassificationStartProcess");
            buttonImageClassificationStartProcess.Name = "buttonImageClassificationStartProcess";
            buttonImageClassificationStartProcess.UseVisualStyleBackColor = true;
            buttonImageClassificationStartProcess.Click += buttonImageClassificationStartProcess_Click;
            // 
            // comboBoxImageClassificationLanguage
            // 
            comboBoxImageClassificationLanguage.FormattingEnabled = true;
            comboBoxImageClassificationLanguage.Items.AddRange(new object[] { resources.GetString("comboBoxImageClassificationLanguage.Items"), resources.GetString("comboBoxImageClassificationLanguage.Items1") });
            resources.ApplyResources(comboBoxImageClassificationLanguage, "comboBoxImageClassificationLanguage");
            comboBoxImageClassificationLanguage.Name = "comboBoxImageClassificationLanguage";
            comboBoxImageClassificationLanguage.SelectedIndexChanged += comboBoxImageClassificationLanguage_SelectedIndexChanged;
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            toolTip1.SetToolTip(label16, resources.GetString("label16.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
            toolTip1.SetToolTip(label18, resources.GetString("label18.ToolTip"));
            // 
            // textBoxImageClassificationMobileNetDirectory
            // 
            resources.ApplyResources(textBoxImageClassificationMobileNetDirectory, "textBoxImageClassificationMobileNetDirectory");
            textBoxImageClassificationMobileNetDirectory.Name = "textBoxImageClassificationMobileNetDirectory";
            textBoxImageClassificationMobileNetDirectory.ReadOnly = true;
            // 
            // buttonImageClassificationMobileNetDirectory
            // 
            resources.ApplyResources(buttonImageClassificationMobileNetDirectory, "buttonImageClassificationMobileNetDirectory");
            buttonImageClassificationMobileNetDirectory.Name = "buttonImageClassificationMobileNetDirectory";
            buttonImageClassificationMobileNetDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationMobileNetDirectory.Click += buttonImageClassificationMobileNetDirectory_Click;
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.Name = "label19";
            toolTip1.SetToolTip(label19, resources.GetString("label19.ToolTip"));
            // 
            // textBoxImageClassificationProcessingDirectory
            // 
            resources.ApplyResources(textBoxImageClassificationProcessingDirectory, "textBoxImageClassificationProcessingDirectory");
            textBoxImageClassificationProcessingDirectory.Name = "textBoxImageClassificationProcessingDirectory";
            textBoxImageClassificationProcessingDirectory.ReadOnly = true;
            // 
            // buttonImageClassificationProcessingDirectory
            // 
            resources.ApplyResources(buttonImageClassificationProcessingDirectory, "buttonImageClassificationProcessingDirectory");
            buttonImageClassificationProcessingDirectory.Name = "buttonImageClassificationProcessingDirectory";
            buttonImageClassificationProcessingDirectory.UseVisualStyleBackColor = true;
            buttonImageClassificationProcessingDirectory.Click += buttonImageClassificationProcessingDirectory_Click;
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.Name = "label20";
            toolTip1.SetToolTip(label20, resources.GetString("label20.ToolTip"));
            // 
            // textBoxImageClassificationServiceProgram
            // 
            resources.ApplyResources(textBoxImageClassificationServiceProgram, "textBoxImageClassificationServiceProgram");
            textBoxImageClassificationServiceProgram.Name = "textBoxImageClassificationServiceProgram";
            textBoxImageClassificationServiceProgram.ReadOnly = true;
            // 
            // buttonImageClassificationServiceProgram
            // 
            resources.ApplyResources(buttonImageClassificationServiceProgram, "buttonImageClassificationServiceProgram");
            buttonImageClassificationServiceProgram.Name = "buttonImageClassificationServiceProgram";
            buttonImageClassificationServiceProgram.UseVisualStyleBackColor = true;
            buttonImageClassificationServiceProgram.Click += buttonImageClassificationServiceProgram_Click;
            // 
            // checkBox_ProjektErweitern
            // 
            resources.ApplyResources(checkBox_ProjektErweitern, "checkBox_ProjektErweitern");
            checkBox_ProjektErweitern.Name = "checkBox_ProjektErweitern";
            toolTip1.SetToolTip(checkBox_ProjektErweitern, resources.GetString("checkBox_ProjektErweitern.ToolTip"));
            checkBox_ProjektErweitern.UseVisualStyleBackColor = true;
            checkBox_ProjektErweitern.CheckedChanged += checkBox_ProjektErweitern_CheckedChanged;
            // 
            // checkBox_Fortsetzen
            // 
            resources.ApplyResources(checkBox_Fortsetzen, "checkBox_Fortsetzen");
            checkBox_Fortsetzen.Name = "checkBox_Fortsetzen";
            toolTip1.SetToolTip(checkBox_Fortsetzen, resources.GetString("checkBox_Fortsetzen.ToolTip"));
            checkBox_Fortsetzen.UseVisualStyleBackColor = true;
            checkBox_Fortsetzen.CheckedChanged += checkBox_Fortsetzen_CheckedChanged;
            // 
            // checkBox_Portabel
            // 
            resources.ApplyResources(checkBox_Portabel, "checkBox_Portabel");
            checkBox_Portabel.Name = "checkBox_Portabel";
            toolTip1.SetToolTip(checkBox_Portabel, resources.GetString("checkBox_Portabel.ToolTip"));
            checkBox_Portabel.UseVisualStyleBackColor = true;
            checkBox_Portabel.CheckedChanged += checkBox_Portabel_CheckedChanged;
            // 
            // checkBox_InternetdatenLaden
            // 
            resources.ApplyResources(checkBox_InternetdatenLaden, "checkBox_InternetdatenLaden");
            checkBox_InternetdatenLaden.Name = "checkBox_InternetdatenLaden";
            toolTip1.SetToolTip(checkBox_InternetdatenLaden, resources.GetString("checkBox_InternetdatenLaden.ToolTip"));
            checkBox_InternetdatenLaden.UseVisualStyleBackColor = true;
            checkBox_InternetdatenLaden.CheckedChanged += checkBox_InternetdatenLaden_CheckedChanged;
            // 
            // label_Spuren
            // 
            resources.ApplyResources(label_Spuren, "label_Spuren");
            label_Spuren.Name = "label_Spuren";
            // 
            // listBox_Spuren
            // 
            tableLayoutPanel1.SetColumnSpan(listBox_Spuren, 2);
            resources.ApplyResources(listBox_Spuren, "listBox_Spuren");
            listBox_Spuren.Name = "listBox_Spuren";
            tableLayoutPanel1.SetRowSpan(listBox_Spuren, 3);
            // 
            // button_VerzeichnisHinzufuegen
            // 
            resources.ApplyResources(button_VerzeichnisHinzufuegen, "button_VerzeichnisHinzufuegen");
            button_VerzeichnisHinzufuegen.Name = "button_VerzeichnisHinzufuegen";
            toolTip1.SetToolTip(button_VerzeichnisHinzufuegen, resources.GetString("button_VerzeichnisHinzufuegen.ToolTip"));
            button_VerzeichnisHinzufuegen.UseVisualStyleBackColor = true;
            button_VerzeichnisHinzufuegen.Click += button_VerzeichnisHinzufuegen_Click;
            // 
            // button_Entfernen
            // 
            resources.ApplyResources(button_Entfernen, "button_Entfernen");
            button_Entfernen.Name = "button_Entfernen";
            toolTip1.SetToolTip(button_Entfernen, resources.GetString("button_Entfernen.ToolTip"));
            button_Entfernen.UseVisualStyleBackColor = true;
            button_Entfernen.Click += button_Entfernen_Click;
            // 
            // label_Ausgabeverzeichnis
            // 
            resources.ApplyResources(label_Ausgabeverzeichnis, "label_Ausgabeverzeichnis");
            label_Ausgabeverzeichnis.Name = "label_Ausgabeverzeichnis";
            // 
            // textBox_Ausgabeverzeichnis
            // 
            tableLayoutPanel1.SetColumnSpan(textBox_Ausgabeverzeichnis, 2);
            resources.ApplyResources(textBox_Ausgabeverzeichnis, "textBox_Ausgabeverzeichnis");
            textBox_Ausgabeverzeichnis.Name = "textBox_Ausgabeverzeichnis";
            // 
            // button_Auswaehlen
            // 
            resources.ApplyResources(button_Auswaehlen, "button_Auswaehlen");
            button_Auswaehlen.Name = "button_Auswaehlen";
            toolTip1.SetToolTip(button_Auswaehlen, resources.GetString("button_Auswaehlen.ToolTip"));
            button_Auswaehlen.UseVisualStyleBackColor = true;
            button_Auswaehlen.Click += button_GeneralOutputDirectory_Click;
            // 
            // textBoxConsole
            // 
            textBoxConsole.AcceptsReturn = true;
            resources.ApplyResources(textBoxConsole, "textBoxConsole");
            textBoxConsole.Name = "textBoxConsole";
            toolTip1.SetToolTip(textBoxConsole, resources.GetString("textBoxConsole.ToolTip"));
            // 
            // button_Starten
            // 
            resources.ApplyResources(button_Starten, "button_Starten");
            button_Starten.Name = "button_Starten";
            toolTip1.SetToolTip(button_Starten, resources.GetString("button_Starten.ToolTip"));
            button_Starten.UseVisualStyleBackColor = true;
            button_Starten.Click += button_Starten_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label_Warnung
            // 
            resources.ApplyResources(label_Warnung, "label_Warnung");
            tableLayoutPanel1.SetColumnSpan(label_Warnung, 2);
            label_Warnung.ForeColor = Color.Red;
            label_Warnung.Name = "label_Warnung";
            // 
            // button_DateienHinzufuegen
            // 
            resources.ApplyResources(button_DateienHinzufuegen, "button_DateienHinzufuegen");
            button_DateienHinzufuegen.Name = "button_DateienHinzufuegen";
            toolTip1.SetToolTip(button_DateienHinzufuegen, resources.GetString("button_DateienHinzufuegen.ToolTip"));
            button_DateienHinzufuegen.UseVisualStyleBackColor = true;
            button_DateienHinzufuegen.Click += button_DateienHinzufuegen_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // checkBoxAudioTranslationProcessVideos
            // 
            resources.ApplyResources(checkBoxAudioTranslationProcessVideos, "checkBoxAudioTranslationProcessVideos");
            checkBoxAudioTranslationProcessVideos.Name = "checkBoxAudioTranslationProcessVideos";
            toolTip1.SetToolTip(checkBoxAudioTranslationProcessVideos, resources.GetString("checkBoxAudioTranslationProcessVideos.ToolTip"));
            checkBoxAudioTranslationProcessVideos.UseVisualStyleBackColor = true;
            checkBoxAudioTranslationProcessVideos.CheckedChanged += checkBoxAudioTranslationProcessVideos_CheckedChanged;
            // 
            // checkBoxIPEDConfigEnableAudioTranslation
            // 
            resources.ApplyResources(checkBoxIPEDConfigEnableAudioTranslation, "checkBoxIPEDConfigEnableAudioTranslation");
            checkBoxIPEDConfigEnableAudioTranslation.Name = "checkBoxIPEDConfigEnableAudioTranslation";
            toolTip1.SetToolTip(checkBoxIPEDConfigEnableAudioTranslation, resources.GetString("checkBoxIPEDConfigEnableAudioTranslation.ToolTip"));
            checkBoxIPEDConfigEnableAudioTranslation.UseVisualStyleBackColor = true;
            checkBoxIPEDConfigEnableAudioTranslation.CheckedChanged += checkBoxIPEDConfigEnabelAudioTranslation_CheckedChanged;
            // 
            // checkBoxIPEDConfigEnableImageClassification
            // 
            resources.ApplyResources(checkBoxIPEDConfigEnableImageClassification, "checkBoxIPEDConfigEnableImageClassification");
            checkBoxIPEDConfigEnableImageClassification.Name = "checkBoxIPEDConfigEnableImageClassification";
            toolTip1.SetToolTip(checkBoxIPEDConfigEnableImageClassification, resources.GetString("checkBoxIPEDConfigEnableImageClassification.ToolTip"));
            checkBoxIPEDConfigEnableImageClassification.UseVisualStyleBackColor = true;
            checkBoxIPEDConfigEnableImageClassification.CheckedChanged += checkBoxIPEDConfigEnableImageClassification_CheckedChanged;
            // 
            // checkBoxSettingsEnableCarving
            // 
            resources.ApplyResources(checkBoxSettingsEnableCarving, "checkBoxSettingsEnableCarving");
            checkBoxSettingsEnableCarving.Name = "checkBoxSettingsEnableCarving";
            toolTip1.SetToolTip(checkBoxSettingsEnableCarving, resources.GetString("checkBoxSettingsEnableCarving.ToolTip"));
            checkBoxSettingsEnableCarving.UseVisualStyleBackColor = true;
            checkBoxSettingsEnableCarving.CheckedChanged += checkBoxSettingsEnableCarving_CheckedChanged;
            // 
            // checkBoxFileSystemConfigAddUnallocated
            // 
            resources.ApplyResources(checkBoxFileSystemConfigAddUnallocated, "checkBoxFileSystemConfigAddUnallocated");
            checkBoxFileSystemConfigAddUnallocated.Name = "checkBoxFileSystemConfigAddUnallocated";
            toolTip1.SetToolTip(checkBoxFileSystemConfigAddUnallocated, resources.GetString("checkBoxFileSystemConfigAddUnallocated.ToolTip"));
            checkBoxFileSystemConfigAddUnallocated.UseVisualStyleBackColor = true;
            checkBoxFileSystemConfigAddUnallocated.CheckedChanged += checkBoxFileSystemConfigAddUnallocated_CheckedChanged;
            // 
            // checkBoxSettingsEnableFaceRecognition
            // 
            resources.ApplyResources(checkBoxSettingsEnableFaceRecognition, "checkBoxSettingsEnableFaceRecognition");
            checkBoxSettingsEnableFaceRecognition.Name = "checkBoxSettingsEnableFaceRecognition";
            toolTip1.SetToolTip(checkBoxSettingsEnableFaceRecognition, resources.GetString("checkBoxSettingsEnableFaceRecognition.ToolTip"));
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
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPageOverview
            // 
            tabPageOverview.Controls.Add(tableLayoutPanel1);
            resources.ApplyResources(tabPageOverview, "tabPageOverview");
            tabPageOverview.Name = "tabPageOverview";
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
            resources.ApplyResources(tabPageSettings, "tabPageSettings");
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // textBoxSettingsPluginFolder
            // 
            resources.ApplyResources(textBoxSettingsPluginFolder, "textBoxSettingsPluginFolder");
            textBoxSettingsPluginFolder.Name = "textBoxSettingsPluginFolder";
            textBoxSettingsPluginFolder.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // textBoxSettingsHashesDB
            // 
            resources.ApplyResources(textBoxSettingsHashesDB, "textBoxSettingsHashesDB");
            textBoxSettingsHashesDB.Name = "textBoxSettingsHashesDB";
            textBoxSettingsHashesDB.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // textBoxSettingsNumThreads
            // 
            resources.ApplyResources(textBoxSettingsNumThreads, "textBoxSettingsNumThreads");
            textBoxSettingsNumThreads.Name = "textBoxSettingsNumThreads";
            textBoxSettingsNumThreads.TextChanged += textBoxSettingsNumThreads_TextChanged;
            // 
            // checkBoxSettingsOutputOnSSD
            // 
            resources.ApplyResources(checkBoxSettingsOutputOnSSD, "checkBoxSettingsOutputOnSSD");
            checkBoxSettingsOutputOnSSD.Name = "checkBoxSettingsOutputOnSSD";
            checkBoxSettingsOutputOnSSD.UseVisualStyleBackColor = true;
            checkBoxSettingsOutputOnSSD.CheckedChanged += checkBoxSettingsOutputOnSSD_CheckedChanged;
            // 
            // checkBoxSettingsIndexTempOnSSD
            // 
            resources.ApplyResources(checkBoxSettingsIndexTempOnSSD, "checkBoxSettingsIndexTempOnSSD");
            checkBoxSettingsIndexTempOnSSD.Name = "checkBoxSettingsIndexTempOnSSD";
            checkBoxSettingsIndexTempOnSSD.UseVisualStyleBackColor = true;
            checkBoxSettingsIndexTempOnSSD.CheckedChanged += checkBoxSettingsIndexTempOnSSD_CheckedChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // textBoxSettingsIndexTemp
            // 
            resources.ApplyResources(textBoxSettingsIndexTemp, "textBoxSettingsIndexTemp");
            textBoxSettingsIndexTemp.Name = "textBoxSettingsIndexTemp";
            textBoxSettingsIndexTemp.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // comboBoxSettingsLocale
            // 
            comboBoxSettingsLocale.FormattingEnabled = true;
            comboBoxSettingsLocale.Items.AddRange(new object[] { resources.GetString("comboBoxSettingsLocale.Items"), resources.GetString("comboBoxSettingsLocale.Items1"), resources.GetString("comboBoxSettingsLocale.Items2"), resources.GetString("comboBoxSettingsLocale.Items3"), resources.GetString("comboBoxSettingsLocale.Items4") });
            resources.ApplyResources(comboBoxSettingsLocale, "comboBoxSettingsLocale");
            comboBoxSettingsLocale.Name = "comboBoxSettingsLocale";
            comboBoxSettingsLocale.SelectedIndexChanged += comboBoxSettingsLocale_SelectedIndexChanged;
            // 
            // textBoxSettingsIpedExePath
            // 
            resources.ApplyResources(textBoxSettingsIpedExePath, "textBoxSettingsIpedExePath");
            textBoxSettingsIpedExePath.Name = "textBoxSettingsIpedExePath";
            textBoxSettingsIpedExePath.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
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
            resources.ApplyResources(tabPageAudioTranslation, "tabPageAudioTranslation");
            tabPageAudioTranslation.Name = "tabPageAudioTranslation";
            tabPageAudioTranslation.UseVisualStyleBackColor = true;
            // 
            // textBoxAudioTranslationOutputDirectory
            // 
            resources.ApplyResources(textBoxAudioTranslationOutputDirectory, "textBoxAudioTranslationOutputDirectory");
            textBoxAudioTranslationOutputDirectory.Name = "textBoxAudioTranslationOutputDirectory";
            textBoxAudioTranslationOutputDirectory.ReadOnly = true;
            // 
            // textBoxAudioTranslationInputDirectory
            // 
            resources.ApplyResources(textBoxAudioTranslationInputDirectory, "textBoxAudioTranslationInputDirectory");
            textBoxAudioTranslationInputDirectory.Name = "textBoxAudioTranslationInputDirectory";
            textBoxAudioTranslationInputDirectory.ReadOnly = true;
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
            resources.ApplyResources(tabPageImageClassification, "tabPageImageClassification");
            tabPageImageClassification.Name = "tabPageImageClassification";
            tabPageImageClassification.UseVisualStyleBackColor = true;
            // 
            // textBoxImageClassificationOutputDirectory
            // 
            resources.ApplyResources(textBoxImageClassificationOutputDirectory, "textBoxImageClassificationOutputDirectory");
            textBoxImageClassificationOutputDirectory.Name = "textBoxImageClassificationOutputDirectory";
            textBoxImageClassificationOutputDirectory.ReadOnly = true;
            // 
            // textBoxImageClassificationInputDirectory
            // 
            resources.ApplyResources(textBoxImageClassificationInputDirectory, "textBoxImageClassificationInputDirectory");
            textBoxImageClassificationInputDirectory.Name = "textBoxImageClassificationInputDirectory";
            textBoxImageClassificationInputDirectory.ReadOnly = true;
            // 
            // tabPageProtocol
            // 
            tabPageProtocol.Controls.Add(textBoxConsole);
            resources.ApplyResources(tabPageProtocol, "tabPageProtocol");
            tabPageProtocol.Name = "tabPageProtocol";
            tabPageProtocol.UseVisualStyleBackColor = true;
            // 
            // openFileDialogSettingsIpedExePath
            // 
            resources.ApplyResources(openFileDialogSettingsIpedExePath, "openFileDialogSettingsIpedExePath");
            // 
            // openFileDialogSettingsHashesDB
            // 
            resources.ApplyResources(openFileDialogSettingsHashesDB, "openFileDialogSettingsHashesDB");
            // 
            // openFileDialogAudioTranslationServiceProgram
            // 
            resources.ApplyResources(openFileDialogAudioTranslationServiceProgram, "openFileDialogAudioTranslationServiceProgram");
            // 
            // openFileDialogImageClassificationServiceProgram
            // 
            resources.ApplyResources(openFileDialogImageClassificationServiceProgram, "openFileDialogImageClassificationServiceProgram");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "MainForm";
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