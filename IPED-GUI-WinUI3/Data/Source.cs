using System.Collections.ObjectModel;
using System.Windows.Input;

namespace IPED_GUI_WinUI3.Data
{
    internal class Source
    {

        public string Path { get; }
        public string Name { get; set; }

        public Source(string path, string name)
        {
            Path = path;
            Name = name;
        }

        public static ObservableCollection<Source> Sources { get; set; } = new();

    }
}
