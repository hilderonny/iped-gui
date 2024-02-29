using System.Reflection;

namespace IPED_Gui_WinForms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            InitializeAsync();

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Text += " " + version?.Major + "." + version?.Minor + "." + version?.Build;
        }

        async void InitializeAsync()
        {
            Console.WriteLine("InitializeAsync starting");
            await webView.EnsureCoreWebView2Async(null);
            Console.WriteLine("InitializeAsync done");
        }

        private void webView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {

            // https://stackoverflow.com/a/69870089
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(hostName: "local", folderPath: "AppData\\html", accessKind: Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Allow);
            webView.CoreWebView2.Navigate("https://local/index.html");

        }
    }
}