
namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationButton : UserControl
    {

        private readonly TableLayoutPanel horizontalTable;
        private readonly Label iconLabel;
        private readonly Label textLabel;
        private Color originalBackColor = Color.Transparent;
        public Color HoverColor { get; set; }
        public override Color BackColor { get => originalBackColor; set {
                originalBackColor = value;
                iconLabel.BackColor = value;
                textLabel.BackColor = value;
        } }

        public NavigationButton(char iconChar, string text)
        {
            iconLabel = new Label
            {
                BackColor = BackColor,
                Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point),
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                Size = new Size(44, 44),
                Text = iconChar.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            iconLabel.MouseEnter += Label_MouseEnter;
            iconLabel.MouseLeave += Label_MouseLeave;

            textLabel = new Label
            {
                BackColor = BackColor,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(4, 0, 0, 0),
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft
            };
            textLabel.MouseEnter += Label_MouseEnter;
            textLabel.MouseLeave += Label_MouseLeave;

            horizontalTable = new TableLayoutPanel
            {
                BackColor = Color.Transparent,
                ColumnCount = 2,
                Height = 44,
                RowCount = 1
            };
            horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            horizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            horizontalTable.Controls.Add(iconLabel, 0, 0);
            horizontalTable.Controls.Add(textLabel, 1, 0);

            base.BackColor = Color.Transparent;
            Dock = DockStyle.Fill;
            HoverColor = Color.FromArgb(20, Color.Black);
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Controls.Add(horizontalTable);
        }

        private void Label_MouseLeave(object? sender, EventArgs e)
        {
            iconLabel.BackColor = originalBackColor;
            textLabel.BackColor = originalBackColor;
        }

        private void Label_MouseEnter(object? sender, EventArgs e)
        {
            iconLabel.BackColor = HoverColor;
            textLabel.BackColor = HoverColor;
        }
    }
}
