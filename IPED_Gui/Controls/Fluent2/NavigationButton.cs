using System.Drawing.Drawing2D;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationButton : TableLayoutPanel
    {

        private readonly Label iconLabel;
        private readonly Label textLabel;
        private Color originalBackColor = Color.Transparent;
        private bool isHovered = false;

        public enum ButtonType
        {
            IconOnly,
            IconAndText
        }

        public Color HoverColor { get; set; }
        public Color SelectedColor { get; set; }
        public int CornerRadius { get; set; }
        public bool Selected { get; set; }
        public new string? Text { get => textLabel.Text; set => textLabel.Text = value; }
        public ButtonType Type { get; set; }
        public override Color BackColor { get => originalBackColor; set {
                originalBackColor = value;
                iconLabel.BackColor = value;
                textLabel.BackColor = value;
        } }
        public new event EventHandler? Click;

        public NavigationButton(char iconChar, string? text)
        {
            iconLabel = new Label
            {
                BackColor = BackColor,
                Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Regular, GraphicsUnit.Point),
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                Size = new Size(48, 40),
                Text = iconChar.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            iconLabel.MouseEnter += Label_MouseEnter;
            iconLabel.MouseLeave += Label_MouseLeave;
            iconLabel.Click += Label_Click;

            textLabel = new Label
            {
                BackColor = BackColor,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(4, 0, 0, 0),
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft
            };
            textLabel.MouseEnter += Label_MouseEnter;
            textLabel.MouseLeave += Label_MouseLeave;
            textLabel.Click += Label_Click;

            base.BackColor = Color.Transparent;
            BackColor = Color.Transparent;
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            CornerRadius = 3;
            Dock = DockStyle.Fill;
            HoverColor = Color.FromArgb(20, Color.Black);
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            RowCount = 1;
            SelectedColor = Color.FromArgb(0, 95, 184);
            Type = ButtonType.IconAndText;
            Controls.Add(iconLabel, 0, 0);
            Controls.Add(textLabel, 1, 0);
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            Click?.Invoke(this, e);
        }

        private void Label_MouseLeave(object? sender, EventArgs e)
        {
            isHovered = false;
            Invalidate();
        }

        private void Label_MouseEnter(object? sender, EventArgs e)
        {
            isHovered = true;
            Invalidate();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            int paddingHorizontal = 5;
            int paddingVertical = 3;

            if (isHovered || Selected)
            {
                var cornerDiameter = CornerRadius * 2;
                GraphicsPath path = new();
                var right = (Type == ButtonType.IconAndText ? Width : 48) -cornerDiameter - 1 - paddingHorizontal;
                path.StartFigure();
                path.AddArc(paddingHorizontal, paddingVertical, cornerDiameter, cornerDiameter, 180, 90);
                path.AddArc(right, paddingVertical, cornerDiameter, cornerDiameter, 270, 90);
                path.AddArc(right, Height - cornerDiameter - 1 - paddingVertical, cornerDiameter, cornerDiameter, 0, 90);
                path.AddArc(paddingHorizontal, Height - cornerDiameter - 1 - paddingVertical, cornerDiameter, cornerDiameter, 90, 90);
                path.CloseFigure();
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.FillPath(new SolidBrush(Color.FromArgb((isHovered ? 20 : 0) + (Selected ? 20 : 0), Color.Black)), path);
            }

            if (Selected)
            {
                e.Graphics.DrawLine(new Pen(SelectedColor, 3), paddingHorizontal + 1.5F, 12, paddingHorizontal + 1.5F, Height - 12);
            }

        }
    }
}
