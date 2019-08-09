using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CardSortDeskTop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<string> deckNames { get; private set; }
        public List<Card> cardsList { get; private set; }
        public MainPage()
        {
            this.InitializeComponent();
            navView.IsPaneOpen = false;
            deckNames = new List<string>();
            cardsList = new List<Card>();
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {

        }

        private void NavigationView_PaneClosing(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs args)
        {
            openButton.Visibility = Visibility.Visible;
            deckBox.Visibility = Visibility.Visible;
        }

        private void NavigationView_PaneOpening(Microsoft.UI.Xaml.Controls.NavigationView sender, object args)
        {
            openButton.Visibility = Visibility.Collapsed;
            deckBox.Visibility = Visibility.Collapsed;
        }

        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {

        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
