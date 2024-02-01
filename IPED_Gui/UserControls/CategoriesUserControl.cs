using IPED_Gui_WinForms.Data;
using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.UserControls
{

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

            if (Category.Root.SubCategories != null)
            {
                foreach (var subCategory in Category.Root.SubCategories)
                {
                    ProcessCategory(subCategory, 0);
                }
            }
        }

        private void ProcessCategory(Category category, int depth)
        {
            var horizontalFlowLayoutPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Margin = new Padding(depth * 20, 0, 0, 0)
            };
            verticalFlowLayoutPanel.Controls.Add(horizontalFlowLayoutPanel);
            var checkBox = new CheckBox
            {
                AutoSize = true,
                Image = category.Icon,
                ImageAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                Padding = new Padding(5),
                Text = category.Name,
                TextImageRelation = TextImageRelation.ImageBeforeText
            };
            if (category.SettingsKey != null)
            {
                checkBox.Checked = (bool)Settings.Default[category.SettingsKey];
            }
            checkBox.CheckedChanged += (object? sender, EventArgs e) =>
            {
                Settings.Default[category.SettingsKey] = checkBox.Checked;
                Settings.Default.Save();
            };
            horizontalFlowLayoutPanel.Controls.Add(checkBox);
            if (category.SubCategories != null)
            {
                foreach (var subCategory in category.SubCategories)
                {
                    ProcessCategory(subCategory, depth + 1);
                }
            }
        }
    }
}
