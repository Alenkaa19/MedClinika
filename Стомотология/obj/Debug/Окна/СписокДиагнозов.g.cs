﻿#pragma checksum "..\..\..\Окна\СписокДиагнозов.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4948E34CAB2E74BD7BCFFBC231AD1218E332CEC742DC8158B2D9582B88C2B6B7"
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
using Стомотология;
using Стомотология.Commands;
using Стомотология.ValidationRules;


namespace Стомотология {
    
    
    /// <summary>
    /// СписокДиагнозов
    /// </summary>
    public partial class СписокДиагнозов : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridBol;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame BorderFind;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridFind;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSearch;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSurname;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSurname;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Окна\СписокДиагнозов.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFindSurname;
        
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
            System.Uri resourceLocater = new System.Uri("/Стомотология;component/%d0%9e%d0%ba%d0%bd%d0%b0/%d0%a1%d0%bf%d0%b8%d1%81%d0%be%d" +
                    "0%ba%d0%94%d0%b8%d0%b0%d0%b3%d0%bd%d0%be%d0%b7%d0%be%d0%b2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Окна\СписокДиагнозов.xaml"
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
            
            #line 1 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((Стомотология.СписокДиагнозов)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridBol = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BorderFind = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.gridFind = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.TextBlockSearch = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TextBlockSurname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextBoxSurname = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\Окна\СписокДиагнозов.xaml"
            this.TextBoxSurname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSurname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonFindSurname = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Окна\СписокДиагнозов.xaml"
            this.ButtonFindSurname.Click += new System.Windows.RoutedEventHandler(this.ButtonFindSurname_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 85 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 92 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UndoCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.UndoCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 93 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 93 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.NewCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 94 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SaveCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 95 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.FindCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.FindCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 96 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 96 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.DeleteCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 97 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.EditCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 98 "..\..\..\Окна\СписокДиагнозов.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.RefreshCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

