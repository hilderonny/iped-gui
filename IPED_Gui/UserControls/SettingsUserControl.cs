using IPED_Gui_WinForms.Helper;
using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.UserControls
{
    public partial class SettingsUserControl : UserControl
    {

        public SettingsUserControl(ConfigType configType)
        {

            Dock = DockStyle.Fill;

            var verticalFlowLayoutPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                WrapContents = false
            };
            Controls.Add(verticalFlowLayoutPanel);

            foreach (var configElement in configType.ConfigElements)
            {
                var descriptionLabel = new Label
                {
                    AutoSize = true,
                    Text = configElement.Description,
                    Margin = new Padding(10, 20, 10, 0)
            };
                verticalFlowLayoutPanel.Controls.Add(descriptionLabel);
                var horizontalFlowLayoutPanel = new FlowLayoutPanel {
                    AutoSize = true,
                    Margin = new Padding(10, 0, 10, 0)
                };
                verticalFlowLayoutPanel.Controls.Add(horizontalFlowLayoutPanel);
                var nameLabel = new Label
                {
                    AutoSize = true,
                    Text = configElement.ElementName,
                    Font = new Font(DefaultFont, FontStyle.Bold),
                    Margin = new Padding(0, 7, 3, 15)
                };
                horizontalFlowLayoutPanel.Controls.Add(nameLabel);
                if (configElement.ElementType == typeof(string))
                {
                    var textBox = new TextBox { Text = Settings.Default[configElement.SettingsName].ToString() };
                    textBox.TextChanged += (object? sender, EventArgs e) =>
                    {
                        Settings.Default[configElement.SettingsName] = "" + textBox.Text;
                        Settings.Default.Save();
                    };
                    horizontalFlowLayoutPanel.Controls.Add(textBox);
                }
                else if (configElement.ElementType == typeof(bool))
                {
                    var checkBox = new CheckBox { Checked = (bool)Settings.Default[configElement.SettingsName] };
                    checkBox.CheckedChanged += (object? sender, EventArgs e) =>
                    {
                        Settings.Default[configElement.SettingsName] = checkBox.Checked;
                        Settings.Default.Save();
                    };
                    horizontalFlowLayoutPanel.Controls.Add(checkBox);
                }
            }
        }
    }
}
