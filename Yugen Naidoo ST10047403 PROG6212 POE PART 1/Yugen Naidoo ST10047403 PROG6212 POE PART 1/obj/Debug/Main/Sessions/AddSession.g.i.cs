﻿#pragma checksum "..\..\..\..\Main\Sessions\AddSession.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AEC6D4B7B1C387690201F112D8960E45D7B0D7085CF36836A08E2636A1EBD89A"
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
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions;


namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions {
    
    
    /// <summary>
    /// AddSession
    /// </summary>
    public partial class AddSession : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SessionNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SessionsNameErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ModuleCodeComboBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ModuleCodeErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SessionDatePicker;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SessionDateErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SessionMinutesTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SessionMinutesErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Main\Sessions\AddSession.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FinishButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Yugen Naidoo ST10047403 PROG6212 POE PART 1;component/main/sessions/addsession.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Main\Sessions\AddSession.xaml"
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
            
            #line 8 "..\..\..\..\Main\Sessions\AddSession.xaml"
            ((Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions.AddSession)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Main\Sessions\AddSession.xaml"
            ((Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions.AddSession)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UserControl_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SessionNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\Main\Sessions\AddSession.xaml"
            this.SessionNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SessionNameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SessionsNameErrorLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ModuleCodeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\Main\Sessions\AddSession.xaml"
            this.ModuleCodeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ModuleCodeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ModuleCodeErrorLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.SessionDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 27 "..\..\..\..\Main\Sessions\AddSession.xaml"
            this.SessionDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.SessionDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SessionDateErrorLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.SessionMinutesTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\Main\Sessions\AddSession.xaml"
            this.SessionMinutesTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SessionMinutesTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SessionMinutesErrorLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.FinishButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Main\Sessions\AddSession.xaml"
            this.FinishButton.Click += new System.Windows.RoutedEventHandler(this.FinishButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

