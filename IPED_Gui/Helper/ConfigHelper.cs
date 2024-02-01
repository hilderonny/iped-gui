using IPED_Gui_WinForms.Data;
using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Helper
{
    internal class ConfigHelper
    {
        private static List<string> FlattenCategoryNamesToExport(Category category)
        {
            var result = new List<string>();
            if (category.Name != null && category.SettingsKey != null && (bool)Settings.Default[category.SettingsKey])
            {
                result.Add(category.Name);
            }
            if (category.SubCategories != null)
            {
                foreach (var subCategory in category.SubCategories)
                {
                    result.AddRange(FlattenCategoryNamesToExport(subCategory));
                }
            }
            return result;
        }

        private static string CreateCategoriesToExportTxt()
        {
            return string.Join("\n", FlattenCategoryNamesToExport(Category.Root));
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

        private static string CreateLocalConfig()
        {
            Settings settings = Settings.Default;
            return string.Join("\n", new List<string> {
                "locale = " + settings.LocalConfigLocale,
                "indexTemp = " + settings.LocalConfigIndexTemp.Replace("\\", "/"),
                "indexTempOnSSD = " + (settings.LocalConfigIndexTempOnSSD ? "true" : "false"),
                "outputOnSSD = " + (settings.LocalConfigOutputOnSSD ? "true" : "false"),
                "numThreads = " + settings.LocalConfigNumThreads,
                "hashesDB = " + settings.LocalConfigHashesDB.Replace("\\", "/"),
                "pluginFolder = " + Path.GetRelativePath(Path.GetDirectoryName(settings.SettingsIpedExePath) ?? "", settings.LocalConfigPluginFolder).Replace("\\", "/")
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
            File.WriteAllText(Path.Join(confDirectory, "CategoriesToExport.txt"), CreateCategoriesToExportTxt());
            File.WriteAllText(Path.Join(confDirectory, "ImageClassification.txt"), CreateImageClassificationTxt());

            ConfigType.WriteAllToDisk(profileDirectory);

        }

    }
}
