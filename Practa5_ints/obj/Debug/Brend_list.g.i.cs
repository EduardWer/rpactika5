﻿#pragma checksum "..\..\Brend_list.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "903092B89A3327DEB1338BFD1882045CC5381643C9FA8B5781BF12C4DACC6631"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practa5_ints;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Practa5_ints {
    
    
    /// <summary>
    /// Brend_list
    /// </summary>
    public partial class Brend_list : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_brend;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firm_named;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox country;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label exeptions;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Brend_list.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button import;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Practa5_ints;component/brend_list.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Brend_list.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid_brend = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\Brend_list.xaml"
            this.grid_brend.AddHandler(System.Windows.Controls.DataGridCell.SelectedEvent, new System.Windows.RoutedEventHandler(this.grid_brend_Selected));
            
            #line default
            #line hidden
            return;
            case 2:
            this.firm_named = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.country = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.exeptions = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.create = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Brend_list.xaml"
            this.create.Click += new System.Windows.RoutedEventHandler(this.create_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.delate = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Brend_list.xaml"
            this.delate.Click += new System.Windows.RoutedEventHandler(this.delate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Brend_list.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.import = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Brend_list.xaml"
            this.import.Click += new System.Windows.RoutedEventHandler(this.import_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

