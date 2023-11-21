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
            TabPage tabPageHome;
            TabPage tabPageEnvironment;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkBox3 = new CheckBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox3 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            label3 = new Label();
            label_Spuren = new Label();
            listBox_Spuren = new ListBox();
            button_VerzeichnisHinzufuegen = new Button();
            button_Entfernen = new Button();
            label_Ausgabeverzeichnis = new Label();
            textBox_Ausgabeverzeichnis = new TextBox();
            button_Auswaehlen = new Button();
            checkBox_ProjektErweitern = new CheckBox();
            checkBox_Fortsetzen = new CheckBox();
            checkBox_Portabel = new CheckBox();
            checkBox_InternetdatenLaden = new CheckBox();
            checkBox_AudioTranslation = new CheckBox();
            checkBox_BildKlassifizierung = new CheckBox();
            checkBox_Ocr = new CheckBox();
            textBox_Konsole = new TextBox();
            button_Starten = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_Warnung = new Label();
            button_DateienHinzufuegen = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPageProcessing = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage9 = new TabPage();
            tabPageHome = new TabPage();
            tabPageEnvironment = new TabPage();
            tabPageHome.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPageEnvironment.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.WhiteSmoke;
            tabPageHome.Controls.Add(tableLayoutPanel3);
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(990, 540);
            tabPageHome.TabIndex = 2;
            tabPageHome.Text = "Home";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(label7, 0, 3);
            tableLayoutPanel3.Controls.Add(checkBox3, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel3.Controls.Add(label8, 2, 0);
            tableLayoutPanel3.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Location = new Point(204, 105);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(522, 122);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 58);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 87);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(182, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 4;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(182, 61);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 23);
            comboBox2.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel4.Controls.Add(button1, 1, 0);
            tableLayoutPanel4.Location = new Point(182, 90);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(187, 29);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(109, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(419, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 15);
            label4.TabIndex = 0;
            label4.Text = "label4 dsaj grne aög ntreös gtes";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageEnvironment
            // 
            tabPageEnvironment.Controls.Add(tableLayoutPanel2);
            tabPageEnvironment.Location = new Point(4, 24);
            tabPageEnvironment.Name = "tabPageEnvironment";
            tabPageEnvironment.Padding = new Padding(8);
            tabPageEnvironment.Size = new Size(990, 540);
            tabPageEnvironment.TabIndex = 3;
            tabPageEnvironment.Text = "Environment";
            tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.56784F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.59799F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5829144F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7504177F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7504177F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7504177F));
            tableLayoutPanel2.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(checkBox1, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel2.Controls.Add(checkBox2, 1, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 8);
            tableLayoutPanel2.Margin = new Padding(8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(974, 524);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "locale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "indexTemp";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(135, 59);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(135, 87);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 56);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "indexTempOnSSD";
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
            button_Auswaehlen.Click += button_Auswaehlen_Click;
            // 
            // checkBox_ProjektErweitern
            // 
            checkBox_ProjektErweitern.AutoSize = true;
            checkBox_ProjektErweitern.Location = new Point(163, 253);
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
            checkBox_Fortsetzen.Location = new Point(163, 283);
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
            checkBox_Portabel.Location = new Point(163, 313);
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
            checkBox_InternetdatenLaden.Location = new Point(163, 343);
            checkBox_InternetdatenLaden.Name = "checkBox_InternetdatenLaden";
            checkBox_InternetdatenLaden.Size = new Size(129, 19);
            checkBox_InternetdatenLaden.TabIndex = 11;
            checkBox_InternetdatenLaden.Text = "Internetdaten laden";
            toolTip1.SetToolTip(checkBox_InternetdatenLaden, "Falls in bestimmten Dateien Verweise auf Internetdaten existieren (z.B. Chats mit Bildlinks), werden diese heruntergeladen und offline bereitgestellt.");
            checkBox_InternetdatenLaden.UseVisualStyleBackColor = true;
            checkBox_InternetdatenLaden.CheckedChanged += checkBox_InternetdatenLaden_CheckedChanged;
            // 
            // checkBox_AudioTranslation
            // 
            checkBox_AudioTranslation.AutoSize = true;
            checkBox_AudioTranslation.Location = new Point(495, 253);
            checkBox_AudioTranslation.Name = "checkBox_AudioTranslation";
            checkBox_AudioTranslation.Size = new Size(222, 19);
            checkBox_AudioTranslation.TabIndex = 12;
            checkBox_AudioTranslation.Text = "Audio Transkription und Übersetzung";
            toolTip1.SetToolTip(checkBox_AudioTranslation, "Führt bei Audio- und Videodateien Transkriptionen und Übersetzung ins Deutsche mit Hilfe des Auswerteservers durch.");
            checkBox_AudioTranslation.UseVisualStyleBackColor = true;
            checkBox_AudioTranslation.CheckedChanged += checkBox_AudioTranslation_CheckedChanged;
            // 
            // checkBox_BildKlassifizierung
            // 
            checkBox_BildKlassifizierung.AutoSize = true;
            checkBox_BildKlassifizierung.Location = new Point(495, 283);
            checkBox_BildKlassifizierung.Name = "checkBox_BildKlassifizierung";
            checkBox_BildKlassifizierung.Size = new Size(125, 19);
            checkBox_BildKlassifizierung.TabIndex = 13;
            checkBox_BildKlassifizierung.Text = "Bilder klassifizieren";
            toolTip1.SetToolTip(checkBox_BildKlassifizierung, "Führt eine Klassifizierung von Bilddateien mit Hilfe des Auswerteservers durch.");
            checkBox_BildKlassifizierung.UseVisualStyleBackColor = true;
            checkBox_BildKlassifizierung.CheckedChanged += checkBox_BildKlassifizierung_CheckedChanged;
            // 
            // checkBox_Ocr
            // 
            checkBox_Ocr.AutoSize = true;
            checkBox_Ocr.Location = new Point(495, 313);
            checkBox_Ocr.Name = "checkBox_Ocr";
            checkBox_Ocr.Size = new Size(257, 19);
            checkBox_Ocr.TabIndex = 14;
            checkBox_Ocr.Text = "Texterkennung in Bildern und PDFs per OCR";
            toolTip1.SetToolTip(checkBox_Ocr, "Führt auf Bildern und PDF-Dateien eine Texterkennung per OCR durch");
            checkBox_Ocr.UseVisualStyleBackColor = true;
            checkBox_Ocr.CheckedChanged += checkBox_Ocr_CheckedChanged;
            // 
            // textBox_Konsole
            // 
            textBox_Konsole.AcceptsReturn = true;
            textBox_Konsole.Dock = DockStyle.Fill;
            textBox_Konsole.Location = new Point(3, 3);
            textBox_Konsole.Multiline = true;
            textBox_Konsole.Name = "textBox_Konsole";
            textBox_Konsole.Size = new Size(984, 534);
            textBox_Konsole.TabIndex = 15;
            toolTip1.SetToolTip(textBox_Konsole, "Ausgabe des IPED-Programmdurchlaufs");
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
            tableLayoutPanel1.Controls.Add(checkBox_Ocr, 2, 7);
            tableLayoutPanel1.Controls.Add(checkBox_BildKlassifizierung, 2, 6);
            tableLayoutPanel1.Controls.Add(checkBox_AudioTranslation, 2, 5);
            tableLayoutPanel1.Controls.Add(listBox_Spuren, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBox_InternetdatenLaden, 1, 8);
            tableLayoutPanel1.Controls.Add(button_VerzeichnisHinzufuegen, 3, 0);
            tableLayoutPanel1.Controls.Add(checkBox_Portabel, 1, 7);
            tableLayoutPanel1.Controls.Add(button_Entfernen, 3, 2);
            tableLayoutPanel1.Controls.Add(checkBox_Fortsetzen, 1, 6);
            tableLayoutPanel1.Controls.Add(label_Ausgabeverzeichnis, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBox_ProjektErweitern, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox_Ausgabeverzeichnis, 1, 3);
            tableLayoutPanel1.Controls.Add(button_Auswaehlen, 3, 3);
            tableLayoutPanel1.Controls.Add(button_Starten, 3, 9);
            tableLayoutPanel1.Controls.Add(label_Warnung, 1, 4);
            tableLayoutPanel1.Controls.Add(button_DateienHinzufuegen, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPageHome);
            tabControl1.Controls.Add(tabPageEnvironment);
            tabControl1.Controls.Add(tabPageProcessing);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 568);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(990, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Verarbeitung";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox_Konsole);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(990, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Protokoll";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageProcessing
            // 
            tabPageProcessing.Location = new Point(4, 24);
            tabPageProcessing.Name = "tabPageProcessing";
            tabPageProcessing.Padding = new Padding(3);
            tabPageProcessing.Size = new Size(990, 540);
            tabPageProcessing.TabIndex = 4;
            tabPageProcessing.Text = "Processing";
            tabPageProcessing.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(990, 540);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(990, 540);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(990, 540);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(990, 540);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "tabPage9";
            tabPage9.UseVisualStyleBackColor = true;
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
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tabPageEnvironment.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private CheckBox checkBox_AudioTranslation;
        private CheckBox checkBox_BildKlassifizierung;
        private CheckBox checkBox_Ocr;
        private TextBox textBox_Konsole;
        private Button button_Starten;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Warnung;
        private Button button_DateienHinzufuegen;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPageHome;
        private TabPage tabPageEnvironment;
        private TabPage tabPageProcessing;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private Label label3;
        private Controls.RoundBorderControl settingsCard1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBox3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox3;
        private Button button1;
        private Label label8;
        private TextBox textBox4;
    }
}