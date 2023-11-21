
using System.Drawing.Drawing2D;

namespace IPED_Gui_WinForms.Controls
{
    public partial class RoundBorderControl : UserControl
    {
        private int borderRadius, borderDiameter;
        private Color borderColor;

        public int BorderRadius { get { return borderRadius; } set { borderRadius = value; borderDiameter = borderRadius * 2; Invalidate(); } }

        public Color BorderColor { get { return borderColor; } set { borderColor = value; Invalidate(); } }

        public RoundBorderControl()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new();
            path.StartFigure();
            if (borderRadius > 0) path.AddArc(new Rectangle(0, 0, borderDiameter, borderDiameter), 180, 90);
            path.AddLine(borderDiameter, 0, Width - borderDiameter - 1, 0);
            if (borderRadius > 0) path.AddArc(new Rectangle(Width - borderDiameter - 1, 0, borderDiameter, borderDiameter), 270, 90);
            path.AddLine(Width - 1, borderDiameter, Width - 1, Height - borderDiameter - 1);
            if (borderRadius > 0) path.AddArc(new Rectangle(Width - borderDiameter - 1, Height - borderDiameter - 1, borderDiameter, borderDiameter), 0, 90);
            path.AddLine(Width - borderDiameter - 1, Height - 1, borderDiameter, Height - 1);
            if (borderRadius > 0) path.AddArc(new Rectangle(0, Height - borderDiameter - 1, borderDiameter, borderDiameter), 90, 90);
            path.AddLine(0, Height - borderDiameter - 1, 0, borderDiameter);
            path.CloseFigure();
            e.Graphics.DrawPath(new Pen(borderColor), path);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var bounds = ClientRectangle;
            Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top, bounds.Right + 1, bounds.Bottom + 1, borderDiameter, borderDiameter));
            Invalidate();
        }
    }
}
