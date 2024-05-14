namespace IPED_Gui_Simple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            checkBoxImageClassification = new CheckBox();
            checkBoxAudioProcessing = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSelectSearchTermFile = new Button();
            textBoxSearchTermFilePath = new TextBox();
            label1 = new Label();
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
            tabPageProtocol = new TabPage();
            openFileDialogSettingsIpedExePath = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialogSettingsHashesDB = new OpenFileDialog();
            openFileDialogAudioTranslationServiceProgram = new OpenFileDialog();
            openFileDialogImageClassificationServiceProgram = new OpenFileDialog();
            groupBox2 = new GroupBox();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageOverview.SuspendLayout();
            tabPageProtocol.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(checkBoxImageClassification);
            groupBox2.Controls.Add(checkBoxAudioProcessing);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(163, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 133);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Optionen";
            // 
            // checkBoxImageClassification
            // 
            checkBoxImageClassification.AutoSize = true;
            checkBoxImageClassification.Location = new Point(9, 47);
            checkBoxImageClassification.Name = "checkBoxImageClassification";
            checkBoxImageClassification.Size = new Size(120, 19);
            checkBoxImageClassification.TabIndex = 14;
            checkBoxImageClassification.Text = "Bildklassifizierung";
            checkBoxImageClassification.UseVisualStyleBackColor = true;
            // 
            // checkBoxAudioProcessing
            // 
            checkBoxAudioProcessing.AutoSize = true;
            checkBoxAudioProcessing.Location = new Point(9, 22);
            checkBoxAudioProcessing.Name = "checkBoxAudioProcessing";
            checkBoxAudioProcessing.Size = new Size(125, 19);
            checkBoxAudioProcessing.TabIndex = 13;
            checkBoxAudioProcessing.Text = "Audioverarbeitung";
            checkBoxAudioProcessing.UseVisualStyleBackColor = true;
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
            tableLayoutPanel2.Location = new Point(6, 81);
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
            textBoxConsole.Font = new Font("Consolas", 9.75F);
            textBoxConsole.Location = new Point(3, 3);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.ScrollBars = ScrollBars.Vertical;
            textBoxConsole.Size = new Size(984, 419);
            textBoxConsole.TabIndex = 15;
            // 
            // button_Starten
            // 
            button_Starten.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Starten.Location = new Point(827, 393);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(984, 419);
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
            tabControl1.Controls.Add(tabPageProtocol);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 453);
            tabControl1.TabIndex = 19;
            // 
            // tabPageOverview
            // 
            tabPageOverview.Controls.Add(tableLayoutPanel1);
            tabPageOverview.Location = new Point(4, 24);
            tabPageOverview.Name = "tabPageOverview";
            tabPageOverview.Padding = new Padding(3);
            tabPageOverview.Size = new Size(990, 425);
            tabPageOverview.TabIndex = 0;
            tabPageOverview.Text = "Übersicht";
            tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // tabPageProtocol
            // 
            tabPageProtocol.Controls.Add(textBoxConsole);
            tabPageProtocol.Location = new Point(4, 24);
            tabPageProtocol.Name = "tabPageProtocol";
            tabPageProtocol.Padding = new Padding(3);
            tabPageProtocol.Size = new Size(990, 425);
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
            ClientSize = new Size(1008, 463);
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
        private TextBox textBoxConsole;
        private Button button_Starten;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Warnung;
        private Button button_DateienHinzufuegen;
        private TabControl tabControl1;
        private TabPage tabPageOverview;
        private TabPage tabPageProtocol;
        private OpenFileDialog openFileDialogSettingsIpedExePath;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialogSettingsHashesDB;
        private OpenFileDialog openFileDialogAudioTranslationServiceProgram;
        private OpenFileDialog openFileDialogImageClassificationServiceProgram;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button buttonSelectSearchTermFile;
        private TextBox textBoxSearchTermFilePath;
        private CheckBox checkBoxImageClassification;
        private CheckBox checkBoxAudioProcessing;
    }
}