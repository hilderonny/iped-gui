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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSelectSearchTermFile = new Button();
            textBoxSearchTermFilePath = new TextBox();
            label1 = new Label();
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
            tabControl1 = new TabControl();
            tabPageOverview = new TabPage();
            tabPageSettings = new TabPage();
            buttonExportProfile = new Button();
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
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tabPageSettings.Controls.Add(buttonExportProfile);
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
            // buttonExportProfile
            // 
            buttonExportProfile.Location = new Point(250, 157);
            buttonExportProfile.Name = "buttonExportProfile";
            buttonExportProfile.Size = new Size(213, 23);
            buttonExportProfile.TabIndex = 13;
            buttonExportProfile.Text = "Profil exportieren ...";
            buttonExportProfile.UseVisualStyleBackColor = true;
            buttonExportProfile.Click += buttonExportProfile_Click;
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
            panelAudioTranslationConfig.Size = new Size(980, 537);
            panelAudioTranslationConfig.TabIndex = 16;
            // 
            // tabPageImageClassification
            // 
            tabPageImageClassification.Controls.Add(panelImageClassificationConfig);
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
            panelImageClassificationConfig.Size = new Size(984, 534);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private OpenFileDialog openFileDialogAudioTranslationServiceProgram;
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
        private Button buttonExportProfile;
    }
}