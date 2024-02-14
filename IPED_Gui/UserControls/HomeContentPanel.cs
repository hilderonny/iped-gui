using IPED_Gui_WinForms.Controls;
using IPED_Gui_WinForms.Controls.Fluent2;

namespace IPED_Gui_WinForms.UserControls
{
    public class HomeContentPanel : VerticalTableLayoutPanel
    {
        public HomeContentPanel()
        {

            AddControl(new SettingsCard { Icon = 'C', Title = "Title", Description = "Description", ActionControl = new Button { Text = "Button" } });

        }
    }
}
