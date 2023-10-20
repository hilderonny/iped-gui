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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
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
    }
}