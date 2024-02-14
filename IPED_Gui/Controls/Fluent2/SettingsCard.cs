namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class SettingsCard : Panel
    {
        public char? Icon { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Control? ActionControl { get; set; }

        private readonly TableLayoutPanel horizontalTable;
        private readonly TableLayoutPanel textTable;
        private readonly Label iconLabel;
        private readonly Label titleLabel;
        private readonly Label descriptionLabel;

        public SettingsCard()
        {
            iconLabel = new Label
            {
                BackColor = Color.Red,
                Size = new Size(48, 40),
            };
            titleLabel = new Label
            {
                BackColor = Color.Blue,
            };
            descriptionLabel = new Label
            {
                BackColor = Color.Green,
            };

            textTable = new TableLayoutPanel
            {
                BackColor = Color.LightGoldenrodYellow,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                RowCount = 0,
            };
            textTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            horizontalTable = new TableLayoutPanel
            {
                BackColor = Color.LightBlue,
                ColumnCount = 0,
                Dock = DockStyle.Fill,
                RowCount = 1,
            };
            horizontalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            BackColor = Color.LightGreen;
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Fill;
            Margin = new Padding(0, 0, 0, 4);
            Padding = new Padding(16);

            Controls.Add(horizontalTable);

            RebuildInnerTable();
        }

        private void RebuildInnerTable()
        {
            SuspendLayout();
            horizontalTable.SuspendLayout();
            textTable.SuspendLayout();

            horizontalTable.Controls.Clear();
            horizontalTable.ColumnStyles.Clear();
            horizontalTable.ColumnCount = 0;

            textTable.Controls.Clear();
            textTable.RowStyles.Clear();

            if (Icon != null)
            {
                iconLabel.Text = Icon.ToString();
                horizontalTable.ColumnCount++;
                horizontalTable.Controls.Add(iconLabel, 0, 0);
                horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            if (Title != null)
            {
                horizontalTable.ColumnCount++;
                horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                titleLabel.Text = Title;
                if (Description != null)
                {
                    descriptionLabel.Text = Description;
                    textTable.Controls.Add(titleLabel, 0, 0);
                    textTable.Controls.Add(descriptionLabel, 0, 1);
                    horizontalTable.Controls.Add(textTable, 1, 0);
                }
                else
                {
                    horizontalTable.Controls.Add(titleLabel, 1, 0);
                }
            }
            else if (Description != null)
            {
                horizontalTable.ColumnCount++;
                horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                descriptionLabel.Text = Description;
                horizontalTable.Controls.Add(descriptionLabel, 1, 0);
            }
            if (ActionControl != null)
            {
                horizontalTable.ColumnCount++;
                horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                horizontalTable.Controls.Add(ActionControl, 2, 0);
            }

            textTable.ResumeLayout(false);
            horizontalTable.ResumeLayout(false);
            ResumeLayout();
        }

    }
}
