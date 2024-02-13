

using System.Windows.Forms;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationPanel : UserControl
    {

        private readonly TableLayoutPanel outerTable;
        private readonly TableLayoutPanel navigationTable;
        private readonly Button hamburgerButton;
        private readonly NavigationButton settingsButton;
        private int otherWidth = 44;

        private List<NavigationButton> navigationButtons = new();

        public NavigationPanel()
        {
            hamburgerButton = new Button
            {
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point),
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                Size = new Size(44, 44),
                Text = '\uE700'.ToString(),
                UseVisualStyleBackColor = false
            };
            hamburgerButton.FlatAppearance.BorderSize = 0;
            hamburgerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.Black);
            hamburgerButton.Click += HamburgerButton_Click;

            settingsButton = new NavigationButton('\uE713', "Settings");

            navigationTable = new TableLayoutPanel
            {
                AutoScroll = true,
                BackColor = Color.Green,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            outerTable = new TableLayoutPanel
            {
                BackColor = Color.Yellow,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                RowCount = 3
            };
            outerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            outerTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            outerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            outerTable.Controls.Add(hamburgerButton, 0, 0);
            outerTable.Controls.Add(navigationTable, 0, 1);
            outerTable.Controls.Add(settingsButton, 0, 2);

            BackColor = Color.Cyan;
            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Width = 200;
            Controls.Add(outerTable);
        }

        private void RebuildNavigationTable()
        {
            navigationTable.SuspendLayout();
            navigationTable.Controls.Clear();
            navigationTable.RowStyles.Clear();
            var navigationButtonsToShow = navigationButtons.Where(button => button.Visible).ToList();
            navigationTable.RowCount = navigationButtonsToShow.Count;
            for (int i = 0; i < navigationButtonsToShow.Count; i++)
            {
                navigationTable.Controls.Add(navigationButtonsToShow[i], 0, i);
                navigationTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            }
            navigationTable.ResumeLayout();
        }
        
        private void HamburgerButton_Click(object? sender, EventArgs e)
        {
            // Variablenwerte tauschen
            (Width, otherWidth) = (otherWidth, Width);
        }

        public void AddNavigationButton(NavigationButton buttonToAdd)
        {
            navigationButtons.Add(buttonToAdd);
            RebuildNavigationTable();
        }
    }
}
