using Microsoft.Web.WebView2.Core;
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
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived; ;
            // https://stackoverflow.com/a/69870089
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(hostName: "local", folderPath: "AppData\\html", accessKind: Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Allow);
            webView.CoreWebView2.Navigate("https://local/index.html");
        }

        private void CoreWebView2_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            String uri = e.TryGetWebMessageAsString();
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

    }
}