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
            CurrentSettings = Settings.Current;
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            ProcessingEnableHashToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEHASH;
            ProcessingEnablePhotoDNAToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEPHOTODNA;
            ProcessingEnableHashDBLookupToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEHASHDBLOOKUP;
            ProcessingEnablePhotoDNALookupToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEPHOTODNALOOKUP;
            ProcessingEnableLedDieToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLELEDDIE;
            ProcessingEnableYahooNSFWDetectionToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEYAHOONSFWDETECTION;
            ProcessingEnableQRCodeToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEQRCODE;
            ProcessingIgnoreDuplicatesToggleSwitch.IsOn = CurrentSettings.PROCESSING_IGNOREDUPLICATES;
            ProcessingExportFilePropsToggleSwitch.IsOn = CurrentSettings.PROCESSING_EXPORTFILEPROPS;
            ProcessingProcessFileSignaturesToggleSwitch.IsOn = CurrentSettings.PROCESSING_PROCESSFILESIGNATURES;
            ProcessingEnableFileParsingToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEFILEPARSING;
            ProcessingExpandContainersToggleSwitch.IsOn = CurrentSettings.PROCESSING_EXPANDCONTAINERS;
            ProcessingProcessEmbeddedDisksToggleSwitch.IsOn = CurrentSettings.PROCESSING_PROCESSEMBEDDEDDISKS;
            ProcessingEnableRegexSearchToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEREGEXSEARCH;
            ProcessingEnableAutomaticExportFilesToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEAUTOMATICEXPORTFILES;
            ProcessingEnableLanguageDetectToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLELANGUAGEDETECT;
            ProcessingEnableNamedEntityRecognitonToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLENAMEDENTITYRECOGNITON;
            ProcessingEnableGraphGenerationToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEGRAPHGENERATION;
            ProcessingEntropyTestToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENTROPYTEST;
            ProcessingIndexFileContentsToggleSwitch.IsOn = CurrentSettings.PROCESSING_INDEXFILECONTENTS;
            ProcessingEnableIndexToElasticSearchToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEINDEXTOELASTICSEARCH;
            ProcessingEnableMinIOToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEMINIO;
            ProcessingEnableAudioTranscriptionToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEAUDIOTRANSCRIPTION;
            ProcessingEnableCarvingToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLECARVING;
            ProcessingEnableLedCarvingToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLELEDCARVING;
            ProcessingEnableKnownMetCarvingToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEKNOWNMETCARVING;
            ProcessingEnableImageThumbsToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEIMAGETHUMBS;
            ProcessingEnableImageSimilarityToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEIMAGESIMILARITY;
            ProcessingEnableFaceRecognitionToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEFACERECOGNITION;
            ProcessingEnableVideoThumbsToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEVIDEOTHUMBS;
            ProcessingEnableDocThumbsToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEDOCTHUMBS;
            ProcessingEnableHTMLReportToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEHTMLREPORT;
            ProcessingEnableAudioTranslationToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEAUDIOTRANSLATION;
            ProcessingEnableImageClassificationToggleSwitch.IsOn = CurrentSettings.PROCESSING_ENABLEIMAGECLASSIFICATION;
        }

        private void ProcessingEnableHashToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEHASH = ProcessingEnableHashToggleSwitch.IsOn;
        }

        private void ProcessingEnablePhotoDNAToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEPHOTODNA = ProcessingEnablePhotoDNAToggleSwitch.IsOn;
        }

        private void ProcessingEnableHashDBLookupToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEHASHDBLOOKUP = ProcessingEnableHashDBLookupToggleSwitch.IsOn;
        }

        private void ProcessingEnablePhotoDNALookupToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEPHOTODNALOOKUP = ProcessingEnablePhotoDNALookupToggleSwitch.IsOn;
        }

        private void ProcessingEnableLedDieToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLELEDDIE = ProcessingEnableLedDieToggleSwitch.IsOn;
        }

        private void ProcessingEnableYahooNSFWDetectionToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEYAHOONSFWDETECTION = ProcessingEnableYahooNSFWDetectionToggleSwitch.IsOn;
        }

        private void ProcessingEnableQRCodeToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEQRCODE = ProcessingEnableQRCodeToggleSwitch.IsOn;
        }

        private void ProcessingIgnoreDuplicatesToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_IGNOREDUPLICATES = ProcessingIgnoreDuplicatesToggleSwitch.IsOn;
        }

        private void ProcessingExportFilePropsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_EXPORTFILEPROPS = ProcessingExportFilePropsToggleSwitch.IsOn;
        }

        private void ProcessingProcessFileSignaturesToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_PROCESSFILESIGNATURES = ProcessingProcessFileSignaturesToggleSwitch.IsOn;
        }

        private void ProcessingEnableFileParsingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEFILEPARSING = ProcessingEnableFileParsingToggleSwitch.IsOn;
        }

        private void ProcessingExpandContainersToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_EXPANDCONTAINERS = ProcessingExpandContainersToggleSwitch.IsOn;
        }

        private void ProcessingProcessEmbeddedDisksToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_PROCESSEMBEDDEDDISKS = ProcessingProcessEmbeddedDisksToggleSwitch.IsOn;
        }

        private void ProcessingEnableRegexSearchToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEREGEXSEARCH = ProcessingEnableRegexSearchToggleSwitch.IsOn;
        }

        private void ProcessingEnableAutomaticExportFilesToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEAUTOMATICEXPORTFILES = ProcessingEnableAutomaticExportFilesToggleSwitch.IsOn;
        }

        private void ProcessingEnableLanguageDetectToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLELANGUAGEDETECT = ProcessingEnableLanguageDetectToggleSwitch.IsOn;
        }

        private void ProcessingEnableNamedEntityRecognitonToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLENAMEDENTITYRECOGNITON = ProcessingEnableNamedEntityRecognitonToggleSwitch.IsOn;
        }

        private void ProcessingEnableGraphGenerationToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEGRAPHGENERATION = ProcessingEnableGraphGenerationToggleSwitch.IsOn;
        }

        private void ProcessingEntropyTestToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENTROPYTEST = ProcessingEntropyTestToggleSwitch.IsOn;
        }

        private void ProcessingIndexFileContentsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_INDEXFILECONTENTS = ProcessingIndexFileContentsToggleSwitch.IsOn;
        }

        private void ProcessingEnableIndexToElasticSearchToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEINDEXTOELASTICSEARCH = ProcessingEnableIndexToElasticSearchToggleSwitch.IsOn;
        }

        private void ProcessingEnableMinIOToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEMINIO = ProcessingEnableMinIOToggleSwitch.IsOn;
        }

        private void ProcessingEnableAudioTranscriptionToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEAUDIOTRANSCRIPTION = ProcessingEnableAudioTranscriptionToggleSwitch.IsOn;
        }

        private void ProcessingEnableCarvingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLECARVING = ProcessingEnableCarvingToggleSwitch.IsOn;
        }

        private void ProcessingEnableLedCarvingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLELEDCARVING = ProcessingEnableLedCarvingToggleSwitch.IsOn;
        }

        private void ProcessingEnableKnownMetCarvingToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEKNOWNMETCARVING = ProcessingEnableKnownMetCarvingToggleSwitch.IsOn;
        }

        private void ProcessingEnableImageThumbsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEIMAGETHUMBS = ProcessingEnableImageThumbsToggleSwitch.IsOn;
        }

        private void ProcessingEnableImageSimilarityToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEIMAGESIMILARITY = ProcessingEnableImageSimilarityToggleSwitch.IsOn;
        }

        private void ProcessingEnableFaceRecognitionToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEFACERECOGNITION = ProcessingEnableFaceRecognitionToggleSwitch.IsOn;
        }

        private void ProcessingEnableVideoThumbsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEVIDEOTHUMBS = ProcessingEnableVideoThumbsToggleSwitch.IsOn;
        }

        private void ProcessingEnableDocThumbsToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEDOCTHUMBS = ProcessingEnableDocThumbsToggleSwitch.IsOn;
        }

        private void ProcessingEnableHTMLReportToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEHTMLREPORT = ProcessingEnableHTMLReportToggleSwitch.IsOn;
        }

        private void ProcessingEnableAudioTranslationToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEAUDIOTRANSLATION = ProcessingEnableAudioTranslationToggleSwitch.IsOn;
            ((Application.Current as App)?.m_window as MainWindow).UpdateAudioTranslationVisibility();
        }

        private void ProcessingEnableImageClassificationToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            CurrentSettings.PROCESSING_ENABLEIMAGECLASSIFICATION = ProcessingEnableImageClassificationToggleSwitch.IsOn;
        }
    }

}
