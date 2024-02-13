﻿using IPED_Gui_WinForms.Controls.Fluent2;

namespace IPED_Gui_WinForms
{
    public class TestForm : Form
    {
        private class NavigationInfo
        {
            public char Icon { get; set; }
            public string? Title { get; set; }

            public NavigationButton? Button { get; set; }

            public static List<NavigationInfo> NavigationElements { get; } = new List<NavigationInfo>
            {
                new NavigationInfo { Icon = '\uE80F', Title = "Home" },
                new NavigationInfo { Icon = '\uE977', Title = "Local config" },
                new NavigationInfo { Icon = '\uE734', Title = "Features" },
                new NavigationInfo { Icon = '\uE762', Title = "Categories" },
                new NavigationInfo { Icon = '\uEC50', Title = "File system" },
                new NavigationInfo { Icon = '\uED1F', Title = "Audio translation" },
                new NavigationInfo { Icon = '\uE8BA', Title = "Image classification" },
                new NavigationInfo { Icon = '\uEA37', Title = "Protocol" },
            };
        }

        private readonly TableLayoutPanel rootTableLayoutPanel;
        private readonly NavigationPanel navigationPanel;
        private readonly ContentPanel contentPanel;

        private readonly NavigationButton homeNavigationButton;

        public TestForm()
        {

            contentPanel = new ContentPanel();

            navigationPanel = new NavigationPanel();

            NavigationInfo.NavigationElements.ForEach(element => {
                element.Button = new NavigationButton(element.Icon, element.Title);
                element.Button.Click += NavigationButton_Click;
                navigationPanel.AddNavigationButton(element.Button);
            });
            navigationPanel.SettingsButton.Click += NavigationButton_Click;
            var firstNavigationButton = NavigationInfo.NavigationElements[0].Button;
            if (firstNavigationButton != null)
            {
                firstNavigationButton.Selected = true;
                NavigationButton_Click(firstNavigationButton, EventArgs.Empty);
            }


            rootTableLayoutPanel = new TableLayoutPanel();
            rootTableLayoutPanel.SuspendLayout();
            rootTableLayoutPanel.ColumnCount = 2;
            rootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            rootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            rootTableLayoutPanel.Dock = DockStyle.Fill;
            rootTableLayoutPanel.Margin = Padding.Empty;
            rootTableLayoutPanel.Padding = Padding.Empty;
            rootTableLayoutPanel.RowCount = 1;
            rootTableLayoutPanel.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            rootTableLayoutPanel.Controls.Add(navigationPanel, 0, 0);
            rootTableLayoutPanel.Controls.Add(contentPanel, 1, 0);
            rootTableLayoutPanel.ResumeLayout();

            ClientSize = new Size(800, 600);
            Controls.Add(rootTableLayoutPanel);

        }

        private void NavigationButton_Click(object? sender, EventArgs e)
        {
            NavigationButton? button = sender as NavigationButton;
            contentPanel.Title = button?.Text;
        }
    }
}
