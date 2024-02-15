using IPED_Gui_WinForms.Controls;
using IPED_Gui_WinForms.Controls.Fluent2;

namespace IPED_Gui_WinForms.UserControls
{
    public class HomeContentPanel : VerticalTableLayoutPanel
    {
        public HomeContentPanel()
        {
            Padding = new Padding(0, 0, 54, 0);

            AddControl(new SettingsCard { Icon = 'C', Title = "Title", Description = "Description", ActionControl = new Button { Text = "Button" } });

        }
    }
}
