﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Controls\CameraControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE59F7F8BCFADC39DDC5502C51E4F5E68A56894ED81837174FBB0A5170922B26"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class CameraControl : 
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
            case 1: // Controls\CameraControl.xaml line 1
                {
                    this.cameraControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    ((global::Windows.UI.Xaml.Controls.UserControl)this.cameraControl).Unloaded += this.ControlUnloaded;
                }
                break;
            case 2: // Controls\CameraControl.xaml line 21
                {
                    this.mainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Controls\CameraControl.xaml line 22
                {
                    this.webCamCaptureElement = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 4: // Controls\CameraControl.xaml line 23
                {
                    this.FaceTrackingVisualizationCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 5: // Controls\CameraControl.xaml line 25
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // Controls\CameraControl.xaml line 69
                {
                    this.loadingOverlay = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 7: // Controls\CameraControl.xaml line 62
                {
                    this.cameraSwitchButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cameraSwitchButton).Click += this.CameraSwitchtButtonClick;
                }
                break;
            case 8: // Controls\CameraControl.xaml line 27
                {
                    this.capturePhotoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.capturePhotoButton).Click += this.CameraControlButtonClick;
                }
                break;
            case 9: // Controls\CameraControl.xaml line 41
                {
                    this.continuousModeGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10: // Controls\CameraControl.xaml line 42
                {
                    this.radialProgressBarControl = (global::Microsoft.Toolkit.Uwp.UI.Controls.RadialProgressBar)(target);
                }
                break;
            case 11: // Controls\CameraControl.xaml line 46
                {
                    this.continuousCapturePhotoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.continuousCapturePhotoButton).Click += this.CameraControlContinuousModeClick;
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

