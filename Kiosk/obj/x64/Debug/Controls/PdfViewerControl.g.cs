#pragma checksum "E:\LSData\Net Core\Cognitive_Services\Kiosk\Kiosk\Controls\PdfViewerControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C432625DCCBCE56C40913FFB4E060720F61B19203882F06BF68629B84ADE130"
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
    partial class PdfViewerControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PdfViewerControl_obj9_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPdfViewerControl_Bindings
        {
            private global::IntelligentKioskSample.Controls.PdfViewerPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj9;
            private global::Windows.UI.Xaml.Controls.Image obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10SourceDisabled = false;

            private PdfViewerControl_obj9_BindingsTracking bindingsTracking;

            public PdfViewerControl_obj9_Bindings()
            {
                this.bindingsTracking = new PdfViewerControl_obj9_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 26 && columnNumber == 32)
                {
                    isobj10SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // Controls\PdfViewerControl.xaml line 25
                        this.obj9 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 10: // Controls\PdfViewerControl.xaml line 26
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj9.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::IntelligentKioskSample.Controls.PdfViewerPage) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IPdfViewerControl_Bindings

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
                    this.dataRoot = (global::IntelligentKioskSample.Controls.PdfViewerPage)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IntelligentKioskSample.Controls.PdfViewerPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Image(obj.Image, phase);
                    }
                }
            }
            private void Update_Image(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\PdfViewerControl.xaml line 26
                    if (!isobj10SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class PdfViewerControl_obj9_BindingsTracking
            {
                private global::System.WeakReference<PdfViewerControl_obj9_Bindings> weakRefToBindingObj; 

                public PdfViewerControl_obj9_BindingsTracking(PdfViewerControl_obj9_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<PdfViewerControl_obj9_Bindings>(obj);
                }

                public PdfViewerControl_obj9_Bindings TryGetBindingObject()
                {
                    PdfViewerControl_obj9_Bindings bindingObject = null;
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
                    PdfViewerControl_obj9_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::IntelligentKioskSample.Controls.PdfViewerPage obj = sender as global::IntelligentKioskSample.Controls.PdfViewerPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Image(obj.Image, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Image":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Image(obj.Image, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::IntelligentKioskSample.Controls.PdfViewerPage obj)
                {
                    PdfViewerControl_obj9_Bindings bindings = TryGetBindingObject();
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
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PdfViewerControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPdfViewerControl_Bindings
        {
            private global::IntelligentKioskSample.Controls.PdfViewerControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::IntelligentKioskSample.Controls.SimpleCarousel obj2;
            private global::Windows.UI.Xaml.Controls.Grid obj3;
            private global::Windows.UI.Xaml.Controls.Border obj4;
            private global::Windows.UI.Xaml.Controls.Border obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj3VisibilityDisabled = false;
            private static bool isobj4VisibilityDisabled = false;
            private static bool isobj5VisibilityDisabled = false;

            private PdfViewerControl_obj1_BindingsTracking bindingsTracking;

            public PdfViewerControl_obj1_Bindings()
            {
                this.bindingsTracking = new PdfViewerControl_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 19 && columnNumber == 49)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 32 && columnNumber == 15)
                {
                    isobj3VisibilityDisabled = true;
                }
                else if (lineNumber == 34 && columnNumber == 17)
                {
                    isobj4VisibilityDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 17)
                {
                    isobj5VisibilityDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\PdfViewerControl.xaml line 19
                        this.obj2 = (global::IntelligentKioskSample.Controls.SimpleCarousel)target;
                        break;
                    case 3: // Controls\PdfViewerControl.xaml line 32
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 4: // Controls\PdfViewerControl.xaml line 33
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 5: // Controls\PdfViewerControl.xaml line 43
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Border)target;
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

            // IPdfViewerControl_Bindings

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
                    this.dataRoot = (global::IntelligentKioskSample.Controls.PdfViewerControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IntelligentKioskSample.Controls.PdfViewerControl obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PdfPages(obj.PdfPages, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_EnableScrollControls(obj.EnableScrollControls, phase);
                    }
                }
            }
            private void Update_PdfPages(global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PdfPages(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PdfPages_Count(obj.Count, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\PdfViewerControl.xaml line 19
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_EnableScrollControls(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\PdfViewerControl.xaml line 32
                    if (!isobj3VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("booleanToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                    }
                }
            }
            private void Update_PdfPages_Count(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\PdfViewerControl.xaml line 33
                    if (!isobj4VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("collectionCountToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), "1", null));
                    }
                    // Controls\PdfViewerControl.xaml line 43
                    if (!isobj5VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("collectionCountToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), "1", null));
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class PdfViewerControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<PdfViewerControl_obj1_Bindings> weakRefToBindingObj; 

                public PdfViewerControl_obj1_BindingsTracking(PdfViewerControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<PdfViewerControl_obj1_Bindings>(obj);
                }

                public PdfViewerControl_obj1_Bindings TryGetBindingObject()
                {
                    PdfViewerControl_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_PdfPages(null);
                }

                public void PropertyChanged_PdfPages(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PdfViewerControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PdfPages_Count(obj.Count, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Count":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PdfPages_Count(obj.Count, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_PdfPages(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    PdfViewerControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage>;
                if (obj != null)
                {
                    bindings.Update_PdfPages_Count(obj.Count, DATA_CHANGED);
                }
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage> cache_PdfPages = null;
                public void UpdateChildListeners_PdfPages(global::System.Collections.ObjectModel.ObservableCollection<global::IntelligentKioskSample.Controls.PdfViewerPage> obj)
                {
                    if (obj != cache_PdfPages)
                    {
                        if (cache_PdfPages != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PdfPages).PropertyChanged -= PropertyChanged_PdfPages;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_PdfPages).CollectionChanged -= CollectionChanged_PdfPages;
                            cache_PdfPages = null;
                        }
                        if (obj != null)
                        {
                            cache_PdfPages = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PdfPages;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_PdfPages;
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
            switch(connectionId)
            {
            case 1: // Controls\PdfViewerControl.xaml line 1
                {
                    this.Root = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2: // Controls\PdfViewerControl.xaml line 19
                {
                    this.Carousel = (global::IntelligentKioskSample.Controls.SimpleCarousel)(target);
                }
                break;
            case 6: // Controls\PdfViewerControl.xaml line 48
                {
                    this.MoveBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MoveBack).Click += this.Back;
                }
                break;
            case 7: // Controls\PdfViewerControl.xaml line 38
                {
                    this.MoveForward = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MoveForward).Click += this.Forward;
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
            case 1: // Controls\PdfViewerControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    PdfViewerControl_obj1_Bindings bindings = new PdfViewerControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 9: // Controls\PdfViewerControl.xaml line 25
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element9 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    PdfViewerControl_obj9_Bindings bindings = new PdfViewerControl_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

