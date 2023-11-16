using Newtonsoft.Json;
using System.IO;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Settings
    {
        public string SETTINGS_IPEDEXEPATH;
        public string SETTINGS_LOCALE;


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

    }
}
