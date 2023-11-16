using Newtonsoft.Json;
using System.IO;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Settings
    {

        public string SETTINGS_IPEDEXEPATH;
        public string SETTINGS_LOCALE;

        public static Settings LoadFromFile(string filePath)
        {
            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(filePath));
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(this));
        }

    }
}
