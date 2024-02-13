﻿

using System.Windows.Forms;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationPanel : UserControl
    {

        private readonly TableLayoutPanel outerTable;
        private readonly TableLayoutPanel navigationTable;
        private readonly Button hamburgerButton;
        private int otherWidth = 48;
        private bool collapsed = false;

        public NavigationButton SettingsButton { get; private set; }

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
                Size = new Size(48, 48),
                Text = '\uE700'.ToString(),
                UseVisualStyleBackColor = false
            };
            hamburgerButton.FlatAppearance.BorderSize = 0;
            hamburgerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.Black);
            hamburgerButton.Click += HamburgerButton_Click;

            SettingsButton = new NavigationButton('\uE713', "Settings");
            SettingsButton.Click += NavigationButton_Click;

            navigationTable = new TableLayoutPanel
            {
                AutoScroll = true,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            outerTable = new TableLayoutPanel
            {
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                RowCount = 3
            };
            outerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            outerTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            outerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            outerTable.Controls.Add(hamburgerButton, 0, 0);
            outerTable.Controls.Add(navigationTable, 0, 1);
            outerTable.Controls.Add(SettingsButton, 0, 2);

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
            navigationTable.RowCount = navigationButtonsToShow.Count + 1;
            for (int i = 0; i < navigationButtonsToShow.Count; i++)
            {
                navigationTable.Controls.Add(navigationButtonsToShow[i], 0, i);
                navigationTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            }
            navigationTable.RowStyles.Add(new RowStyle());
            navigationTable.ResumeLayout();
        }
        
        private void HamburgerButton_Click(object? sender, EventArgs e)
        {
            navigationTable.SuspendLayout();
            // Variablenwerte tauschen
            (Width, otherWidth) = (otherWidth, Width);
            collapsed = !collapsed;
            navigationButtons.Concat(new[] { SettingsButton }).ToList().ForEach(button => {
                button.Type = collapsed ? NavigationButton.ButtonType.IconOnly : NavigationButton.ButtonType.IconAndText;
                button.Invalidate();
            });
            navigationTable.ResumeLayout();
        }

        public void AddNavigationButton(NavigationButton buttonToAdd)
        {
            navigationButtons.Add(buttonToAdd);
            buttonToAdd.Click += NavigationButton_Click;
            RebuildNavigationTable();
        }

        private void NavigationButton_Click(object? sender, EventArgs e)
        {
            navigationTable.SuspendLayout();
            navigationButtons.Concat(new[] { SettingsButton }).ToList().ForEach(button => { 
                button.Selected = button == sender;
                button.Invalidate();
            });
            navigationTable.ResumeLayout();
        }
    }
}
