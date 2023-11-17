using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Settings
    {
        public string SETTINGS_IPEDEXEPATH = null;
        public string SETTINGS_LOCALE = "de-DE";
        public string SETTINGS_INDEXTEMP = null;
        public bool SETTINGS_INDEXTEMPONSSD = false;
        public bool SETTINGS_OUTPUTONSSD = false;
        public string SETTINGS_NUMTHREADS = "default";
        public string SETTINGS_HASHESDB = null;
        public string SETTINGS_PLUGINFOLDER = null;

        public bool PROCESSING_ENABLEHASH = false;
        public bool PROCESSING_ENABLEPHOTODNA = false;
        public bool PROCESSING_ENABLEHASHDBLOOKUP = false;
        public bool PROCESSING_ENABLEPHOTODNALOOKUP = false;
        public bool PROCESSING_ENABLELEDDIE = false;
        public bool PROCESSING_ENABLEYAHOONSFWDETECTION = false;
        public bool PROCESSING_ENABLEQRCODE = false;
        public bool PROCESSING_IGNOREDUPLICATES = false;
        public bool PROCESSING_EXPORTFILEPROPS = false;
        public bool PROCESSING_PROCESSFILESIGNATURES = false;
        public bool PROCESSING_ENABLEFILEPARSING = false;
        public bool PROCESSING_EXPANDCONTAINERS = false;
        public bool PROCESSING_PROCESSEMBEDDEDDISKS = false;
        public bool PROCESSING_ENABLEREGEXSEARCH = false;
        public bool PROCESSING_ENABLEAUTOMATICEXPORTFILES = false;
        public bool PROCESSING_ENABLELANGUAGEDETECT = false;
        public bool PROCESSING_ENABLENAMEDENTITYRECOGNITON = false;
        public bool PROCESSING_ENABLEGRAPHGENERATION = false;
        public bool PROCESSING_ENTROPYTEST = false;
        public bool PROCESSING_INDEXFILECONTENTS = false;
        public bool PROCESSING_ENABLEINDEXTOELASTICSEARCH = false;
        public bool PROCESSING_ENABLEMINIO = false;
        public bool PROCESSING_ENABLEAUDIOTRANSCRIPTION = false;
        public bool PROCESSING_ENABLECARVING = false;
        public bool PROCESSING_ENABLELEDCARVING = false;
        public bool PROCESSING_ENABLEKNOWNMETCARVING = false;
        public bool PROCESSING_ENABLEIMAGETHUMBS = false;
        public bool PROCESSING_ENABLEIMAGESIMILARITY = false;
        public bool PROCESSING_ENABLEFACERECOGNITION = false;
        public bool PROCESSING_ENABLEVIDEOTHUMBS = false;
        public bool PROCESSING_ENABLEDOCTHUMBS = false;
        public bool PROCESSING_ENABLEHTMLREPORT = false;
        public bool PROCESSING_ENABLEAUDIOTRANSLATION = false;
        public bool PROCESSING_ENABLEIMAGECLASSIFICATION = false;

        public string AUDIOTRANSLATION_INPUTDIRECTORY = null;
        public string AUDIOTRANSLATION_OUTPUTDIRECTORY = null;
        public bool AUDIOTRANSLATION_PROCESSVIDEO = false;

        public static Settings Current { get; private set; }

        public string FilePath;

        // Create empty settings
        public static void Create()
        {
            Current = new();
        }

        // Load settings from file
        public static void LoadFromFile(string filePath)
        {
            Current = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(filePath));
            Current.FilePath = filePath;
        }

        // Save settings to file
        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(this));
            FilePath = filePath;
        }

        // Creates an "ipedguio" profile directory structure which is uses when starting IPED
        public void CreateProfile()
        {
            string ipedDirectory = Path.GetDirectoryName(SETTINGS_IPEDEXEPATH);
            string profileDirectory = Path.Join(ipedDirectory, "profiles", "ipedgui");
            string configDirectory = Path.Join(profileDirectory, "conf");
            Directory.CreateDirectory(configDirectory);
            CreateLocalConfig(Path.Join(profileDirectory, "LocalConfig.txt"));
            CreateIPEDConfig(Path.Join(profileDirectory, "IPEDConfig.txt"));
            CreateAudioTranslationConfig(Path.Join(configDirectory, "AudioTranslation.txt"));
        }

        private void CreateLocalConfig(string filePath)
        {
            File.WriteAllText(filePath, string.Join(System.Environment.NewLine, new List<string>() {
                $"locale = {SETTINGS_LOCALE}",
                $"indexTemp = {SETTINGS_INDEXTEMP}",
                $"indexTempOnSSD = {(SETTINGS_INDEXTEMPONSSD ? "true" : "false")}",
                $"outputOnSSD = {(SETTINGS_OUTPUTONSSD ? "true" : "false")}",
                $"numThreads = {SETTINGS_NUMTHREADS}",
                $"hashesDB = {SETTINGS_HASHESDB}",
                $"pluginFolder = {SETTINGS_PLUGINFOLDER}"
            }));
        }

        private void CreateIPEDConfig(string filePath)
        {
            File.WriteAllText(filePath, string.Join(System.Environment.NewLine, new List<string>() {
                $"enableHash = {(PROCESSING_ENABLEHASH ? "true" : "false")}",
                $"enablePhotoDNA = {(PROCESSING_ENABLEPHOTODNA ? "true" : "false")}",
                $"enableHashDBLookup = {(PROCESSING_ENABLEHASHDBLOOKUP ? "true" : "false")}",
                $"enablePhotoDNALookup = {(PROCESSING_ENABLEPHOTODNALOOKUP ? "true" : "false")}",
                $"enableLedDie = {(PROCESSING_ENABLELEDDIE ? "true" : "false")}",
                $"enableYahooNSFWDetection = {(PROCESSING_ENABLEYAHOONSFWDETECTION ? "true" : "false")}",
                $"enableQRCode = {(PROCESSING_ENABLEQRCODE ? "true" : "false")}",
                $"ignoreDuplicates = {(PROCESSING_IGNOREDUPLICATES ? "true" : "false")}",
                $"exportFileProps = {(PROCESSING_EXPORTFILEPROPS ? "true" : "false")}",
                $"processFileSignatures = {(PROCESSING_PROCESSFILESIGNATURES ? "true" : "false")}",
                $"enableFileParsing = {(PROCESSING_ENABLEFILEPARSING ? "true" : "false")}",
                $"expandContainers = {(PROCESSING_EXPANDCONTAINERS ? "true" : "false")}",
                $"processEmbeddedDisks = {(PROCESSING_PROCESSEMBEDDEDDISKS ? "true" : "false")}",
                $"enableRegexSearch = {(PROCESSING_ENABLEREGEXSEARCH ? "true" : "false")}",
                $"enableAutomaticExportFiles = {(PROCESSING_ENABLEAUTOMATICEXPORTFILES ? "true" : "false")}",
                $"enableLanguageDetect = {(PROCESSING_ENABLELANGUAGEDETECT ? "true" : "false")}",
                $"enableNamedEntityRecogniton = {(PROCESSING_ENABLENAMEDENTITYRECOGNITON ? "true" : "false")}",
                $"enableGraphGeneration = {(PROCESSING_ENABLEGRAPHGENERATION ? "true" : "false")}",
                $"entropyTest = {(PROCESSING_ENTROPYTEST ? "true" : "false")}",
                $"indexFileContents = {(PROCESSING_INDEXFILECONTENTS ? "true" : "false")}",
                $"enableIndexToElasticSearch = {(PROCESSING_ENABLEINDEXTOELASTICSEARCH ? "true" : "false")}",
                $"enableMinIO = {(PROCESSING_ENABLEMINIO ? "true" : "false")}",
                $"enableAudioTranscription = {(PROCESSING_ENABLEAUDIOTRANSCRIPTION ? "true" : "false")}",
                $"enableCarving = {(PROCESSING_ENABLECARVING ? "true" : "false")}",
                $"enableLedCarving = {(PROCESSING_ENABLELEDCARVING ? "true" : "false")}",
                $"enableKnownMetCarving = {(PROCESSING_ENABLEKNOWNMETCARVING ? "true" : "false")}",
                $"enableImageThumbs = {(PROCESSING_ENABLEIMAGETHUMBS ? "true" : "false")}",
                $"enableImageSimilarity = {(PROCESSING_ENABLEIMAGESIMILARITY ? "true" : "false")}",
                $"enableFaceRecognition = {(PROCESSING_ENABLEFACERECOGNITION ? "true" : "false")}",
                $"enableVideoThumbs = {(PROCESSING_ENABLEVIDEOTHUMBS ? "true" : "false")}",
                $"enableDocThumbs = {(PROCESSING_ENABLEDOCTHUMBS ? "true" : "false")}",
                $"enableHTMLReport = {(PROCESSING_ENABLEHTMLREPORT ? "true" : "false")}",
                $"enableAudioTranslation = {(PROCESSING_ENABLEAUDIOTRANSLATION ? "true" : "false")}",
                $"enableImageClassification = {(PROCESSING_ENABLEIMAGECLASSIFICATION ? "true" : "false")}"
            }));
        }

        private void CreateAudioTranslationConfig(string filePath)
        {
            File.WriteAllText(filePath, string.Join(System.Environment.NewLine, new List<string>() {
                $"inputDirectory = {AUDIOTRANSLATION_INPUTDIRECTORY}",
                $"outputDirectory = {AUDIOTRANSLATION_OUTPUTDIRECTORY}",
                $"processVideo = {(AUDIOTRANSLATION_PROCESSVIDEO ? "true" : "false")}"
            }));
        }

    }
}
