using IPED_Gui_WinForms.Controls;
using IPED_Gui_WinForms.Controls.Fluent2;

namespace IPED_Gui_WinForms.UserControls
{
    public class HomeContentPanel : VerticalTableLayoutPanel
    {
        public HomeContentPanel()
        {
            Padding = new Padding(0, 0, 54, 0);

            AddControl(new SettingsCard { Icon = '\uED15', Title = "Title", Description = "Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description ", ActionControl = new Button { Text = "Button", AutoSize = true } });
            AddControl(new SettingsCard { Title = "Title", Description = "Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description ", ActionControl = new Button { Text = "Button", AutoSize = true } });
            AddControl(new SettingsCard { Icon = 'C', Title = "Title", ActionControl = new Button { Text = "Button", AutoSize = true } });
            AddControl(new SettingsCard { Title = "Title", ActionControl = new Button { Text = "Button", AutoSize = true } });
            AddControl(new SettingsCard { Icon = 'C', Title = "Title", Description = "Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description " });
            AddControl(new SettingsCard { Title = "Title", Description = "Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description " });
            AddControl(new SettingsCard { Icon = 'C', Title = "Title" });
            AddControl(new SettingsCard { Title = "Title" });
            AddControl(new SettingsCard { Icon = '\uED15', Title = "Title", ActionControl = new CheckBox { Text = "", AutoSize = true }, Description = "Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description " });
            AddControl(new SettingsCard { Icon = '\uED15', Title = "Title", ActionControl = new ComboBox { AutoSize = true }, Description = "Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description Description " });

        }
    }
}
