
using System.Windows.Forms;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationButton : UserControl
    {

        private readonly TableLayoutPanel horizontalTable;
        private readonly Label iconLabel;
        private readonly Label textLabel;
        private Color otherColor = Color.FromArgb(20, Color.Black);

        public NavigationButton(char iconChar, string text)
        {
            iconLabel = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point),
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                Size = new Size(44, 44),
                Text = iconChar.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };

            textLabel = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(4, 0, 0, 0),
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft
            };
            textLabel.MouseEnter += HorizontalTable_MouseEnter;
            textLabel.MouseLeave += HorizontalTable_MouseLeave;

            horizontalTable = new TableLayoutPanel
            {
                BackColor = Color.DarkRed,
                ColumnCount = 2,
                Height = 44,
                RowCount = 1
            };
            horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            horizontalTable.Controls.Add(iconLabel, 0, 0);
            horizontalTable.Controls.Add(textLabel, 1, 0);

            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Controls.Add(horizontalTable);
        }

        private void HorizontalTable_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.DarkRed;
            PerformLayout();
        }

        private void HorizontalTable_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Green;
            PerformLayout();
        }
    }
}
