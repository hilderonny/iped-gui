using IPED_GUI_WinUI3.Data;
using IPED_GUI_WinUI3.Helpers;
using IPED_GUI_WinUI3.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Linq;
using System.Reflection;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace IPED_GUI_WinUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        public MainWindow()
        {
            // Load settings
            ApplicationDataContainer appSettings = ApplicationData.Current.LocalSettings;
            if (appSettings.Values["CurrentProfileFile"] is string currentProfileFile)
            {
                Settings.LoadFromFile(currentProfileFile);
            }
            else
            {
                Settings.Create();
            }
            // Now initialize components. They depend on the settings
            InitializeComponent();
            // Show version in title bar
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            if (version != null)
            {
                Title += " " + version?.Major + "." + version?.Minor + "." + version?.Build;
            }
            // Enable / disable config tabs
            UpdateAudioTranslationVisibility();
            // Show Home tab
            var homeMenuItem = (NavigationViewItem)NavView.MenuItems.First();
            NavView.Header = homeMenuItem.Content;
            NavView.SelectedItem = homeMenuItem;
            ContentFrame.Navigate(Type.GetType(homeMenuItem.Tag.ToString()));
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavView.Header = args.SelectedItemContainer.Content;
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                // The navigation items must have the full name of the page to load as TAG
                var navPageType = Type.GetType(args.SelectedItemContainer.Tag.ToString());
                ContentFrame.Navigate(navPageType);
            }
        }

        private void UpdateMenuItemVisibility(string menuItemTag, bool isVisible)
        {
            ((NavigationViewItem)NavView.MenuItems.First(menuItem => ((NavigationViewItem)menuItem).Tag.ToString() == menuItemTag)).Visibility = isVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        public void UpdateAudioTranslationVisibility()
        {
            UpdateMenuItemVisibility("IPED_GUI_WinUI3.Pages.AudioTranslationPage", Settings.Current.PROCESSING_ENABLEAUDIOTRANSLATION);
        }

    }
}
