﻿#pragma checksum "..\..\..\Windows\PublishDriverWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "015C3D7EBCFDACBD78DF195F11433F4EB3BC6FA8BE80B1EA16FA68F682D38555"
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
    /// PublishDriverPage
    /// </summary>
    public partial class PublishDriverPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCityDeparture;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboStreetDeparture;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCityArrival;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboStreetArrival;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpData;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCountPeople;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrice;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescription;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\PublishDriverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSend;
        
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
            System.Uri resourceLocater = new System.Uri("/MotorDepot;component/windows/publishdriverwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\PublishDriverWindow.xaml"
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
            this.comboCityDeparture = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Windows\PublishDriverWindow.xaml"
            this.comboCityDeparture.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboCityDeparture_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboStreetDeparture = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.comboCityArrival = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\Windows\PublishDriverWindow.xaml"
            this.comboCityArrival.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboCityArrival_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboStreetArrival = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.dpData = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.tbCountPeople = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnSend = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Windows\PublishDriverWindow.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.btnSend_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

