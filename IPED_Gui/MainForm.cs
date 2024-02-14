using IPED_Gui_WinForms.Controls.Fluent2;
using IPED_Gui_WinForms.Helper;
using IPED_Gui_WinForms.UserControls;

namespace IPED_Gui_WinForms
{
    public class MainForm : Form
    {
        private class NavigationInfo
        {
            public char Icon { get; set; }
            public string? Title { get; set; }

            public Control? Control { get; set; }

            public NavigationButton? Button { get; set; }

            public static List<NavigationInfo> NavigationElements { get; } = new List<NavigationInfo>
            {
                new() { Icon = '\uE80F', Title = "Home", Control = new HomeContentPanel() },
                new() { Icon = '\uE977', Title = "Local config", Control = new SettingsUserControl(ConfigType.LocalConfig) },
                new() { Icon = '\uE734', Title = "Features", Control = new SettingsUserControl(ConfigType.IPEDConfig) },
                new() { Icon = '\uE762', Title = "Categories", Control = new CategoriesUserControl() },
                new() { Icon = '\uEC50', Title = "File system", Control = new SettingsUserControl(ConfigType.FileSystemConfig) },
                new() { Icon = '\uED1F', Title = "Audio translation", Control = new SettingsUserControl(ConfigType.AudioTranslation) },
                new() { Icon = '\uE8BA', Title = "Image classification", Control = new SettingsUserControl(ConfigType.ImageClassification) },
                new() { Icon = '\uEA37', Title = "Protocol" },
            };
        }

        private readonly TableLayoutPanel rootTableLayoutPanel;
        private readonly NavigationPanel navigationPanel;
        private readonly ContentPanel contentPanel;

        public MainForm()
        {

            contentPanel = new ContentPanel();

            navigationPanel = new NavigationPanel
            {
                Width = 320
            };

            NavigationInfo.NavigationElements.ForEach(element => {
                element.Button = new NavigationButton(element.Icon, element.Title) { ContentControl = element.Control };
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

            ClientSize = new Size(1200, 800);
            DoubleBuffered = true;
            Controls.Add(rootTableLayoutPanel);

        }

        private void NavigationButton_Click(object? sender, EventArgs e)
        {
            NavigationButton? button = sender as NavigationButton;
            contentPanel.SuspendLayout();
            contentPanel.Title = button?.Text;
            contentPanel.ContentControl = button?.ContentControl;
            contentPanel.ResumeLayout();
        }
    }
}
