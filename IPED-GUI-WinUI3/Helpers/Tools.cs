using System;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;
using Microsoft.UI.Xaml;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Tools
    {

        public static async Task<string> SelectFile(params string[] filterTypes)
        {
            return (await SelectFilePath(filterTypes))?.Path;
        }

        public static async Task<StorageFile> SelectFilePath(params string[] filterTypes)
        {
            FileOpenPicker filePicker = new();
            foreach (var filterType in filterTypes)
            {
                filePicker.FileTypeFilter.Add(filterType);
            }
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(filePicker, hWnd);
            return await filePicker.PickSingleFileAsync();
        }

        public static async Task<string> SelectFolder()
        {
            return (await SelectFolderPath())?.Path;
        }

        public static async Task<StorageFolder> SelectFolderPath()
        {
            FolderPicker folderPicker = new();
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);
            return await folderPicker.PickSingleFolderAsync();
        }

    }
}
