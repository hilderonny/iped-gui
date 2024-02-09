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

        private static string? CreateRegexConfigTxt()
        {
            var searchTermFilePath = Settings.Default.GeneralSearchTermFilePath;
            if (string.IsNullOrEmpty(searchTermFilePath))
            {
                return null;
            }
            var lines = File.ReadLines(searchTermFilePath);
            var regex = $"SEARCHTERMS, true = \\b({string.Join("|", lines)})\\b";
            return regex;
        }

        internal static void WriteProfileToDisk(string profileName)
        {
            Settings settings = Settings.Default;
            var ipedDirectory = Path.GetDirectoryName(settings.SettingsIpedExePath);
            var profileDirectory = Path.Join(ipedDirectory, "profiles", profileName);
            var confDirectory = Path.Join(profileDirectory, "conf");
            Directory.CreateDirectory(confDirectory);

            ConfigType.WriteAllToDisk(profileDirectory);

            File.WriteAllText(Path.Join(confDirectory, "CategoriesToExport.txt"), CreateCategoriesToExportTxt());
            var regexConfig = CreateRegexConfigTxt();
            if (regexConfig != null)
            {
                File.WriteAllText(Path.Join(confDirectory, "RegexConfig.txt"), CreateRegexConfigTxt());
            }
        }

    }
}
