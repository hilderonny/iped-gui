using System;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Tools
    {
        // ".exe"
        public static async Task<string> SelectFile(string filterType)
        {
            FileOpenPicker filePicker = new();
            filePicker.FileTypeFilter.Add(filterType);
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(filePicker, hWnd);
            StorageFile selectedFile = await filePicker.PickSingleFileAsync();
            return selectedFile?.Path;
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
