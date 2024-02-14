namespace IPED_Gui_WinForms.Controls
{
    public class VerticalTableLayoutPanel : TableLayoutPanel
    {

        public VerticalTableLayoutPanel()
        {
            AutoScroll = true;
            BackColor = Color.Transparent;
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }

        public void AddControl(Control control)
        {
            RowCount++;
            RowStyles.Insert(RowCount - 2, new RowStyle(SizeType.AutoSize));
            Controls.Add(control, 0, RowCount - 2);
        }

    }
}
