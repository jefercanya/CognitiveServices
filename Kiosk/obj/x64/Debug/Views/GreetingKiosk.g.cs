﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\GreetingKiosk.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "295CA82532CC578E7EE14A1A82553304B869FBECB9BF446082F4217B348AFB8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views
{
    partial class GreetingKiosk : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\GreetingKiosk.xaml line 1
                {
                    this.page = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)this.page).SizeChanged += this.OnPageSizeChanged;
                }
                break;
            case 2: // Views\GreetingKiosk.xaml line 13
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\GreetingKiosk.xaml line 23
                {
                    this.cameraHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Views\GreetingKiosk.xaml line 53
                {
                    this.faceLantencyDebugText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\GreetingKiosk.xaml line 39
                {
                    this.greetingTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\GreetingKiosk.xaml line 37
                {
                    this.greetingSymbol = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 7: // Views\GreetingKiosk.xaml line 24
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

