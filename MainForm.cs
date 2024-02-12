using Microsoft.Web.WebView2.WinForms;

namespace IPED_Gui_WinForms
{
    public class MainForm : Form
    {
        public MainForm()
        {

            Icon = new Icon("IPED_Gui.ico");

            var webView = new WebView2
            {
                Dock = DockStyle.Fill,
                Source = new Uri("https://microsoft.com")
            };
            Controls.Add(webView);

        }

    }
}