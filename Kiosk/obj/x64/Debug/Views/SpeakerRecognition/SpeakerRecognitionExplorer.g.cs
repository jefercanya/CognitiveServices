#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "333546320D2F3931BEF139ABD80CF3A15F80797D29106447CE8FFFFACD47F05C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.SpeakerRecognition
{
    partial class SpeakerRecognitionExplorer : 
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
            case 1: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 1
                {
                    this.mainPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 48
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 167
                {
                    this.mediaPlayerElement = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 4: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 169
                {
                    this.speakerRecognitionModelSetupControl = (global::IntelligentKioskSample.Views.SpeakerRecognition.SpeakerRecognitionModelSetup)(target);
                    ((global::IntelligentKioskSample.Views.SpeakerRecognition.SpeakerRecognitionModelSetup)this.speakerRecognitionModelSetupControl).ModelCreated += this.OnNewModelCreated;
                }
                break;
            case 5: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 140
                {
                    this.startDetectionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.startDetectionButton).Click += this.StartRecognitionButtonClicked;
                }
                break;
            case 6: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 147
                {
                    global::Windows.UI.Xaml.Controls.DropDownButton element6 = (global::Windows.UI.Xaml.Controls.DropDownButton)(target);
                    ((global::Windows.UI.Xaml.Controls.DropDownButton)element6).Click += this.OnFilesSamplesDropDownButtonClicked;
                }
                break;
            case 7: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 152
                {
                    this.fileSamplesFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 8: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 154
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.OnUploadAudioFileClick;
                }
                break;
            case 9: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 123
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.OnTryAgainButtonClicked;
                }
                break;
            case 10: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 120
                {
                    this.detectedVoice = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 121
                {
                    this.detectedVoiceProbability = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 114
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.OnTryAgainButtonClicked;
                }
                break;
            case 13: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element13 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element13).Click += this.OnSwitchInputModeButtonClicked;
                }
                break;
            case 14: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 91
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element14 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element14).Click += this.OnCreateNewModelClick;
                }
                break;
            case 15: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 55
                {
                    this.modelsFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 16: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 83
                {
                    global::Windows.UI.Xaml.Documents.Hyperlink element16 = (global::Windows.UI.Xaml.Documents.Hyperlink)(target);
                    ((global::Windows.UI.Xaml.Documents.Hyperlink)element16).Click += this.OnCreateNewModelClick;
                }
                break;
            case 19: // Views\SpeakerRecognition\SpeakerRecognitionExplorer.xaml line 71
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.OnModelDeleteButtonClick;
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

