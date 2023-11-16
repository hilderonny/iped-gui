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
        readonly ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;

        public SettingsPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            if (settings.Values[Constants.SETTINGS_IPEDEXEPATH] is string ipedexepath)
            {
                SettingsIpedExePath.Description = ipedexepath;
            }
            if (settings.Values[Constants.SETTINGS_LOCALE] is not string selectedLanguage)
            {
                selectedLanguage = "de-DE";
                settings.Values[Constants.SETTINGS_LOCALE] = selectedLanguage;
            }
            SettingsLocaleComboBox.SelectedIndex = Languages.Keys.ToList().IndexOf(selectedLanguage);
        }

        private async void SettingsSelectIpedExePathButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedFile = await Tools.SelectFile();
            if (selectedFile != null)
            {
                settings.Values[Constants.SETTINGS_IPEDEXEPATH] = selectedFile;
                SettingsIpedExePath.Description = selectedFile;
            }
        }

        private void SettingsLocaleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            settings.Values[Constants.SETTINGS_LOCALE] = SettingsLocaleComboBox.SelectedValue;
        }

    }
}
