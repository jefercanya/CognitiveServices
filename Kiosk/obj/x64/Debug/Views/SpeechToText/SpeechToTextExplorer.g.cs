﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\SpeechToText\SpeechToTextExplorer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BBB9EFBF615FA18CC393DF9AAE64AFAE59C5144DBCB4C37FCE01743D9B4FFE54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.SpeechToText
{
    partial class SpeechToTextExplorer : 
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
            case 1: // Views\SpeechToText\SpeechToTextExplorer.xaml line 1
                {
                    this.mainPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // Views\SpeechToText\SpeechToTextExplorer.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).Tapped += this.OnMainGridTapped;
                }
                break;
            case 3: // Views\SpeechToText\SpeechToTextExplorer.xaml line 27
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 4: // Views\SpeechToText\SpeechToTextExplorer.xaml line 130
                {
                    this.mediaPlayerElement = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 5: // Views\SpeechToText\SpeechToTextExplorer.xaml line 132
                {
                    this.notificationControl = (global::IntelligentKioskSample.Controls.NotificationControl)(target);
                }
                break;
            case 6: // Views\SpeechToText\SpeechToTextExplorer.xaml line 114
                {
                    this.translationFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.translationFlyout).Opened += this.TranslationFlyout_Opened;
                }
                break;
            case 7: // Views\SpeechToText\SpeechToTextExplorer.xaml line 121
                {
                    this.targetLanguagesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.targetLanguagesListView).SelectionChanged += this.TargetLanguagesListView_SelectionChanged;
                }
                break;
            case 8: // Views\SpeechToText\SpeechToTextExplorer.xaml line 84
                {
                    this.startDictateButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.startDictateButton).Click += this.StartDictateButtonClicked;
                }
                break;
            case 9: // Views\SpeechToText\SpeechToTextExplorer.xaml line 92
                {
                    this.stopDictateButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.stopDictateButton).Click += this.StopDictateButtonClicked;
                }
                break;
            case 10: // Views\SpeechToText\SpeechToTextExplorer.xaml line 101
                {
                    this.recordingTimePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11: // Views\SpeechToText\SpeechToTextExplorer.xaml line 102
                {
                    this.recordingSecondsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\SpeechToText\SpeechToTextExplorer.xaml line 65
                {
                    this.audioSampleFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 13: // Views\SpeechToText\SpeechToTextExplorer.xaml line 72
                {
                    this.audioSampleListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.audioSampleListView).SelectionChanged += this.AudioSampleCollection_SelectionChanged;
                }
                break;
            case 14: // Views\SpeechToText\SpeechToTextExplorer.xaml line 38
                {
                    this.speechToTextView = (global::IntelligentKioskSample.Views.SpeechToText.SpeechToTextView)(target);
                }
                break;
            case 15: // Views\SpeechToText\SpeechToTextExplorer.xaml line 41
                {
                    this.speechToTextWithTranslation = (global::IntelligentKioskSample.Views.SpeechToText.SpeechToTextWithTranslation)(target);
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
