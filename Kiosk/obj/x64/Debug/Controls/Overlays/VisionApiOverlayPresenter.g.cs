#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Controls\Overlays\VisionApiOverlayPresenter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "533791503135B257914AE34E23317D139EFDDDC15292EEA7826BFC54ACFDF2A9"
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
    partial class VisionApiOverlayPresenter : 
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
            public static void Set_IntelligentKioskSample_Controls_Overlays_Primitives_OverlayPresenter_EnableHoverSelection(global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter obj, global::System.Boolean value)
            {
                obj.EnableHoverSelection = value;
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
        private class VisionApiOverlayPresenter_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IVisionApiOverlayPresenter_Bindings
        {
            private global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter obj5;
            private global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl obj6;
            private global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl obj7;
            private global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5SourceDisabled = false;
            private static bool isobj5EnableHoverSelectionDisabled = false;
            private static bool isobj6ItemsSourceDisabled = false;
            private static bool isobj7ItemsSourceDisabled = false;
            private static bool isobj8ItemsSourceDisabled = false;

            private VisionApiOverlayPresenter_obj1_BindingsTracking bindingsTracking;

            public VisionApiOverlayPresenter_obj1_Bindings()
            {
                this.bindingsTracking = new VisionApiOverlayPresenter_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 40 && columnNumber == 25)
                {
                    isobj5SourceDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 86)
                {
                    isobj5EnableHoverSelectionDisabled = true;
                }
                else if (lineNumber == 41 && columnNumber == 32)
                {
                    isobj6ItemsSourceDisabled = true;
                }
                else if (lineNumber == 42 && columnNumber == 32)
                {
                    isobj7ItemsSourceDisabled = true;
                }
                else if (lineNumber == 43 && columnNumber == 32)
                {
                    isobj8ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Controls\Overlays\VisionApiOverlayPresenter.xaml line 40
                        this.obj5 = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayPresenter)target;
                        break;
                    case 6: // Controls\Overlays\VisionApiOverlayPresenter.xaml line 41
                        this.obj6 = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl)target;
                        break;
                    case 7: // Controls\Overlays\VisionApiOverlayPresenter.xaml line 42
                        this.obj7 = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl)target;
                        break;
                    case 8: // Controls\Overlays\VisionApiOverlayPresenter.xaml line 43
                        this.obj8 = (global::IntelligentKioskSample.Controls.Overlays.Primitives.OverlayItemsControl)target;
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

            // IVisionApiOverlayPresenter_Bindings

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
                    this.dataRoot = (global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Source(obj.Source, phase);
                        this.Update_EnableHoverSelection(obj.EnableHoverSelection, phase);
                        this.Update_ObjectInfo(obj.ObjectInfo, phase);
                        this.Update_FaceInfo(obj.FaceInfo, phase);
                        this.Update_TextInfo(obj.TextInfo, phase);
                    }
                }
            }
            private void Update_Source(global::Windows.UI.Xaml.Media.ImageSource obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\VisionApiOverlayPresenter.xaml line 40
                    if (!isobj5SourceDisabled)
                    {
                        XamlBindingSetters.Set_IntelligentKioskSample_Controls_Overlays_Primitives_OverlayPresenter_Source(this.obj5, obj, null);
                    }
                }
            }
            private void Update_EnableHoverSelection(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\VisionApiOverlayPresenter.xaml line 40
                    if (!isobj5EnableHoverSelectionDisabled)
                    {
                        XamlBindingSetters.Set_IntelligentKioskSample_Controls_Overlays_Primitives_OverlayPresenter_EnableHoverSelection(this.obj5, obj);
                    }
                }
            }
            private void Update_ObjectInfo(global::System.Collections.Generic.IList<global::IntelligentKioskSample.Controls.Overlays.ObjectOverlayInfo> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\VisionApiOverlayPresenter.xaml line 41
                    if (!isobj6ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                    }
                }
            }
            private void Update_FaceInfo(global::System.Collections.Generic.IList<global::IntelligentKioskSample.Controls.Overlays.FaceOverlayInfo> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\VisionApiOverlayPresenter.xaml line 42
                    if (!isobj7ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                    }
                }
            }
            private void Update_TextInfo(global::System.Collections.Generic.IList<global::IntelligentKioskSample.Controls.Overlays.TextOverlayInfo> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\Overlays\VisionApiOverlayPresenter.xaml line 43
                    if (!isobj8ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class VisionApiOverlayPresenter_obj1_BindingsTracking
            {
                private global::System.WeakReference<VisionApiOverlayPresenter_obj1_Bindings> weakRefToBindingObj; 

                public VisionApiOverlayPresenter_obj1_BindingsTracking(VisionApiOverlayPresenter_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<VisionApiOverlayPresenter_obj1_Bindings>(obj);
                }

                public VisionApiOverlayPresenter_obj1_Bindings TryGetBindingObject()
                {
                    VisionApiOverlayPresenter_obj1_Bindings bindingObject = null;
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
                    VisionApiOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_Source(obj.Source, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_EnableHoverSelection(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    VisionApiOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_EnableHoverSelection(obj.EnableHoverSelection, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ObjectInfo(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    VisionApiOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_ObjectInfo(obj.ObjectInfo, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_FaceInfo(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    VisionApiOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_FaceInfo(obj.FaceInfo, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_TextInfo(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    VisionApiOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj = sender as global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter;
                        if (obj != null)
                        {
                            bindings.Update_TextInfo(obj.TextInfo, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Source = 0;
                private long tokenDPC_EnableHoverSelection = 0;
                private long tokenDPC_ObjectInfo = 0;
                private long tokenDPC_FaceInfo = 0;
                private long tokenDPC_TextInfo = 0;
                public void UpdateChildListeners_(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter obj)
                {
                    VisionApiOverlayPresenter_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.SourceProperty, tokenDPC_Source);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.EnableHoverSelectionProperty, tokenDPC_EnableHoverSelection);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.ObjectInfoProperty, tokenDPC_ObjectInfo);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.FaceInfoProperty, tokenDPC_FaceInfo);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.TextInfoProperty, tokenDPC_TextInfo);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Source = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.SourceProperty, DependencyPropertyChanged_Source);
                            tokenDPC_EnableHoverSelection = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.EnableHoverSelectionProperty, DependencyPropertyChanged_EnableHoverSelection);
                            tokenDPC_ObjectInfo = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.ObjectInfoProperty, DependencyPropertyChanged_ObjectInfo);
                            tokenDPC_FaceInfo = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.FaceInfoProperty, DependencyPropertyChanged_FaceInfo);
                            tokenDPC_TextInfo = obj.RegisterPropertyChangedCallback(global::IntelligentKioskSample.Controls.Overlays.VisionApiOverlayPresenter.TextInfoProperty, DependencyPropertyChanged_TextInfo);
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
            case 1: // Controls\Overlays\VisionApiOverlayPresenter.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    VisionApiOverlayPresenter_obj1_Bindings bindings = new VisionApiOverlayPresenter_obj1_Bindings();
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

