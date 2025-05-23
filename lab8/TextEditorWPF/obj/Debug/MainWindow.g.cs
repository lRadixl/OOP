﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49AB6894D138DA9766B3BD21206465CE159CCF2F9630374E73140082BAF1C9BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TextEditorWPF;


namespace TextEditorWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFontFamily;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFontSize;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCut;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCopy;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPaste;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectAll;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFilePath;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenFile;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ToggleButtonAutoSave;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbText;
        
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
            System.Uri resourceLocater = new System.Uri("/TextEditorWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((TextEditorWPF.MainWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Drag);
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            ((TextEditorWPF.MainWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbFontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.cbFontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbFontFamily_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.cbFontSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbFontSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCut = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.btnCut.Click += new System.Windows.RoutedEventHandler(this.ButtonTextOperations_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCopy = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.btnCopy.Click += new System.Windows.RoutedEventHandler(this.ButtonTextOperations_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnPaste = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.btnPaste.Click += new System.Windows.RoutedEventHandler(this.ButtonTextOperations_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSelectAll = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.btnSelectAll.Click += new System.Windows.RoutedEventHandler(this.ButtonTextOperations_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txbFilePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnOpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.btnOpenFile.Click += new System.Windows.RoutedEventHandler(this.BtnOpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ToggleButtonAutoSave = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.ToggleButtonAutoSave.Click += new System.Windows.RoutedEventHandler(this.ToggleButtonAutoSave_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 117 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 120 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Minimized_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txbText = ((System.Windows.Controls.TextBox)(target));
            
            #line 130 "..\..\MainWindow.xaml"
            this.txbText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxbText_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

