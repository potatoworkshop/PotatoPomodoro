﻿#pragma checksum "..\..\..\Focuspage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AEA97EBC1DF2B4B0036EBA966744AB5640D369F"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using PotatoPomodoro;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PotatoPomodoro {
    
    
    /// <summary>
    /// FocusPage
    /// </summary>
    public partial class FocusPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Focuspage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NotificationText;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Focuspage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimerText;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Focuspage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Focuspage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Focuspage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PotatoPomodoro;component/focuspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Focuspage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NotificationText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TimerText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Focuspage.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartTimer);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Focuspage.xaml"
            this.PauseButton.Click += new System.Windows.RoutedEventHandler(this.PauseTimer);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ResetButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Focuspage.xaml"
            this.ResetButton.Click += new System.Windows.RoutedEventHandler(this.ResetTimer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

