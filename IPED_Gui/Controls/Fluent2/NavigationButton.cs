
using System.Windows.Forms;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationButton : UserControl
    {

        public int HoverTransparency { get; set; }
        public int SelectedTransparency { get; set; }
        public Color SelectedColor { get; set; }
        public char? Icon { get => iconLabel.Text.Length > 0 ? iconLabel.Text[0] : null; set => iconLabel.Text = value.ToString(); }
        public override string Text { get => textLabel.Text; set =>  textLabel.Text = value; }
        public bool Collapsed { get; set; }

        private TableLayoutPanel tableLayoutPanel;
        private readonly Label iconLabel = new();
        private readonly Label textLabel = new();

        public NavigationButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            iconLabel.SuspendLayout();
            iconLabel.BackColor = Color.Orchid;
            iconLabel.Dock = DockStyle.Fill;
            iconLabel.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconLabel.Margin = Padding.Empty;
            iconLabel.Padding = Padding.Empty;
            iconLabel.ResumeLayout();

            textLabel.SuspendLayout();
            textLabel.BackColor = Color.AliceBlue;
            textLabel.Dock = DockStyle.Fill;
            textLabel.Margin = Padding.Empty;
            textLabel.Padding = Padding.Empty;
            textLabel.ResumeLayout();

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.BackColor = Color.Green;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            tableLayoutPanel.Controls.Add(iconLabel, 0, 0);
            tableLayoutPanel.Controls.Add(textLabel, 1, 0);
            tableLayoutPanel.ResumeLayout();

            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Controls.Add(tableLayoutPanel);

            ResumeLayout();

        }

    }
}
