﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Views\AnomalyDetector\AnomalyDetectorDemo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C12AC91533F28A4EFB69C5691CA6C141D89F7E2BE10B2BDAC7D71CD3421214B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.AnomalyDetector
{
    partial class AnomalyDetectorDemo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Pivot_SelectedItem(global::Windows.UI.Xaml.Controls.Pivot obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_PivotItem_Header(global::Windows.UI.Xaml.Controls.PivotItem obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AnomalyDetectorDemo_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAnomalyDetectorDemo_Bindings
        {
            private global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyDetectorDemo dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Pivot obj4;
            private global::Windows.UI.Xaml.Controls.PivotItem obj5;
            private global::Windows.UI.Xaml.Controls.PivotItem obj6;
            private global::Windows.UI.Xaml.Controls.PivotItem obj7;
            private global::Windows.UI.Xaml.Controls.PivotItem obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4SelectedItemDisabled = false;
            private static bool isobj5HeaderDisabled = false;
            private static bool isobj6HeaderDisabled = false;
            private static bool isobj7HeaderDisabled = false;
            private static bool isobj8HeaderDisabled = false;

            private AnomalyDetectorDemo_obj1_BindingsTracking bindingsTracking;

            public AnomalyDetectorDemo_obj1_Bindings()
            {
                this.bindingsTracking = new AnomalyDetectorDemo_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 36 && columnNumber == 64)
                {
                    isobj4SelectedItemDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 24)
                {
                    isobj5HeaderDisabled = true;
                }
                else if (lineNumber == 53 && columnNumber == 24)
                {
                    isobj6HeaderDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 24)
                {
                    isobj7HeaderDisabled = true;
                }
                else if (lineNumber == 81 && columnNumber == 47)
                {
                    isobj8HeaderDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 36
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Pivot)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 39
                        this.obj5 = (global::Windows.UI.Xaml.Controls.PivotItem)target;
                        break;
                    case 6: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 53
                        this.obj6 = (global::Windows.UI.Xaml.Controls.PivotItem)target;
                        break;
                    case 7: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 67
                        this.obj7 = (global::Windows.UI.Xaml.Controls.PivotItem)target;
                        break;
                    case 8: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 81
                        this.obj8 = (global::Windows.UI.Xaml.Controls.PivotItem)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IAnomalyDetectorDemo_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyDetectorDemo)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyDetectorDemo obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SelectedTab(obj.SelectedTab, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_BikeRentalTab(obj.BikeRentalTab, phase);
                        this.Update_ManufacturingTab(obj.ManufacturingTab, phase);
                        this.Update_TelecomTab(obj.TelecomTab, phase);
                        this.Update_LiveTab(obj.LiveTab, phase);
                    }
                }
            }
            private void Update_SelectedTab(global::Windows.UI.Xaml.Controls.PivotItem obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 36
                    if (!isobj4SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Pivot_SelectedItem(this.obj4, obj, null);
                    }
                }
            }
            private void Update_BikeRentalTab(global::IntelligentKioskSample.Models.TabHeader obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 39
                    if (!isobj5HeaderDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PivotItem_Header(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ManufacturingTab(global::IntelligentKioskSample.Models.TabHeader obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 53
                    if (!isobj6HeaderDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PivotItem_Header(this.obj6, obj, null);
                    }
                }
            }
            private void Update_TelecomTab(global::IntelligentKioskSample.Models.TabHeader obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 67
                    if (!isobj7HeaderDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PivotItem_Header(this.obj7, obj, null);
                    }
                }
            }
            private void Update_LiveTab(global::IntelligentKioskSample.Models.TabHeader obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 81
                    if (!isobj8HeaderDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PivotItem_Header(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_4_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.SelectedTab = (global::Windows.UI.Xaml.Controls.PivotItem)this.obj4.SelectedItem;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AnomalyDetectorDemo_obj1_BindingsTracking
            {
                private global::System.WeakReference<AnomalyDetectorDemo_obj1_Bindings> weakRefToBindingObj; 

                public AnomalyDetectorDemo_obj1_BindingsTracking(AnomalyDetectorDemo_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AnomalyDetectorDemo_obj1_Bindings>(obj);
                }

                public AnomalyDetectorDemo_obj1_Bindings TryGetBindingObject()
                {
                    AnomalyDetectorDemo_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AnomalyDetectorDemo_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyDetectorDemo obj = sender as global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyDetectorDemo;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_SelectedTab(obj.SelectedTab, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SelectedTab":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SelectedTab(obj.SelectedTab, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyDetectorDemo obj)
                {
                    AnomalyDetectorDemo_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.Pivot sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Pivot.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_SelectedItem();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 29
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 4: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 36
                {
                    this.pivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 8: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 81
                {
                    this.livePivotItem = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 9: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 90
                {
                    this.liveChart = (global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyChartControl)(target);
                    ((global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyChartControl)this.liveChart).StartLiveAudio += this.OnStartLiveAudio;
                    ((global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyChartControl)this.liveChart).StopLiveAudio += this.OnStopLiveAudio;
                }
                break;
            case 10: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 76
                {
                    this.telecomChart = (global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyChartControl)(target);
                }
                break;
            case 11: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 62
                {
                    this.manufacturingChart = (global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyChartControl)(target);
                }
                break;
            case 12: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 48
                {
                    this.bikerentalChart = (global::IntelligentKioskSample.Views.AnomalyDetector.AnomalyChartControl)(target);
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
            switch(connectionId)
            {
            case 1: // Views\AnomalyDetector\AnomalyDetectorDemo.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AnomalyDetectorDemo_obj1_Bindings bindings = new AnomalyDetectorDemo_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

