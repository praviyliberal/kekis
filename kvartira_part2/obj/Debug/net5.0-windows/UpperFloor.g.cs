﻿#pragma checksum "..\..\..\UpperFloor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F815FCAFF2345F3645D60E1F73C04BC78656259"
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
using kvartira_part2;


namespace kvartira_part2 {
    
    
    /// <summary>
    /// UpperFloor
    /// </summary>
    public partial class UpperFloor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UpperFloor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpFloorPaycheckButton_upfloor;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\UpperFloor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_upfloor;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UpperFloor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox upfloorPayTxb_upfloor;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UpperFloor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2_upfloor;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UpperFloor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox upfloorFinaleTxb_upfloor;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/kvartira_part2;component/upperfloor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpperFloor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UpFloorPaycheckButton_upfloor = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\UpperFloor.xaml"
            this.UpFloorPaycheckButton_upfloor.Click += new System.Windows.RoutedEventHandler(this.FloorPaycheckButton_floor_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1_upfloor = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.upfloorPayTxb_upfloor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label2_upfloor = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.upfloorFinaleTxb_upfloor = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

