﻿#pragma checksum "..\..\WindowAddingVoiceActingFromAMicrophone.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FDE3E3C10FBB67160483FDC38F67422C0DF0D37A8B1490021E2084A1092180A9"
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
using TaskNumberFourFillingTheArrayWithADatabase;


namespace TaskNumberFourFillingTheArrayWithADatabase {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class TaskNumberFourFillingTheArrayWithADatabase : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartReconding;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopRecording;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayTheRecording;
        
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
            System.Uri resourceLocater = new System.Uri("/TaskNumberFourFillingTheArrayWithADatabase;component/windowaddingvoiceactingfrom" +
                    "amicrophone.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
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
            this.StartReconding = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
            this.StartReconding.Click += new System.Windows.RoutedEventHandler(this.StartReconding_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StopRecording = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
            this.StopRecording.Click += new System.Windows.RoutedEventHandler(this.StopRecording_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlayTheRecording = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\WindowAddingVoiceActingFromAMicrophone.xaml"
            this.PlayTheRecording.Click += new System.Windows.RoutedEventHandler(this.PlayTheRecording_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
