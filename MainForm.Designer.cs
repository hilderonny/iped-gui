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
            lblSpuren = new Label();
            lstSpuren = new ListBox();
            btnVerzeichnisHinzufuegen = new Button();
            btnEntfernen = new Button();
            lblAusgabeverzeichnis = new Label();
            tbAusgabeverzeichnis = new TextBox();
            btnAuswaehlen = new Button();
            cbProjektErweitern = new CheckBox();
            cbFortsetzen = new CheckBox();
            cbPortabel = new CheckBox();
            cbInternetdatenLaden = new CheckBox();
            cbAudioTranslation = new CheckBox();
            cbBildKlassifizierung = new CheckBox();
            cbOcr = new CheckBox();
            tbKonsole = new TextBox();
            btnStarten = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblWarnung = new Label();
            btnDateienHinzufuegen = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSpuren
            // 
            lblSpuren.AutoSize = true;
            lblSpuren.Location = new Point(3, 0);
            lblSpuren.Name = "lblSpuren";
            lblSpuren.Size = new Size(44, 15);
            lblSpuren.TabIndex = 0;
            lblSpuren.Text = "Spuren";
            // 
            // lstSpuren
            // 
            tableLayoutPanel1.SetColumnSpan(lstSpuren, 2);
            lstSpuren.Dock = DockStyle.Fill;
            lstSpuren.FormattingEnabled = true;
            lstSpuren.ItemHeight = 15;
            lstSpuren.Location = new Point(163, 3);
            lstSpuren.Name = "lstSpuren";
            tableLayoutPanel1.SetRowSpan(lstSpuren, 3);
            lstSpuren.SelectionMode = SelectionMode.MultiExtended;
            lstSpuren.Size = new Size(658, 154);
            lstSpuren.TabIndex = 1;
            lstSpuren.SelectedIndexChanged += lstSpuren_SelectedIndexChanged;
            // 
            // btnVerzeichnisHinzufuegen
            // 
            btnVerzeichnisHinzufuegen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVerzeichnisHinzufuegen.Location = new Point(827, 3);
            btnVerzeichnisHinzufuegen.Name = "btnVerzeichnisHinzufuegen";
            btnVerzeichnisHinzufuegen.Size = new Size(154, 23);
            btnVerzeichnisHinzufuegen.TabIndex = 2;
            btnVerzeichnisHinzufuegen.Text = "Verzeichnis hinzufügen";
            btnVerzeichnisHinzufuegen.UseVisualStyleBackColor = true;
            btnVerzeichnisHinzufuegen.Click += btnVerzeichnisHinzufuegen_Click;
            // 
            // btnEntfernen
            // 
            btnEntfernen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEntfernen.Enabled = false;
            btnEntfernen.Location = new Point(827, 63);
            btnEntfernen.Name = "btnEntfernen";
            btnEntfernen.Size = new Size(154, 23);
            btnEntfernen.TabIndex = 3;
            btnEntfernen.Text = "Entfernen";
            btnEntfernen.UseVisualStyleBackColor = true;
            btnEntfernen.Click += btnEntfernen_Click;
            // 
            // lblAusgabeverzeichnis
            // 
            lblAusgabeverzeichnis.AutoSize = true;
            lblAusgabeverzeichnis.Location = new Point(3, 160);
            lblAusgabeverzeichnis.Name = "lblAusgabeverzeichnis";
            lblAusgabeverzeichnis.Size = new Size(111, 15);
            lblAusgabeverzeichnis.TabIndex = 4;
            lblAusgabeverzeichnis.Text = "Ausgabeverzeichnis";
            // 
            // tbAusgabeverzeichnis
            // 
            tableLayoutPanel1.SetColumnSpan(tbAusgabeverzeichnis, 2);
            tbAusgabeverzeichnis.Dock = DockStyle.Fill;
            tbAusgabeverzeichnis.Location = new Point(163, 163);
            tbAusgabeverzeichnis.Name = "tbAusgabeverzeichnis";
            tbAusgabeverzeichnis.ReadOnly = true;
            tbAusgabeverzeichnis.Size = new Size(658, 23);
            tbAusgabeverzeichnis.TabIndex = 5;
            // 
            // btnAuswaehlen
            // 
            btnAuswaehlen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAuswaehlen.Location = new Point(827, 163);
            btnAuswaehlen.Name = "btnAuswaehlen";
            btnAuswaehlen.Size = new Size(154, 23);
            btnAuswaehlen.TabIndex = 6;
            btnAuswaehlen.Text = "Auswählen ...";
            btnAuswaehlen.UseVisualStyleBackColor = true;
            btnAuswaehlen.Click += btnAuswaehlen_Click;
            // 
            // cbProjektErweitern
            // 
            cbProjektErweitern.AutoSize = true;
            cbProjektErweitern.Location = new Point(163, 253);
            cbProjektErweitern.Name = "cbProjektErweitern";
            cbProjektErweitern.Size = new Size(184, 19);
            cbProjektErweitern.TabIndex = 8;
            cbProjektErweitern.Text = "Bestehendes Projekt erweitern";
            cbProjektErweitern.UseVisualStyleBackColor = true;
            cbProjektErweitern.CheckedChanged += cbProjektErweitern_CheckedChanged;
            // 
            // cbFortsetzen
            // 
            cbFortsetzen.AutoSize = true;
            cbFortsetzen.Location = new Point(163, 283);
            cbFortsetzen.Name = "cbFortsetzen";
            cbFortsetzen.Size = new Size(158, 19);
            cbFortsetzen.TabIndex = 9;
            cbFortsetzen.Text = "Nach Abbruch fortsetzen";
            cbFortsetzen.UseVisualStyleBackColor = true;
            cbFortsetzen.CheckedChanged += cbFortsetzen_CheckedChanged;
            // 
            // cbPortabel
            // 
            cbPortabel.AutoSize = true;
            cbPortabel.Location = new Point(163, 313);
            cbPortabel.Name = "cbPortabel";
            cbPortabel.Size = new Size(70, 19);
            cbPortabel.TabIndex = 10;
            cbPortabel.Text = "Portabel";
            cbPortabel.UseVisualStyleBackColor = true;
            cbPortabel.CheckedChanged += cbPortabel_CheckedChanged;
            // 
            // cbInternetdatenLaden
            // 
            cbInternetdatenLaden.AutoSize = true;
            cbInternetdatenLaden.Location = new Point(163, 343);
            cbInternetdatenLaden.Name = "cbInternetdatenLaden";
            cbInternetdatenLaden.Size = new Size(129, 19);
            cbInternetdatenLaden.TabIndex = 11;
            cbInternetdatenLaden.Text = "Internetdaten laden";
            cbInternetdatenLaden.UseVisualStyleBackColor = true;
            cbInternetdatenLaden.CheckedChanged += cbInternetdatenLaden_CheckedChanged;
            // 
            // cbAudioTranslation
            // 
            cbAudioTranslation.AutoSize = true;
            cbAudioTranslation.Location = new Point(495, 253);
            cbAudioTranslation.Name = "cbAudioTranslation";
            cbAudioTranslation.Size = new Size(222, 19);
            cbAudioTranslation.TabIndex = 12;
            cbAudioTranslation.Text = "Audio Transkription und Übersetzung";
            toolTip1.SetToolTip(cbAudioTranslation, "BlahBlubb");
            cbAudioTranslation.UseVisualStyleBackColor = true;
            cbAudioTranslation.CheckedChanged += cbAudioTranslation_CheckedChanged;
            // 
            // cbBildKlassifizierung
            // 
            cbBildKlassifizierung.AutoSize = true;
            cbBildKlassifizierung.Location = new Point(495, 283);
            cbBildKlassifizierung.Name = "cbBildKlassifizierung";
            cbBildKlassifizierung.Size = new Size(125, 19);
            cbBildKlassifizierung.TabIndex = 13;
            cbBildKlassifizierung.Text = "Bilder klassifizieren";
            cbBildKlassifizierung.UseVisualStyleBackColor = true;
            cbBildKlassifizierung.CheckedChanged += cbBildKlassifizierung_CheckedChanged;
            // 
            // cbOcr
            // 
            cbOcr.AutoSize = true;
            cbOcr.Location = new Point(495, 313);
            cbOcr.Name = "cbOcr";
            cbOcr.Size = new Size(257, 19);
            cbOcr.TabIndex = 14;
            cbOcr.Text = "Texterkennung in Bildern und PDFs per OCR";
            cbOcr.UseVisualStyleBackColor = true;
            cbOcr.CheckedChanged += cbOcr_CheckedChanged;
            // 
            // tbKonsole
            // 
            tableLayoutPanel1.SetColumnSpan(tbKonsole, 2);
            tbKonsole.Dock = DockStyle.Fill;
            tbKonsole.Location = new Point(163, 373);
            tbKonsole.Multiline = true;
            tbKonsole.Name = "tbKonsole";
            tbKonsole.Size = new Size(658, 158);
            tbKonsole.TabIndex = 15;
            // 
            // btnStarten
            // 
            btnStarten.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStarten.Location = new Point(827, 508);
            btnStarten.Name = "btnStarten";
            btnStarten.Size = new Size(154, 23);
            btnStarten.TabIndex = 16;
            btnStarten.Text = "Starten";
            btnStarten.UseVisualStyleBackColor = true;
            btnStarten.Click += btnStarten_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.Controls.Add(lblSpuren, 0, 0);
            tableLayoutPanel1.Controls.Add(cbOcr, 2, 7);
            tableLayoutPanel1.Controls.Add(tbKonsole, 1, 9);
            tableLayoutPanel1.Controls.Add(cbBildKlassifizierung, 2, 6);
            tableLayoutPanel1.Controls.Add(cbAudioTranslation, 2, 5);
            tableLayoutPanel1.Controls.Add(lstSpuren, 1, 0);
            tableLayoutPanel1.Controls.Add(cbInternetdatenLaden, 1, 8);
            tableLayoutPanel1.Controls.Add(btnVerzeichnisHinzufuegen, 3, 0);
            tableLayoutPanel1.Controls.Add(cbPortabel, 1, 7);
            tableLayoutPanel1.Controls.Add(btnEntfernen, 3, 2);
            tableLayoutPanel1.Controls.Add(cbFortsetzen, 1, 6);
            tableLayoutPanel1.Controls.Add(lblAusgabeverzeichnis, 0, 3);
            tableLayoutPanel1.Controls.Add(cbProjektErweitern, 1, 5);
            tableLayoutPanel1.Controls.Add(tbAusgabeverzeichnis, 1, 3);
            tableLayoutPanel1.Controls.Add(btnAuswaehlen, 3, 3);
            tableLayoutPanel1.Controls.Add(btnStarten, 3, 9);
            tableLayoutPanel1.Controls.Add(lblWarnung, 1, 4);
            tableLayoutPanel1.Controls.Add(btnDateienHinzufuegen, 3, 1);
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
            // lblWarnung
            // 
            lblWarnung.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblWarnung, 2);
            lblWarnung.Dock = DockStyle.Fill;
            lblWarnung.ForeColor = Color.Red;
            lblWarnung.Location = new Point(163, 190);
            lblWarnung.Name = "lblWarnung";
            lblWarnung.Size = new Size(658, 60);
            lblWarnung.TabIndex = 17;
            // 
            // btnDateienHinzufuegen
            // 
            btnDateienHinzufuegen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDateienHinzufuegen.Location = new Point(827, 33);
            btnDateienHinzufuegen.Name = "btnDateienHinzufuegen";
            btnDateienHinzufuegen.Size = new Size(154, 23);
            btnDateienHinzufuegen.TabIndex = 18;
            btnDateienHinzufuegen.Text = "Dateien hinzufügen";
            btnDateienHinzufuegen.UseVisualStyleBackColor = true;
            btnDateienHinzufuegen.Click += btnDateienHinzufuegen_Click;
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
            tabPage1.Text = "Einstellungen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(990, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
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
            ResumeLayout(false);
        }

        #endregion

        private Label lblSpuren;
        private ListBox lstSpuren;
        private Button btnVerzeichnisHinzufuegen;
        private Button btnEntfernen;
        private Label lblAusgabeverzeichnis;
        private TextBox tbAusgabeverzeichnis;
        private Button btnAuswaehlen;
        private CheckBox cbProjektErweitern;
        private CheckBox cbFortsetzen;
        private CheckBox cbPortabel;
        private CheckBox cbInternetdatenLaden;
        private CheckBox cbAudioTranslation;
        private CheckBox cbBildKlassifizierung;
        private CheckBox cbOcr;
        private TextBox tbKonsole;
        private Button btnStarten;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblWarnung;
        private Button btnDateienHinzufuegen;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}