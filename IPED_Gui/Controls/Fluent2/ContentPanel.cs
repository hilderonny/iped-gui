
using System.Drawing.Drawing2D;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class ContentPanel : UserControl
    {
        public Color BorderColor { get; set; }
        public int CornerRadius { get; set; }

        public ContentPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            BorderColor = Color.FromArgb(30, Color.Black);
            CornerRadius = 7;
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            ForeColor = Color.White;
            Margin = Padding.Empty;
            Padding = new Padding(56, 44, 56, 44);
            ResizeRedraw = true;

            ResumeLayout();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            var cornerDiameter = CornerRadius * 2;

            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(0, 0, cornerDiameter, cornerDiameter, 180, 90);
            path.AddLine(CornerRadius, 0, Width, 0);
            path.AddLine(Width, 0, Width, Height);
            path.AddLine(Width, Height, 0, Height);
            path.AddLine(0, Height, 0, CornerRadius);
            path.CloseFigure();
            e.Graphics.FillPath(new SolidBrush(ForeColor), path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(new Pen(BorderColor), path);
        }
    }
}
