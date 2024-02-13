
using System.Linq.Expressions;
using System.Windows.Forms;

namespace IPED_Gui_WinForms.Controls.Fluent2
{
    public class NavigationPanel : UserControl
    {
        public TableLayoutPanel MiddlePanel { get; private set; }
        public Panel LowerPanel { get; private set; }

        private TableLayoutPanel tableLayoutPanel;

        public NavigationPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            MiddlePanel = new TableLayoutPanel();
            MiddlePanel.SuspendLayout();
            MiddlePanel.BackColor = Color.YellowGreen;
            MiddlePanel.AutoScroll = true;
            MiddlePanel.ColumnCount = 1;
            MiddlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            MiddlePanel.Dock = DockStyle.Fill;
            MiddlePanel.RowCount = 0;
            MiddlePanel.Margin = Padding.Empty;
            MiddlePanel.Padding = Padding.Empty;
            MiddlePanel.ResumeLayout();

            LowerPanel = new Panel();
            LowerPanel.SuspendLayout();
            LowerPanel.Dock = DockStyle.Fill;
            LowerPanel.BackColor = Color.Blue;
            LowerPanel.Margin = Padding.Empty;
            LowerPanel.Padding = Padding.Empty;
            LowerPanel.ResumeLayout();

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            tableLayoutPanel.Controls.Add(MiddlePanel, 0, 1);
            tableLayoutPanel.Controls.Add(LowerPanel, 0, 2);
            tableLayoutPanel.ResumeLayout();

            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Controls.Add(tableLayoutPanel);

            ResumeLayout();
        }

        public void AddNavigationButton(NavigationButton buttonToAdd)
        {
            MiddlePanel.SuspendLayout();
            MiddlePanel.RowCount++;
            MiddlePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            MiddlePanel.Controls.Add(buttonToAdd, 0, MiddlePanel.RowCount - 1);
            MiddlePanel.ResumeLayout();
        }
    }
}
