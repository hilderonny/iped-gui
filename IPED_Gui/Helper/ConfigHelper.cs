using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Helper
{
    internal class ConfigHelper
    {

        private static string CreateIPEDConfig()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "enableHash = true",
                "enablePhotoDNA = false",
                "enableHashDBLookup = true",
                "enablePhotoDNALookup = false",
                "enableLedDie = true",
                "enableYahooNSFWDetection = false",
                "enableQRCode = true",
                "ignoreDuplicates = false",
                "exportFileProps = false",
                "processFileSignatures = true",
                "enableFileParsing = true",
                "expandContainers = true",
                "processEmbeddedDisks = true",
                "enableRegexSearch = true",
                "enableAutomaticExportFiles = true",
                "enableLanguageDetect = true",
                "enableNamedEntityRecogniton = false",
                "enableGraphGeneration = " + (settings.SettingsEnableGraphGeneration ? "true" : "false"),
                "entropyTest = true",
                "indexFileContents = true",
                "enableIndexToElasticSearch = false",
                "enableMinIO = false",
                "enableAudioTranscription = false",
                "enableCarving = " + (settings.SettingsEnableCarving ? "true" : "false"),
                "enableLedCarving = false",
                "enableKnownMetCarving = false",
                "enableImageThumbs = true",
                "enableImageSimilarity = true",
                "enableFaceRecognition = " + (settings.SettingsEnableFaceRecognition ? "true" : "false"),
                "enableVideoThumbs = true",
                "enableDocThumbs = true",
                "enableHTMLReport = true",
                "enableAudioTranslation = " + (settings.IPEDConfigEnableAudioTranslation ? "true" : "false"),
                "enableTextTranslation = false",
                "enableImageClassification = " + (settings.IPEDConfigEnableImageClassification ? "true" : "false")
            });
        }

        private static string CreateLocalConfig()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "locale = " + settings.SettingsLocale,
                "indexTemp = " + settings.SettingsIndexTemp.Replace("\\", "/"),
                "indexTempOnSSD = " + (settings.SettingsIndexTempOnSSD ? "true" : "false"),
                "outputOnSSD = " + (settings.SettingsOutputOnSSD ? "true" : "false"),
                "numThreads = " + settings.SettingsNumThreads,
                "hashesDB = " + settings.SettingsHashesDB.Replace("\\", "/"),
                "pluginFolder = " + Path.GetRelativePath(Path.GetDirectoryName(settings.SettingsIpedExePath) ?? "", settings.SettingsPluginFolder).Replace("\\", "/")
            });
        }

        private static string CreateAudioTranslationTxt()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "inputDirectory = " + settings.AudioTranslationInputDirectory,
                "outputDirectory = " + settings.AudioTranslationOutputDirectory,
                "processVideo = " + (settings.AudioTranslationProcessVideo ? "true" : "false")
            });
        }

        private static string CreateImageClassificationTxt()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "inputDirectory = " + settings.ImageClassificationInputDirectory,
                "outputDirectory = " + settings.ImageClassificationOutputDirectory
            });
        }

        private static string CreateFileSystemConfigTxt()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "robustImageReading = false",
                "numImageReaders = auto",
                "addUnallocated = " + (settings.FileSystemConfigAddUnallocated ? "true" : "false"),
                "addFileSlacks = false",
                "minOrphanSizeToIgnore = -1",
                "unallocatedFragSize = 1073741824",
                "ignoreHardLinks = true",
                "skipFolderRegex ="
            });
        }

        internal static void WriteProfileToDisk(string profileName)
        {
            Settings settings = Settings.Default;
            var ipedDirectory = Path.GetDirectoryName(settings.SettingsIpedExePath);
            var profileDirectory = Path.Join(ipedDirectory, "profiles", profileName);
            var confDirectory = Path.Join(profileDirectory, "conf");
            Directory.CreateDirectory(confDirectory);

            File.WriteAllText(Path.Join(profileDirectory, "IPEDConfig.txt"), CreateIPEDConfig());
            File.WriteAllText(Path.Join(profileDirectory, "LocalConfig.txt"), CreateLocalConfig());

            File.WriteAllText(Path.Join(confDirectory, "AudioTranslation.txt"), CreateAudioTranslationTxt());
            File.WriteAllText(Path.Join(confDirectory, "ImageClassification.txt"), CreateImageClassificationTxt());
            File.WriteAllText(Path.Join(confDirectory, "FileSystemConfig.txt"), CreateFileSystemConfigTxt());
        }

    }
}
