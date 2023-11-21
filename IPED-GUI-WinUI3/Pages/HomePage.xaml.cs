using IPED_GUI_WinUI3.Data;
using IPED_GUI_WinUI3.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using Windows.Storage;
using Windows.Storage.Pickers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace IPED_GUI_WinUI3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {

        public HomePage()
        {
            InitializeComponent();
            HomeCurrentProfile.Description = Settings.Current.FilePath;
        }

        private async void HomeLoadProfileButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFile(".ipedguiprofile") is string selectedFile)
            {
                ApplicationDataContainer appSettings = ApplicationData.Current.LocalSettings;
                Settings.LoadFromFile(selectedFile);
                appSettings.Values["CurrentProfileFile"] = selectedFile;
                HomeCurrentProfile.Description = selectedFile;
            }
        }

        private void HomeSaveCurrentProfileButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Current.Save(Settings.Current.FilePath);
            HomeProfileSavedTeachingTip.IsOpen = true;
        }

        private async void HomeSaveCurrentProfileAsButton_Click(object sender, RoutedEventArgs e)
        {
            FileSavePicker filePicker = new();
            filePicker.FileTypeChoices.Add("IPED GUI profile", new List<string>() { ".ipedguiprofile" });
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(filePicker, hWnd);
            if (await filePicker.PickSaveFileAsync() is StorageFile selectedFile)
            {
                Settings.Current.Save(selectedFile.Path);
                ApplicationDataContainer appSettings = ApplicationData.Current.LocalSettings;
                appSettings.Values["CurrentProfileFile"] = selectedFile.Path;
                HomeCurrentProfile.Description = selectedFile.Path;
                HomeProfileSavedTeachingTip.IsOpen = true;
            }
        }

        private void HomeStartButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Current.CreateProfile();
        }

        private async void HomeAddFileButton_Click(object sender, RoutedEventArgs e)
        {
            string[] extensions = { ".DD", ".001", ".E01", ".Ex01", ".VHD", ".VHDX", ".VMDK", ".ISO", ".AFF", ".AD1", ".UFDR" , "*" };
            if (await Tools.SelectFilePath(extensions) is StorageFile selectedFile)
            {
                Source.Sources.Add(new(selectedFile.Path, selectedFile.Name));
            }
        }

        private async void HomeAddFolderButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFolderPath() is StorageFolder selectedFolder)
            {
                Source.Sources.Add(new(selectedFolder.Path, selectedFolder.Name));
            }
        }

        private void HomeDeleteRowButton_Click(object sender, RoutedEventArgs e)
        {
            var source = ((FrameworkElement)sender).DataContext as Source;
            Source.Sources.Remove(source);
        }
    }
}
