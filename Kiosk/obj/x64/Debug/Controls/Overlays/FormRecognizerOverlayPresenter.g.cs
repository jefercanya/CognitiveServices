﻿#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Controls\Overlays\FormRecognizerOverlayPresenter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC9B4B23F566E3E0ED3F615EBE522943E49107A4252B4D70103E17DCA9745A60"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls.Overlays
{
    partial class FormRecognizerOverlayPresenter : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_IntelligentKioskSample_Controls_Overlays_Primitives_OverlayPresenter_Source(global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class FormRecognizerOverlayPresenter_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFormRecognizerOverlayPresenter_Bindings
        {
            private global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter obj3;
            private global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl obj4;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3SourceDisabled = false;
            private static bool isobj4ItemsSourceDisabled = false;

            private FormRecognizerOverlayPresenter_obj1_BindingsTracking bindingsTracking;

            public FormRecognizerOverlayPresenter_obj1_Bindings()
            {
                this.bindingsTracking = new FormRecognizerOverlayPresenter_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 22 && columnNumber == 25)
                {
                    isobj3SourceDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 32)
                {
                    isobj4ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Controls\Overlays\FormRecognizerOverlayPresenter.xaml line 22
                        this.obj3 = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter)target;
                        break;
                    case 4: // Controls\Overlays\FormRecognizerOverlayPresenter.xaml line 23
                        this.obj4 = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl)target;
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

            // IFormRecognizerOverlayPresenter_Bindings

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
                    this.dataRoot = (global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Source(obj.Source, phase);
                        this.Update_TokenInfo(obj.TokenInfo, phase);
                    }
                }
            }
            private void Update_Source(global::Windows.UI.Xaml.Media.ImageSource obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\FormRecognizerOverlayPresenter.xaml line 22
                    if (!isobj3SourceDisabled)
                    {
                        XamlBindingSetters.Set_IntelligentKioskSample_Controls_Overlays_Primitives_OverlayPresenter_Source(this.obj3, obj, null);
                    }
                }
            }
            private void Update_TokenInfo(global::System.Collections.Generic.IList<global::IntelligentKioskSample.Controls.Overlays.TokenOverlayInfo> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\FormRecognizerOverlayPresenter.xaml line 23
                    if (!isobj4ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class FormRecognizerOverlayPresenter_obj1_BindingsTracking
            {
                private global::System.WeakReference<FormRecognizerOverlayPresenter_obj1_Bindings> weakRefToBindingObj; 

                public FormRecognizerOverlayPresenter_obj1_BindingsTracking(FormRecognizerOverlayPresenter_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<FormRecognizerOverlayPresenter_obj1_Bindings>(obj);
                }

                public FormRecognizerOverlayPresenter_obj1_Bindings TryGetBindingObject()
                {
                    FormRecognizerOverlayPresenter_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_Source(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    FormRecognizerOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_Source(obj.Source, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_TokenInfo(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    FormRecognizerOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_TokenInfo(obj.TokenInfo, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Source = 0;
                private long tokenDPC_TokenInfo = 0;
                public void UpdateChildListeners_(global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter obj)
                {
                    FormRecognizerOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter.SourceProperty, tokenDPC_Source);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter.TokenInfoProperty, tokenDPC_TokenInfo);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Source = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter.SourceProperty, DependencyPropertyChanged_Source);
                            tokenDPC_TokenInfo = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.FormRecognizerOverlayPresenter.TokenInfoProperty, DependencyPropertyChanged_TokenInfo);
                        }
                    }
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
            case 1: // Controls\Overlays\FormRecognizerOverlayPresenter.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    FormRecognizerOverlayPresenter_obj1_Bindings bindings = new FormRecognizerOverlayPresenter_obj1_Bindings();
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
