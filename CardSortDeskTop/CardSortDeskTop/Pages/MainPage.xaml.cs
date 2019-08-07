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
        public List<Card> activeCardsList { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();

            deckNames = new List<string>();
            activeCardsList = new List<Card>();
            DataContext = this;
        }

        private void NavView_PaneClosing(NavigationView sender, NavigationViewPaneClosingEventArgs args)
        {

        }

        private void NavView_PaneOpening(NavigationView sender, object args)
        {

        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

        }

        private void CardSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
