using System;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;
using Microsoft.UI.Xaml;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Tools
    {

        public static async Task<string> SelectFile()
        {
            FileOpenPicker filePicker = new();
            filePicker.FileTypeFilter.Add(".exe");
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(filePicker, hWnd);
            StorageFile selectedFile = await filePicker.PickSingleFileAsync();
            return selectedFile?.Path;
        }

        public static async Task<string> SelectFolder()
        {
            FolderPicker folderPicker = new();
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);
            StorageFolder selectedFolder = await folderPicker.PickSingleFolderAsync();
            return selectedFolder?.Path;
        }

    }
}
