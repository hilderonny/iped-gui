using IPED_GUI_WinUI3.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace IPED_GUI_WinUI3.Pages
{

    public sealed partial class ProcessingPage : Page
    {

        Settings CurrentSettings { get; }

        public ProcessingPage()
        {
            InitializeComponent();
            Load();
            CurrentSettings = Settings.Current;
        }

        private void Load()
        {
            /*
            ProcessingEnableHashToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnablePhotoDNAToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableHashDBLookupToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnablePhotoDNALookupToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableLedDieToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableYahooNSFWDetectionToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableQRCodeToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingIgnoreDuplicatesToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingExportFilePropsToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingProcessFileSignaturesToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableFileParsingToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingExpandContainersToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingProcessEmbeddedDisksToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableRegexSearchToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableAutomaticExportFilesToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableLanguageDetectToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableNamedEntityRecognitonToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableGraphGenerationToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEntropyTestToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingIndexFileContentsToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableIndexToElasticSearchToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableMinIOToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableAudioTranscriptionToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableCarvingToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableLedCarvingToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableKnownMetCarvingToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableImageThumbsToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableImageSimilarityToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableFaceRecognitionToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableVideoThumbsToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableDocThumbsToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableHTMLReportToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableAudioTranslationToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            ProcessingEnableImageClassificationToggleSwitch.IsOn = Settings.Current.PROCESSING_ENABLEHASH;
            */
        }

        private void ProcessingEnableHashToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            //Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableHashToggleSwitch.IsOn;
        }

        private void ProcessingEnablePhotoDNAToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnablePhotoDNAToggleSwitch.IsOn;
        }

        private void ProcessingEnableHashDBLookupToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableHashDBLookupToggleSwitch.IsOn;
        }

        private void ProcessingEnablePhotoDNALookupToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnablePhotoDNALookupToggleSwitch.IsOn;
        }

        private void ProcessingEnableLedDieToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableLedDieToggleSwitch.IsOn;
        }

        private void ProcessingEnableYahooNSFWDetectionToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableYahooNSFWDetectionToggleSwitch.IsOn;
        }

        private void ProcessingEnableQRCodeToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableQRCodeToggleSwitch.IsOn;
        }

        private void ProcessingIgnoreDuplicatesToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingIgnoreDuplicatesToggleSwitch.IsOn;
        }

        private void ProcessingExportFilePropsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingExportFilePropsToggleSwitch.IsOn;
        }

        private void ProcessingProcessFileSignaturesToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingProcessFileSignaturesToggleSwitch.IsOn;
        }

        private void ProcessingEnableFileParsingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableFileParsingToggleSwitch.IsOn;
        }

        private void ProcessingExpandContainersToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingExpandContainersToggleSwitch.IsOn;
        }

        private void ProcessingProcessEmbeddedDisksToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingProcessEmbeddedDisksToggleSwitch.IsOn;
        }

        private void ProcessingEnableRegexSearchToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableRegexSearchToggleSwitch.IsOn;
        }

        private void ProcessingEnableAutomaticExportFilesToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableAutomaticExportFilesToggleSwitch.IsOn;
        }

        private void ProcessingEnableLanguageDetectToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableLanguageDetectToggleSwitch.IsOn;
        }

        private void ProcessingEnableNamedEntityRecognitonToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableNamedEntityRecognitonToggleSwitch.IsOn;
        }

        private void ProcessingEnableGraphGenerationToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableGraphGenerationToggleSwitch.IsOn;
        }

        private void ProcessingEntropyTestToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEntropyTestToggleSwitch.IsOn;
        }

        private void ProcessingIndexFileContentsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingIndexFileContentsToggleSwitch.IsOn;
        }

        private void ProcessingEnableIndexToElasticSearchToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableIndexToElasticSearchToggleSwitch.IsOn;
        }

        private void ProcessingEnableMinIOToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableMinIOToggleSwitch.IsOn;
        }

        private void ProcessingEnableAudioTranscriptionToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableAudioTranscriptionToggleSwitch.IsOn;
        }

        private void ProcessingEnableCarvingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableCarvingToggleSwitch.IsOn;
        }

        private void ProcessingEnableLedCarvingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableLedCarvingToggleSwitch.IsOn;
        }

        private void ProcessingEnableKnownMetCarvingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableKnownMetCarvingToggleSwitch.IsOn;
        }

        private void ProcessingEnableImageThumbsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableImageThumbsToggleSwitch.IsOn;
        }

        private void ProcessingEnableImageSimilarityToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableImageSimilarityToggleSwitch.IsOn;
        }

        private void ProcessingEnableFaceRecognitionToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableFaceRecognitionToggleSwitch.IsOn;
        }

        private void ProcessingEnableVideoThumbsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableVideoThumbsToggleSwitch.IsOn;
        }

        private void ProcessingEnableDocThumbsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableDocThumbsToggleSwitch.IsOn;
        }

        private void ProcessingEnableHTMLReportToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableHTMLReportToggleSwitch.IsOn;
        }

        private void ProcessingEnableAudioTranslationToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            //Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableAudioTranslationToggleSwitch.IsOn;
            //((Application.Current as App)?.m_window as MainWindow).UpdateAudioTranslationVisibility();
        }

        private void ProcessingEnableImageClassificationToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            //Settings.Current.PROCESSING_ENABLEHASH = ProcessingEnableImageClassificationToggleSwitch.IsOn;
        }
    }

}
