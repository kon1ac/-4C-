﻿#pragma checksum "..\..\TakeTestForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB59F92D520DE8252C321F53493E996C93F8B5055FE56903DC6C08EB012B6EF9"
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


namespace MagicPartik4C_ {
    
    
    /// <summary>
    /// TakeTestForm
    /// </summary>
    public partial class TakeTestForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\TakeTestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock titleLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TakeTestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descriptionLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TakeTestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button option1Button;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TakeTestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button option2Button;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TakeTestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button option3Button;
        
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
            System.Uri resourceLocater = new System.Uri("/MagicPartik4C#;component/taketestform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TakeTestForm.xaml"
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
            this.titleLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.descriptionLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.option1Button = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\TakeTestForm.xaml"
            this.option1Button.Click += new System.Windows.RoutedEventHandler(this.OptionButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.option2Button = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\TakeTestForm.xaml"
            this.option2Button.Click += new System.Windows.RoutedEventHandler(this.OptionButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.option3Button = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\TakeTestForm.xaml"
            this.option3Button.Click += new System.Windows.RoutedEventHandler(this.OptionButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

