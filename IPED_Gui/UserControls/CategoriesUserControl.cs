using IPED_Gui_WinForms.Helper;
using IPED_Gui_WinForms.Properties;
using System.ComponentModel;
using System.Text.Json;

namespace IPED_Gui_WinForms.UserControls
{
    class Category
    {
        public string? name { get; set; }
        public Category[]? categories { get; set; }

    }

    public partial class CategoriesUserControl : UserControl
    {

        private readonly FlowLayoutPanel verticalFlowLayoutPanel;

        public CategoriesUserControl()
        {
            Dock = DockStyle.Fill;

            verticalFlowLayoutPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                WrapContents = false
            };
            Controls.Add(verticalFlowLayoutPanel);
        }

        public void LoadCategories()
        {
            verticalFlowLayoutPanel.Controls.Clear();

            string ipedExePath = Settings.Default.SettingsIpedExePath;
            if (string.IsNullOrEmpty(ipedExePath))
            {
                return;
            }
            string? ipedDirectory = Path.GetDirectoryName(Settings.Default.SettingsIpedExePath);
            if (string.IsNullOrEmpty(ipedDirectory))
            {
                return;
            }
            string configFilePath = Path.Join(ipedDirectory, "conf", "CategoriesConfig.json");
            if (!File.Exists(configFilePath))
            {
                return;
            }
            string categoriesConfig = File.ReadAllText(configFilePath);
            Category? rootCategory = JsonSerializer.Deserialize<Category>(categoriesConfig);
            if (rootCategory != null)
            {
                ProcessCategory(rootCategory, 0);
            }
        }

        private void ProcessCategory(Category category, int depth)
        {
            var horizontalFlowLayoutPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 0)
            };
            verticalFlowLayoutPanel.Controls.Add(horizontalFlowLayoutPanel);
            var checkBox = new CheckBox
            {
                Checked = false,
                Margin = new Padding(depth * 20, 0, 0, 0),
                Text = category.name
            };
            checkBox.CheckedChanged += (object? sender, EventArgs e) =>
            {
                //Settings.Default[configElement.SettingsName] = checkBox.Checked;
                //Settings.Default.Save();
            };
            horizontalFlowLayoutPanel.Controls.Add(checkBox);
            if (category.categories != null)
            {
                foreach (var subCategory in category.categories)
                {
                    ProcessCategory(subCategory, depth + 1);
                }
            }
        }
    }
}
