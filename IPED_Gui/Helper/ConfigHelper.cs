using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Helper
{
    internal class ConfigHelper
    {

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

        internal static void WriteProfileToDisk(string profileName)
        {
            Settings settings = Settings.Default;
            var ipedDirectory = Path.GetDirectoryName(settings.SettingsIpedExePath);
            var profileDirectory = Path.Join(ipedDirectory, "profiles", profileName);
            var confDirectory = Path.Join(profileDirectory, "conf");
            Directory.CreateDirectory(confDirectory);

            File.WriteAllText(Path.Join(profileDirectory, "LocalConfig.txt"), CreateLocalConfig());

            File.WriteAllText(Path.Join(confDirectory, "AudioTranslation.txt"), CreateAudioTranslationTxt());
            File.WriteAllText(Path.Join(confDirectory, "ImageClassification.txt"), CreateImageClassificationTxt());

            ConfigType.WriteAllToDisk(profileDirectory);

        }

    }
}
