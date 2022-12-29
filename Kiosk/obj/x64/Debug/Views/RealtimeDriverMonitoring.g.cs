﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\RealtimeDriverMonitoring.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A071C88097D1269B51B0047A54E162BEB9AA82F09569DDBD2DCFAE7AD28674D"
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
    partial class RealtimeDriverMonitoring : 
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
            case 1: // Views\RealtimeDriverMonitoring.xaml line 1
                {
                    this.page = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)this.page).SizeChanged += this.OnPageSizeChanged;
                }
                break;
            case 2: // Views\RealtimeDriverMonitoring.xaml line 16
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\RealtimeDriverMonitoring.xaml line 128
                {
                    this.highLatencyWarning = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Views\RealtimeDriverMonitoring.xaml line 129
                {
                    this.faceLantencyDebugText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\RealtimeDriverMonitoring.xaml line 130
                {
                    this.visionLantencyDebugText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\RealtimeDriverMonitoring.xaml line 35
                {
                    this.driverPanelColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 7: // Views\RealtimeDriverMonitoring.xaml line 61
                {
                    this.cameraHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8: // Views\RealtimeDriverMonitoring.xaml line 71
                {
                    this.driverPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9: // Views\RealtimeDriverMonitoring.xaml line 116
                {
                    this.headPoseChart = (global::IntelligentKioskSample.Controls.VerticalBarTimelineControl)(target);
                }
                break;
            case 10: // Views\RealtimeDriverMonitoring.xaml line 117
                {
                    this.mouthApertureChart = (global::IntelligentKioskSample.Controls.VerticalBarTimelineControl)(target);
                }
                break;
            case 11: // Views\RealtimeDriverMonitoring.xaml line 118
                {
                    this.eyeApertureChart = (global::IntelligentKioskSample.Controls.VerticalBarTimelineControl)(target);
                }
                break;
            case 12: // Views\RealtimeDriverMonitoring.xaml line 119
                {
                    this.distractionChart = (global::IntelligentKioskSample.Controls.VerticalBarTimelineControl)(target);
                }
                break;
            case 13: // Views\RealtimeDriverMonitoring.xaml line 83
                {
                    this.driverId = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\RealtimeDriverMonitoring.xaml line 62
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                }
                break;
            case 15: // Views\RealtimeDriverMonitoring.xaml line 64
                {
                    this.videoPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 16: // Views\RealtimeDriverMonitoring.xaml line 50
                {
                    this.inputSourceComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 17: // Views\RealtimeDriverMonitoring.xaml line 55
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.OpenVideoClicked;
                }
                break;
            case 18: // Views\RealtimeDriverMonitoring.xaml line 52
                {
                    this.videoInputSource = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
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

