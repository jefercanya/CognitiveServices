#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\CustomVision\ImageWithRegionEditorsControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E4861B55113FB98C7919AEF1A398A56D4ED868418A1D600324B1939B68D54A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.CustomVision
{
    partial class ImageWithRegionEditorsControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            case 1: // Views\CustomVision\ImageWithRegionEditorsControl.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    ((global::Windows.UI.Xaml.Controls.UserControl)element1).DataContextChanged += this.OnControlDataContextChanged;
                }
                break;
            case 2: // Views\CustomVision\ImageWithRegionEditorsControl.xaml line 15
                {
                    this.editorFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.editorFlyout).Opened += this.OnEditorFlyoutOpened;
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.editorFlyout).Closed += this.OnEditorFlyoutClosed;
                }
                break;
            case 3: // Views\CustomVision\ImageWithRegionEditorsControl.xaml line 26
                {
                    this.imageControl = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageControl).ImageOpened += this.OnTaggedImageOpened;
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageControl).PointerReleased += this.OnPointerReleasedOverImage;
                }
                break;
            case 4: // Views\CustomVision\ImageWithRegionEditorsControl.xaml line 27
                {
                    this.imageRegionsCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
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

