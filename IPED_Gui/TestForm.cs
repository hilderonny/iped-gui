using IPED_Gui_WinForms.Controls.Fluent2;

namespace IPED_Gui_WinForms
{
    public class TestForm : Form
    {

        private TableLayoutPanel rootTableLayoutPanel;
        private NavigationPanel navigationPanel;
        private ContentPanel contentPanel;

        public TestForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            navigationPanel = new NavigationPanel();
            navigationPanel.SuspendLayout();
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 1"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 2"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 3"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 4"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 5"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 5"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 5"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 5"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 5"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 5"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 6"));
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 7") { Visible = false });
            navigationPanel.AddNavigationButton(new NavigationButton('\uE700', "Tolle Wurst 8"));
            navigationPanel.ResumeLayout();

            contentPanel = new ContentPanel();

            rootTableLayoutPanel = new TableLayoutPanel();
            rootTableLayoutPanel.SuspendLayout();
            rootTableLayoutPanel.ColumnCount = 2;
            rootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            rootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            rootTableLayoutPanel.Dock = DockStyle.Fill;
            rootTableLayoutPanel.Margin = Padding.Empty;
            rootTableLayoutPanel.Padding = Padding.Empty;
            rootTableLayoutPanel.RowCount = 1;
            rootTableLayoutPanel.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            rootTableLayoutPanel.Controls.Add(navigationPanel, 0, 0);
            rootTableLayoutPanel.Controls.Add(contentPanel, 1, 0);
            rootTableLayoutPanel.ResumeLayout();

            ClientSize = new Size(800, 600);
            Controls.Add(rootTableLayoutPanel);

            ResumeLayout();

        }
    }
}
