﻿#pragma checksum "C:\Users\schlu\Desktop\Git Projects\CardSortDeskTop\CardSortDeskTop\CardSortDeskTop\Pages\TransferCards.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "696499EB9101A7275F179EF9419FE431"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardSortDeskTop.Pages
{
    partial class TransferCards : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Pages\TransferCards.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loading += this.Page_Loading;
                }
                break;
            case 2: // Pages\TransferCards.xaml line 15
                {
                    this.navView = (global::Microsoft.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.navView).PaneClosing += this.NavView_PaneClosing;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.navView).PaneOpening += this.NavView_PaneOpening;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.navView).ItemInvoked += this.NavView_ItemInvoked;
                }
                break;
            case 3: // Pages\TransferCards.xaml line 79
                {
                    this.mainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Pages\TransferCards.xaml line 90
                {
                    this.deckBox1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.deckBox1).SelectionChanged += this.DeckBox1_SelectionChanged;
                }
                break;
            case 5: // Pages\TransferCards.xaml line 96
                {
                    this.deckBox2 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.deckBox2).SelectionChanged += this.DeckBox2_SelectionChanged;
                }
                break;
            case 6: // Pages\TransferCards.xaml line 103
                {
                    this.deckCards1 = (global::MyToolkit.Controls.DataGrid)(target);
                }
                break;
            case 7: // Pages\TransferCards.xaml line 106
                {
                    this.deckCards2 = (global::MyToolkit.Controls.DataGrid)(target);
                }
                break;
            case 8: // Pages\TransferCards.xaml line 110
                {
                    this.buttonsGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9: // Pages\TransferCards.xaml line 119
                {
                    this.saveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.saveButton).Click += this.SaveButton_Click;
                }
                break;
            case 10: // Pages\TransferCards.xaml line 127
                {
                    this.toDeck2Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.toDeck2Button).Click += this.ToDeck2Button_Click;
                }
                break;
            case 11: // Pages\TransferCards.xaml line 135
                {
                    this.toDeck1Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.toDeck1Button).Click += this.ToDeck1Button_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

