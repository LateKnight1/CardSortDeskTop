﻿#pragma checksum "C:\Users\schlu\Desktop\Git Projects\CardSortDeskTop\CardSortDeskTop\CardSortDeskTop\Pages\AddCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0C31D8AB69B549C812962CAC505A77C8"
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
    partial class AddCard : 
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
            case 1: // Pages\AddCard.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loading += this.Page_Loading;
                }
                break;
            case 2: // Pages\AddCard.xaml line 22
                {
                    this.navView = (global::Microsoft.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.navView).PaneClosing += this.NavView_PaneClosing;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.navView).PaneOpening += this.NavView_PaneOpening;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.navView).ItemInvoked += this.NavView_ItemInvoked;
                }
                break;
            case 3: // Pages\AddCard.xaml line 86
                {
                    this.fieldsGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Pages\AddCard.xaml line 218
                {
                    this.saveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.saveButton).Click += this.SaveButton_Click;
                }
                break;
            case 5: // Pages\AddCard.xaml line 227
                {
                    this.cancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelButton).Click += this.CancelButton_Click;
                }
                break;
            case 6: // Pages\AddCard.xaml line 96
                {
                    this.nameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.nameBox).FocusEngaged += this.NameBox_FocusEngaged;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.nameBox).FocusDisengaged += this.NameBox_FocusDisengaged;
                }
                break;
            case 7: // Pages\AddCard.xaml line 103
                {
                    this.deckBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.deckBox).FocusEngaged += this.NameBox_FocusEngaged;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.deckBox).FocusDisengaged += this.NameBox_FocusDisengaged;
                }
                break;
            case 8: // Pages\AddCard.xaml line 111
                {
                    this.typeBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.typeBox).FocusEngaged += this.NameBox_FocusEngaged;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.typeBox).FocusDisengaged += this.NameBox_FocusDisengaged;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.typeBox).SelectionChanged += this.TypeBox_SelectionChanged;
                }
                break;
            case 9: // Pages\AddCard.xaml line 129
                {
                    this.colorBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.colorBox).FocusEngaged += this.NameBox_FocusEngaged;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.colorBox).FocusDisengaged += this.NameBox_FocusDisengaged;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.colorBox).SelectionChanged += this.ColorBox_SelectionChanged;
                }
                break;
            case 10: // Pages\AddCard.xaml line 151
                {
                    this.rarityBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 11: // Pages\AddCard.xaml line 163
                {
                    this.costsGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 12: // Pages\AddCard.xaml line 174
                {
                    this.redCost = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // Pages\AddCard.xaml line 180
                {
                    this.whiteCost = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Pages\AddCard.xaml line 186
                {
                    this.blueCost = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Pages\AddCard.xaml line 192
                {
                    this.blackCost = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // Pages\AddCard.xaml line 198
                {
                    this.greenCost = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // Pages\AddCard.xaml line 204
                {
                    this.colorlessCost = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18: // Pages\AddCard.xaml line 138
                {
                    this.red = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 19: // Pages\AddCard.xaml line 140
                {
                    this.white = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 20: // Pages\AddCard.xaml line 142
                {
                    this.blue = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 21: // Pages\AddCard.xaml line 144
                {
                    this.black = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 22: // Pages\AddCard.xaml line 146
                {
                    this.green = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 23: // Pages\AddCard.xaml line 148
                {
                    this.colorless = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
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

