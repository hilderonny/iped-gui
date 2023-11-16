using System.Collections.Generic;

namespace IPED_GUI_WinUI3.Helpers
{
    internal class Dictionaries
    {
        public static Dictionary<string, string> Languages { get; } = new()
        {
            { "en", "en" },
            { "pt-BR", "pt-BR" },
            { "it-IT", "it-IT" },
            { "de-DE", "de-DE" },
            { "es-AR", "es-AR" }
        };
    }
}
