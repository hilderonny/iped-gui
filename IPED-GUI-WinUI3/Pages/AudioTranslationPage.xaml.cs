using IPED_GUI_WinUI3.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace IPED_GUI_WinUI3.Pages
{

    public sealed partial class AudioTranslationPage : Page
    {
        public AudioTranslationPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            if (Settings.Current.AUDIOTRANSLATION_INPUTDIRECTORY is string inputDirectory)
            {
                AudioTranslationInputDirectory.Description = inputDirectory;
            }
            if (Settings.Current.AUDIOTRANSLATION_OUTPUTDIRECTORY is string outputDirectory)
            {
                AudioTranslationOutputDirectory.Description = outputDirectory;
            }
            AudioTranslationProcessVideoToggleSwitch.IsOn = Settings.Current.AUDIOTRANSLATION_PROCESSVIDEO;
        }

        private async void AudioTranslationSelectInputDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFolder() is string selectedFolder)
            {
                Settings.Current.AUDIOTRANSLATION_INPUTDIRECTORY = selectedFolder;
                AudioTranslationInputDirectory.Description = selectedFolder;
            }
        }

        private async void AudioTranslationSelectOutputDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (await Tools.SelectFolder() is string selectedFolder)
            {
                Settings.Current.AUDIOTRANSLATION_OUTPUTDIRECTORY = selectedFolder;
                AudioTranslationOutputDirectory.Description = selectedFolder;
            }
        }

        private void AudioTranslationProcessVideoToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.AUDIOTRANSLATION_PROCESSVIDEO = AudioTranslationProcessVideoToggleSwitch.IsOn;
        }

    }

}
