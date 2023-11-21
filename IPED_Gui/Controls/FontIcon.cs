namespace IPED_Gui_WinForms.Controls
{
    public class FontIcon : Label
    {
        private int glyph;

        public int Glyph { 
            get { return glyph; } 
            set { 
                glyph = value;
                if (glyph > 0)
                {
                    Text = char.ConvertFromUtf32(glyph);
                }
                Invalidate();
            }
        }
    }
}
