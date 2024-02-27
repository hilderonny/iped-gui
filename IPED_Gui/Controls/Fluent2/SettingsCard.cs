﻿namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class SettingsCard : Panel
    {
        public char? Icon { get => icon; set { icon = value; RebuildInnerTable(); } }
        public string? Title { get => title; set { title = value; RebuildInnerTable(); } }
        public string? Description { get => description; set { description = value; RebuildInnerTable(); } }
        public Control? ActionControl { get => actionControl; set { actionControl = value; RebuildInnerTable(); } }

        private char? icon;
        private string? title;
        private string? description;
        private Control? actionControl;
        private readonly TableLayoutPanel horizontalTable;
        private readonly TableLayoutPanel textTable;
        private readonly Label iconLabel;
        private readonly Label titleLabel;
        private readonly Label descriptionLabel;

        public SettingsCard()
        {

            horizontalTable = new TableLayoutPanel
            {
                BackColor = Color.PaleGreen,
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                RowCount = 1,
            };
            horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            horizontalTable.ColumnStyles.Add(new ColumnStyle());
            horizontalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            iconLabel = new Label
            {
                AutoSize = true,
                BackColor = Color.Plum,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            textTable = new TableLayoutPanel
            {
                BackColor = Color.MistyRose,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                RowCount = 2,
            };
            textTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            textTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            textTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            titleLabel = new Label
            {
                AutoSize = true,
                BackColor = Color.Blue,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Margin = Padding.Empty,
            };

            descriptionLabel = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Green,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.Gray,
                Margin = Padding.Empty,
            };

            BackColor = Color.LightSteelBlue;
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Fill;
            Margin = new Padding(0, 0, 0, 5);
            Padding = new Padding(16);

            textTable.Controls.Add(titleLabel, 0, 0);
            textTable.Controls.Add(descriptionLabel, 0, 1);

            Controls.Add(horizontalTable);

            RebuildInnerTable();
        }

        private void RebuildInnerTable()
        {
            SuspendLayout();
            horizontalTable.SuspendLayout();
            textTable.SuspendLayout();

            horizontalTable.Controls.Clear();
            horizontalTable.Controls.Add(textTable, 1, 0);

            if (Icon != null)
            {
                iconLabel.Text = Icon.ToString();
                horizontalTable.Controls.Add(iconLabel, 0, 0);
            }
            if (Title != null)
            {
                titleLabel.Text = Title;
            }
            if (Description != null)
            {
                descriptionLabel.Text = Description;
            }
            if (ActionControl != null)
            {
                ActionControl.Anchor = AnchorStyles.None;
                ActionControl.Margin = new Padding(16, 0, 0, 0);
                horizontalTable.Controls.Add(ActionControl, 2, 0);
            }

            textTable.ResumeLayout(false);
            horizontalTable.ResumeLayout(false);
            ResumeLayout();
        }

    }
}
