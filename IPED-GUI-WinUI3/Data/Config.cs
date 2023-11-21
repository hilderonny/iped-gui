using Windows.Storage;

namespace IPED_GUI_WinUI3.Data
{
    internal class Config
    {

        public static string OutputDirectory
        {
            get
            {
                var outputDirectory = ApplicationData.Current.LocalSettings.Values["OutputDirectory"];
                return outputDirectory != null ? (string)outputDirectory : null;
            }
            set
            {
                ApplicationData.Current.LocalSettings.Values["OutputDirectory"] = value;
            }
        }
        public static bool Append
        {
            get
            {
                var append = ApplicationData.Current.LocalSettings.Values["Append"];
                return append != null ? (bool)append : false;
            }
            set
            {
                ApplicationData.Current.LocalSettings.Values["Append"] = value;
            }
        }
        public static bool Continue
        {
            get
            {
                var append = ApplicationData.Current.LocalSettings.Values["Continue"];
                return append != null ? (bool)append : false;
            }
            set
            {
                ApplicationData.Current.LocalSettings.Values["Continue"] = value;
            }
        }
        public static bool Portable
        {
            get
            {
                var append = ApplicationData.Current.LocalSettings.Values["Portable"];
                return append != null ? (bool)append : false;
            }
            set
            {
                ApplicationData.Current.LocalSettings.Values["Portable"] = value;
            }
        }
        public static bool DownloadInternetData
        {
            get
            {
                var append = ApplicationData.Current.LocalSettings.Values["DownloadInternetData"];
                return append != null ? (bool)append : false;
            }
            set
            {
                ApplicationData.Current.LocalSettings.Values["DownloadInternetData"] = value;
            }
        }

    }
}
