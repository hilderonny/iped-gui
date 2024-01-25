using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Helper
{
    public class ConfigType
    {

        public static void WriteAllToDisk(string profilePath)
        {
            FileSystemConfig.WriteToDisk(profilePath);
        }

        public static readonly ConfigType FileSystemConfig = new("conf/FileSystemConfig.txt", new ConfigElement[] {
            new("robustImageReading", "FileSystemConfigRobustImageReading", typeof(bool), "Uses auxiliary processes to read file contents in images. If Sleuthkit crashes, only the auxiliary processes are killed and restarted. Increases RAM usage often in about ~500MB per process. Increases up to 3x the processing speed of compressed E01 images, APFS containers or images in network."),
            new("numImageReaders", "FileSystemConfigNumImageReaders", typeof(string), "Number of auxiliary image reading processes. 'auto' uses 1/4 of the number of logical CPU cores. You can decrease the value if it uses too much RAM. Increasing the value is not efficient, because often IO devices can not handle many reading requests simultaneously."),
            new("addUnallocated", "FileSystemConfigAddUnallocated", typeof(bool), "Add and process unallocated areas of images."),
            new("addFileSlacks", "FileSystemConfigAddFileSlacks", typeof(bool), "Add and process file slacks."),
            new("minOrphanSizeToIgnore", "FileSystemConfigMinOrphanSizeToIgnore", typeof(string), "Ignore orphan files bigger than this value in bytes. Default -1 means disabled. In rare cases, Sleuthkit can recover thousands of large corrupted orphan files pointing to the same disk areas, making the processing not feasible."),
            new("unallocatedFragSize", "FileSystemConfigUnallocatedFragSize", typeof(string), "Size in bytes of the unallocated space segments. In cases where the carving of videos is important, it may be useful to increase this value to minimize missing items that cross segment boundaries, but processing may take longer if this value is too large."),
            new("ignoreHardLinks", "FileSystemConfigIgnoreHardLinks", typeof(bool), "Ignores HFS+ hard links pointing to items already processed. The hard links are added to the case, but their content is not processed (indexed, expanded, carved, etc). Optimizes HFS+ image processing containing millions of hard links (such as Time Machine volumes)."),
            new("skipFolderRegex", "FileSystemConfigSkipFolderRegex", typeof(string), "Regex pattern to skip matched folder trees when processing. Just works if processing mounted folders currently. Matched folders are ignored and not included in case.")
        });

        public readonly string FilePath;
        public readonly ConfigElement[] ConfigElements;

        public ConfigType(string filePath, ConfigElement[] configElements)
        {
            FilePath = filePath;
            ConfigElements = configElements;
        }

        private void WriteToDisk(string profilePath)
        {
            var lines = new List<string>();
            foreach (var configElement in ConfigElements)
            {
                var line = configElement.ElementName + " = ";
                if (configElement.ElementType == typeof(bool))
                {
                    line += (bool)Settings.Default[configElement.SettingsName] ? "true" : "false";
                }
                else
                {
                    line += Settings.Default[configElement.SettingsName].ToString();
                }
                lines.Add(line);
            }
            File.WriteAllText(Path.Join(profilePath, FilePath), string.Join("\n", lines));
        }

    }

    public class ConfigElement
    {
        public readonly string ElementName;
        public readonly string SettingsName;
        public readonly Type ElementType;
        public readonly string Description;

        public ConfigElement(string elementName, string settingsName, Type elementType, string description)
        {
            ElementName = elementName;
            SettingsName = settingsName;
            ElementType = elementType;
            Description = description;
        }
    }
}
