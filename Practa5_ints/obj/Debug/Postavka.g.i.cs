﻿#pragma checksum "..\..\Postavka.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F237C35C4B6B9336A471C3B4B12F087B35910D75C966B319FD6AEFBBF863B02"
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
    /// Postavka
    /// </summary>
    public partial class Postavka : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_brend;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox named;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Col_vo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label exeptions;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Date_pastav;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox postavchic;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Postavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delate;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Postavka.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Practa5_ints;component/postavka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Postavka.xaml"
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
            
            #line 34 "..\..\Postavka.xaml"
            this.grid_brend.AddHandler(System.Windows.Controls.DataGridCell.SelectedEvent, new System.Windows.RoutedEventHandler(this.grid_brend_Selected));
            
            #line default
            #line hidden
            return;
            case 2:
            this.named = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Col_vo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.exeptions = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Date_pastav = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.postavchic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.create = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\Postavka.xaml"
            this.create.Click += new System.Windows.RoutedEventHandler(this.create_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.delate = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Postavka.xaml"
            this.delate.Click += new System.Windows.RoutedEventHandler(this.delate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Postavka.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

