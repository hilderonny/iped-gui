using IPED_Gui_WinForms.Messages;
using Microsoft.Web.WebView2.Core;
using System.Reflection;

namespace IPED_Gui_WinForms
{
    public partial class MainForm : Form
    {
        private MessageHandler? messageHandler;

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
            messageHandler = new MessageHandler(webView.CoreWebView2);
            webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived; ;
            // https://stackoverflow.com/a/69870089
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(hostName: "local", folderPath: "AppData\\html", accessKind: Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Allow);
            webView.CoreWebView2.Navigate("https://local/index.html");
        }

        private void CoreWebView2_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string json = e.WebMessageAsJson;
            messageHandler?.handleMessage(json);
            //webView.CoreWebView2.PostWebMessageAsString(uri);
        }

    }
}