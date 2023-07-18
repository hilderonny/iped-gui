using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Forms;

namespace IPED_GUI
{
    /// <summary>
    /// Interaktionslogik für ExtendCaseWindow.xaml
    /// </summary>
    public partial class ExtendCaseWindow : Window
    {

        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;

        public ExtendCaseWindow()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "E01";
            openFileDialog.Filter = "E01 Images (*.e01)|*.e01";
            folderBrowserDialog = new FolderBrowserDialog();

            InitializeComponent();

            Title += " - " + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void btnOpenFolder_Click(object sender, RoutedEventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tbFolder.Text = folderBrowserDialog.SelectedPath;
            }
            CheckReadButton();
        }

        private void btnOpenImage_Click(object sender, RoutedEventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tbImage.Text = openFileDialog.FileName;
            }
            CheckReadButton();
        }

        private void CheckReadButton()
        {
            btnRead.IsEnabled = !string.IsNullOrEmpty(tbFolder.Text) && !string.IsNullOrEmpty(tbImage.Text);
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            bool shouldAppend = Directory.GetFileSystemEntries(tbFolder.Text).Length > 0;
            string arguments = "-d " + tbImage.Text + " -o " + tbFolder.Text + " --portable";
            if (shouldAppend)
            {
                arguments += " --append";
            }
            Process ipedProcess = new Process();
            ipedProcess.StartInfo.FileName = "iped.exe";
            ipedProcess.StartInfo.Arguments = arguments;
            ipedProcess.Start();
        }
    }
}
