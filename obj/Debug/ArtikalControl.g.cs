#pragma checksum "..\..\ArtikalControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E259AABB6B988E973F03519F982B7C062DB3C98831E61023A2D06CBABF08EBEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Wpf_Zadaca_3;


namespace Wpf_Zadaca_3 {
    
    
    /// <summary>
    /// ArtikalControl
    /// </summary>
    public partial class ArtikalControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image slika;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_naziv;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_opis;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_smanji;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_kolicina;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_povecaj;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_obrisi;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ArtikalControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_cijena;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_Zadaca_3;component/artikalcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ArtikalControl.xaml"
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
            this.slika = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.lbl_naziv = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tb_opis = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 14 "..\..\ArtikalControl.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.StackPanel_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_smanji = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ArtikalControl.xaml"
            this.btn_smanji.Click += new System.Windows.RoutedEventHandler(this.btn_smanji_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtbox_kolicina = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_povecaj = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ArtikalControl.xaml"
            this.btn_povecaj.Click += new System.Windows.RoutedEventHandler(this.btn_povecaj_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbl_obrisi = ((System.Windows.Controls.Label)(target));
            
            #line 20 "..\..\ArtikalControl.xaml"
            this.lbl_obrisi.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lbl_obrisi_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_cijena = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

