﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "15B2D19E2AFD1149750E85794E49EF21BDD64F0757F6252B730349EB7C9C6616"
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ButtonPrevious;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ButtonNext;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ButtonPause;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ButtonPlay;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PlaylistListBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSelectSongs;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider MediaPlayerSlider;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockCurrentTimeSign;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSongDuration;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Again1;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Again;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ButtonPrevious = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.ButtonPrevious.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonPrevious_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonNext = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.ButtonNext.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonNext_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonPause = ((System.Windows.Controls.Image)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.ButtonPause.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonPause_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonPlay = ((System.Windows.Controls.Image)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.ButtonPlay.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonPlay_MouseDown);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MainWindow.xaml"
            this.ButtonPlay.IsEnabledChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.ButtonPlay_IsEnabledChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PlaylistListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.PlaylistListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlaylistListBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 51 "..\..\MainWindow.xaml"
            this.PlaylistListBox.Drop += new System.Windows.DragEventHandler(this.PlaylistListBox_Drop);
            
            #line default
            #line hidden
            
            #line 51 "..\..\MainWindow.xaml"
            this.PlaylistListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PlaylistListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonSelectSongs = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.ButtonSelectSongs.Click += new System.Windows.RoutedEventHandler(this.ButtonSelectSongs_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MediaPlayerSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.MediaPlayerSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.MediaPlayerSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextBlockCurrentTimeSign = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TextBlockSongDuration = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Again1 = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.Again1.Click += new System.Windows.RoutedEventHandler(this.Again1_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Again = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

