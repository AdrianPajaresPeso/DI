﻿#pragma checksum "..\..\..\..\View\Articulos\Articulo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA95C78A70DBBD58B121958156995D9FC7E5D2AF72E420E0AD2F226AE26D63F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PrototipoVentas;
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


namespace PrototipoVentas {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_lista;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_addArticulo;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddArticulo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid listadoArticulos;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox bajaSearch;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Iva4;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Iva10;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Iva21;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodigoArticulo;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsers;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\View\Articulos\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignOut;
        
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
            System.Uri resourceLocater = new System.Uri("/PrototipoVentas;component/view/articulos/articulo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Articulos\Articulo.xaml"
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
            this.btn_lista = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\Articulos\Articulo.xaml"
            this.btn_lista.Click += new System.Windows.RoutedEventHandler(this.btn_listar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_addArticulo = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\View\Articulos\Articulo.xaml"
            this.btn_addArticulo.Click += new System.Windows.RoutedEventHandler(this.btn_aniadir);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddArticulo = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.listadoArticulos = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.bajaSearch = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.Iva4 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.Iva10 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.Iva21 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.CodigoArticulo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 95 "..\..\..\..\View\Articulos\Articulo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchArticles);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lvUsers = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            this.SignOut = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\View\Articulos\Articulo.xaml"
            this.SignOut.Click += new System.Windows.RoutedEventHandler(this.SignOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

