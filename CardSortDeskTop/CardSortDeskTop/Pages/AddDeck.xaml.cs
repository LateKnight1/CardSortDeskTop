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
using CardSortDeskTop.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CardSortDeskTop.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddDeck : Page
    {
        public AddDeck()
        {
            this.InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string type = typeBox.SelectedItem.ToString();


        }

        private void NavView_PaneClosing(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs args)
        {
            formData.Visibility = Visibility.Visible;
            saveButton.Visibility = Visibility.Visible;
        }

        private void NavView_PaneOpening(Microsoft.UI.Xaml.Controls.NavigationView sender, object args)
        {
            formData.Visibility = Visibility.Collapsed;
            saveButton.Visibility = Visibility.Collapsed;
        }

        private void NavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            string pageTag = args.InvokedItemContainer.Tag.ToString();
            NavigationModule.NavigateTo(pageTag, Frame);
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            navView.IsPaneOpen = false;
        }
    }
}
