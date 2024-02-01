using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Data
{
    public class Category
    {

        public readonly static Category Root = new()
        {
            SubCategories = new List<Category>
            {
                new() { Name = "Documents", Icon = Resources.Documents, SettingsKey = "CategoriesToExportDocuments", SubCategories = new List<Category>
                {
                    new() { Name = "RTF Documents", Icon = Resources.RTF_Documents, SettingsKey = "CategoriesToExportRTFDocuments" },
                    new() { Name = "PDF Documents", Icon = Resources.PDF_Documents, SettingsKey = "CategoriesToExportPDFDocuments" }
                }},
                new() { Name = "XML Files", Icon = Resources.XML_Files, SettingsKey = "CategoriesToExportXMLFiles" }
            }
        };

        public string? Name { get; set; }
        public Bitmap? Icon { get; set; }
        public string? SettingsKey { get; set; }
        public List<Category>? SubCategories { get; set; }

    }
}
