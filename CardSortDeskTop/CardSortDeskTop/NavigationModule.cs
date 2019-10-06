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
                case "addCard":
                    frame.Navigate(typeof(AddCard));
                    return;
                case "remCard":
                    frame.Navigate(typeof(RemoveCard));
                    return;
                case "remDeck":
                    frame.Navigate(typeof(RemoveDeck));
                    return;
                case "editCard":
                    frame.Navigate(typeof(EditCard));
                    return;
            }
        }
    }
}
