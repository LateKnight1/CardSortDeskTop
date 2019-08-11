using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using CardSortDeskTop.Pages;

namespace CardSortDeskTop
{
    class NavigationModule
    {
        public static void NavigateTo(string pageTag, Frame frame)
        {
            switch (pageTag)
            {
                case "home":
                    frame.Navigate(typeof(MainPage));
                    return;
                case "addDeck":
                    frame.Navigate(typeof(AddDeck));
                    return;
            }
        }
    }
}
