﻿#pragma checksum "..\..\Zakazi.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C52D8042ECA3B975AB3F4483720D2003612375F7F4781CFBEB48307EFD721D8"
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
    /// Zakazi
    /// </summary>
    public partial class Zakazi : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_brend;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namber;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox zakaz;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label exeptions;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Zakazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
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
            System.Uri resourceLocater = new System.Uri("/Practa5_ints;component/zakazi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Zakazi.xaml"
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
            
            #line 34 "..\..\Zakazi.xaml"
            this.grid_brend.AddHandler(System.Windows.Controls.DataGridCell.SelectedEvent, new System.Windows.RoutedEventHandler(this.grid_brend_Selected));
            
            #line default
            #line hidden
            return;
            case 2:
            this.namber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.zakaz = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.exeptions = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.create = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Zakazi.xaml"
            this.create.Click += new System.Windows.RoutedEventHandler(this.create_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.delate = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Zakazi.xaml"
            this.delate.Click += new System.Windows.RoutedEventHandler(this.delate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Zakazi.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

