using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using CardSortDeskTop.Structure;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CardSortDeskTop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        internal List<string> DeckNames { get; }
        internal List<Card> CardsList { get; }
        public MainPage()
        {
            this.InitializeComponent();
            navView.IsPaneOpen = false;
            DeckNames = new List<string>();
            CardsList = new List<Card>();
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
