using IPED_Gui_WinForms.Helper;
using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.UserControls
{
    public partial class SettingsUserControl : UserControl
    {

        private readonly FlowLayoutPanel verticalFlowLayoutPanel;
        private readonly ConfigType configType;

        public SettingsUserControl(ConfigType ct)
        {
            configType = ct;

            Dock = DockStyle.Fill;

            verticalFlowLayoutPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                WrapContents = false
            };
            Controls.Add(verticalFlowLayoutPanel);

            Reload();

        }

        public void Reload() {

            verticalFlowLayoutPanel.Controls.Clear();

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
                if (configElement.ElementType == ConfigElementType.String)
                {
                    var textBox = new TextBox { Size = new Size(571, 23), Text = Settings.Default[configElement.SettingsName].ToString() };
                    textBox.TextChanged += (object? sender, EventArgs e) =>
                    {
                        Settings.Default[configElement.SettingsName] = "" + textBox.Text;
                        Settings.Default.Save();
                    };
                    horizontalFlowLayoutPanel.Controls.Add(textBox);
                }
                else if (configElement.ElementType == ConfigElementType.Boolean)
                {
                    var checkBox = new CheckBox { Checked = (bool)Settings.Default[configElement.SettingsName] };
                    checkBox.CheckedChanged += (object? sender, EventArgs e) =>
                    {
                        Settings.Default[configElement.SettingsName] = checkBox.Checked;
                        Settings.Default.Save();
                    };
                    horizontalFlowLayoutPanel.Controls.Add(checkBox);
                }
                else if (configElement.ElementType == ConfigElementType.Directory || configElement.ElementType == ConfigElementType.DirectoryRelativeToIpedExe)
                {
                    var textBox = new TextBox {
                        Size = new Size(571, 23),
                        ReadOnly = true,
                        Text = Settings.Default[configElement.SettingsName].ToString()
                    };
                    horizontalFlowLayoutPanel.Controls.Add(textBox);
                    var folderBrowserDialog = new FolderBrowserDialog
                    {
                        SelectedPath = Settings.Default[configElement.SettingsName].ToString()
                    };
                    var button = new Button
                    {
                        Size = new Size(120, 23),
                        Text = "Auswählen ...",
                        UseVisualStyleBackColor = true
                    };
                    button.Click += (object? sender, EventArgs e) =>
                    {
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            var selectedFolder = folderBrowserDialog.SelectedPath;
                            textBox.Text = selectedFolder;
                            Settings.Default[configElement.SettingsName] = selectedFolder;
                            Settings.Default.Save();
                        }
                    };
                    horizontalFlowLayoutPanel.Controls.Add(button);
                }
                else if (configElement.ElementType == ConfigElementType.File)
                {
                    var textBox = new TextBox
                    {
                        Size = new Size(571, 23),
                        ReadOnly = true,
                        Text = Settings.Default[configElement.SettingsName].ToString()
                    };
                    horizontalFlowLayoutPanel.Controls.Add(textBox);
                    var openFileDialog = new OpenFileDialog
                    {
                        Filter = configElement.Filter,
                        FileName = Settings.Default[configElement.SettingsName].ToString()
                    };
                    var button = new Button
                    {
                        Size = new Size(120, 23),
                        Text = "Auswählen ...",
                        UseVisualStyleBackColor = true
                    };
                    button.Click += (object? sender, EventArgs e) =>
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var selectedFile = openFileDialog.FileName;
                            textBox.Text = selectedFile;
                            Settings.Default[configElement.SettingsName] = selectedFile;
                            Settings.Default.Save();
                        }
                    };
                    horizontalFlowLayoutPanel.Controls.Add(button);
                }
                else if (configElement.ElementType == ConfigElementType.StringList)
                {
                    var comboBox = new ComboBox();
                    comboBox.Items.AddRange(configElement.ListElements.ToArray());
                    comboBox.SelectedIndex = comboBox.FindStringExact(Settings.Default[configElement.SettingsName].ToString());
                    comboBox.SelectedIndexChanged += (object? sender, EventArgs e) =>
                    {
                        Settings.Default[configElement.SettingsName] = (string)comboBox.SelectedItem;
                        Settings.Default.Save();
                    };
                    horizontalFlowLayoutPanel.Controls.Add(comboBox);
                }
            }
        }
    }
}
