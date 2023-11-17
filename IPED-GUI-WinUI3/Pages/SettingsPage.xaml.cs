using IPED_GUI_WinUI3.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Linq;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace IPED_GUI_WinUI3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {

        public Dictionary<string, string> Languages { get; } = Dictionaries.Languages;

        public SettingsPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            if (Settings.Current.SETTINGS_IPEDEXEPATH is string ipedexepath)
            {
                SettingsIpedExePath.Description = ipedexepath;
            }
            if (Settings.Current.SETTINGS_LOCALE is not string selectedLanguage)
            {
                selectedLanguage = "de-DE";
                Settings.Current.SETTINGS_LOCALE = selectedLanguage;
            }
            SettingsLocaleComboBox.SelectedIndex = Languages.Keys.ToList().IndexOf(selectedLanguage);
            if (Settings.Current.SETTINGS_INDEXTEMP is string indexTemp)
            {
                SettingsIndexTemp.Description = indexTemp;
            }
            if (Settings.Current.SETTINGS_INDEXTEMPONSSD is bool indexTempOnSSD)
            {
                SettingsIndexTempOnSSDToggleSwitch.IsOn = indexTempOnSSD;
            }
            if (Settings.Current.SETTINGS_OUTPUTONSSD is bool outputOnSSD)
            {
                SettingsOutputOnSSDToggleSwitch.IsOn = outputOnSSD;
            }
            if (Settings.Current.SETTINGS_NUMTHREADS is not string numThreads)
            {
                numThreads = "default";
                Settings.Current.SETTINGS_NUMTHREADS = numThreads;
            }
            SettingsNumThreadsTextBox.Text = numThreads;
            if (Settings.Current.SETTINGS_HASHESDB is string hashesDb)
            {
                SettingsHashesDB.Description = hashesDb;
            }
            SettingsLocaleComboBox.SelectedIndex = Languages.Keys.ToList().IndexOf(selectedLanguage);
            if (Settings.Current.SETTINGS_PLUGINFOLDER is string pluginFolder)
            {
                SettingsPluginFolder.Description = pluginFolder;
            }
        }

        private async void SettingsSelectIpedExePathButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFile(".exe") is string selectedFile)
            {
                Settings.Current.SETTINGS_IPEDEXEPATH = selectedFile;
                SettingsIpedExePath.Description = selectedFile;
            }
        }

        private void SettingsLocaleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Settings.Current.SETTINGS_LOCALE = SettingsLocaleComboBox.SelectedValue as string;
        }

        private async void SettingsSelectIndexTempButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFolder() is string selectedFolder)
            {
                Settings.Current.SETTINGS_INDEXTEMP = selectedFolder;
                SettingsIndexTemp.Description = selectedFolder;
            }
        }

        private void SettingsIndexTempOnSSDToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.SETTINGS_INDEXTEMPONSSD = SettingsIndexTempOnSSDToggleSwitch.IsOn;
        }

        private void SettingsOutputOnSSDToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.SETTINGS_OUTPUTONSSD = SettingsOutputOnSSDToggleSwitch.IsOn;
        }

        private void SettingsNumThreadsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Settings.Current.SETTINGS_NUMTHREADS = SettingsNumThreadsTextBox.Text;
        }

        private async void SettingsSelectHashesDBButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFile(".db") is string selectedFile)
            {
                Settings.Current.SETTINGS_HASHESDB = selectedFile;
                SettingsHashesDB.Description = selectedFile;
            }
        }

        private async void SettingsSelectPluginFolderButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFolder() is string selectedFolder)
            {
                Settings.Current.SETTINGS_PLUGINFOLDER = selectedFolder;
                SettingsPluginFolder.Description = selectedFolder;
            }
        }

    }
}
