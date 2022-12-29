﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\FaceApiExplorer\FaceApiExplorerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C0D473E11642F568D98FD717CE4923491E0000D1F307331357963D230E88F0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.FaceApiExplorer
{
    partial class FaceApiExplorerPage : 
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
            case 1: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 1
                {
                    this.page = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 4: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 41
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 5: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 320
                {
                    this.imagePicker = (global::IntelligentKioskSample.Controls.ImagePickerControl)(target);
                    ((global::IntelligentKioskSample.Controls.ImagePickerControl)this.imagePicker).OnImageSearchCompleted += this.OnImageSearchCompleted;
                }
                break;
            case 6: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 309
                {
                    this.notFoundGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 316
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 8: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 117
                {
                    this.resultsDetails = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 299
                {
                    this.occlusionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 293
                {
                    this.noiseTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 294
                {
                    this.noiseProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 14: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 286
                {
                    this.blurTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 287
                {
                    this.blurProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 16: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 279
                {
                    this.expouseTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 280
                {
                    this.expouseProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 18: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 255
                {
                    this.headTiltTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 256
                {
                    this.headTiltControl = (global::IntelligentKioskSample.Views.FaceApiExplorer.FacePoseControl)(target);
                }
                break;
            case 20: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 260
                {
                    this.chinAngleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 261
                {
                    this.chinAngleControl = (global::IntelligentKioskSample.Views.FaceApiExplorer.FacePoseControl)(target);
                }
                break;
            case 22: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 265
                {
                    this.faceRotationTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 266
                {
                    this.faceRotationControl = (global::IntelligentKioskSample.Views.FaceApiExplorer.FacePoseControl)(target);
                }
                break;
            case 24: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 243
                {
                    this.notDetectedEmotionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 228
                {
                    this.detectedEmotionGridView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 26: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 238
                {
                    this.detectedEmotionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 169
                {
                    this.haircolorsGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 29: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 198
                {
                    this.glassesTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 30: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 202
                {
                    this.makeupTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 206
                {
                    this.accessoriesGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 33: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 183
                {
                    this.facialHairGridView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 34: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 193
                {
                    this.facialHairTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 160
                {
                    this.genderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 164
                {
                    this.ageTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 97
                {
                    this.faceImageGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.faceImageGrid).SizeChanged += this.OnFaceImageSizeChanged;
                }
                break;
            case 40: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 113
                {
                    this.showFaceLandmarksToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.showFaceLandmarksToggle).Toggled += this.OnShowFaceLandmarksToggleChanged;
                }
                break;
            case 41: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 102
                {
                    this.faceImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.faceImage).SizeChanged += this.OnFaceImageSizeChanged;
                }
                break;
            case 42: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 103
                {
                    this.faceLandmarksControl = (global::IntelligentKioskSample.Views.FaceApiExplorer.FaceLandmarksControl)(target);
                }
                break;
            case 43: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 65
                {
                    this.OverlayPresenter = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter)(target);
                }
                break;
            case 44: // Views\FaceApiExplorer\FaceApiExplorerPage.xaml line 72
                {
                    this.ProgressIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
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
