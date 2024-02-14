
using System.Drawing.Drawing2D;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class ContentPanel : TableLayoutPanel
    {
        private readonly Label titleLabel;
        private readonly Panel scrollPanel;

        public Color BorderColor { get; set; }
        public int CornerRadius { get; set; }
        public string? Title { get => titleLabel.Text; set => titleLabel.Text = value; }

        public Control? ContentControl { get => scrollPanel.Controls[0]; set {
                scrollPanel.SuspendLayout();
                scrollPanel.Controls.Clear();
                if (value != null) scrollPanel.Controls.Add(value);
                scrollPanel.ResumeLayout();
            } }

        public ContentPanel()
        {
            titleLabel = new Label
            {
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.Black,
                Margin = Padding.Empty,
                Padding = new Padding(56, 44, 0, 0),
            };

            scrollPanel = new Panel
            {
                AutoScroll = true,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.Black,
                Margin = Padding.Empty,
                Padding = new Padding(56, 0, 0, 0),
            };

            BackColor = Color.White;
            BorderColor = Color.FromArgb(30, Color.Black);
            ColumnCount = 1;
            CornerRadius = 7;
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            ForeColor = Color.White;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            ResizeRedraw = true;
            RowCount = 2;
            RowStyles.Add(new RowStyle(SizeType.Absolute, 110));
            RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(titleLabel, 0, 0);
            Controls.Add(scrollPanel, 0, 1);
        }

    }
}
