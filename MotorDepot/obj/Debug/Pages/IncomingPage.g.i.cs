﻿#pragma checksum "..\..\..\Pages\IncomingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3300E77BC618BAE48E42BD7A4CD9B38E5E75A8F9CBF19C08C9621D4A39079D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MotorDepot;
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


namespace MotorDepot {
    
    
    /// <summary>
    /// IncomingPage
    /// </summary>
    public partial class IncomingPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbDataClients;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvRequestsClients;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbDataMy;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvMyRequests;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbRequestClient;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMyRequest;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\IncomingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/MotorDepot;component/pages/incomingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\IncomingPage.xaml"
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
            this.tbDataClients = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.lvRequestsClients = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.tbDataMy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lvMyRequests = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.rbRequestClient = ((System.Windows.Controls.RadioButton)(target));
            
            #line 89 "..\..\..\Pages\IncomingPage.xaml"
            this.rbRequestClient.Click += new System.Windows.RoutedEventHandler(this.rbRequestClient_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rbMyRequest = ((System.Windows.Controls.RadioButton)(target));
            
            #line 90 "..\..\..\Pages\IncomingPage.xaml"
            this.rbMyRequest.Click += new System.Windows.RoutedEventHandler(this.rbMyRequest_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\Pages\IncomingPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 45 "..\..\..\Pages\IncomingPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSelect_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 80 "..\..\..\Pages\IncomingPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnRevoke_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

