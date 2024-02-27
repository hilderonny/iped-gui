namespace IPED_Gui_WinForms.Controls
{
    public class VerticalTableLayoutPanel : TableLayoutPanel
    {

        public VerticalTableLayoutPanel()
        {
            AutoScroll = true;
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            RowCount = 1;
            RowStyles.Add(new RowStyle());
        }

        public void AddControl(Control control)
        {
            RowCount++;
            RowStyles.Add(new RowStyle());
            Controls.Add(control, 0, RowCount - 2);
        }

    }
}
