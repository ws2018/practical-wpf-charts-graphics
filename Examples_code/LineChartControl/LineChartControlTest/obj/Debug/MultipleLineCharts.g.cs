﻿#pragma checksum "..\..\MultipleLineCharts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1DF459951686803362C17787B28784F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LineChartControl;
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


namespace LineChartControlTest {
    
    
    /// <summary>
    /// MultipleLineCharts
    /// </summary>
    public partial class MultipleLineCharts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MultipleLineCharts.xaml"
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MultipleLineCharts.xaml"
        internal LineChartControl.LineChartControlLib myLineChart1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MultipleLineCharts.xaml"
        internal System.Windows.Controls.Grid grid2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MultipleLineCharts.xaml"
        internal LineChartControl.LineChartControlLib myLineChart2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MultipleLineCharts.xaml"
        internal System.Windows.Controls.Grid grid3;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MultipleLineCharts.xaml"
        internal LineChartControl.LineChartControlLib myLineChart3;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MultipleLineCharts.xaml"
        internal System.Windows.Controls.Grid grid4;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MultipleLineCharts.xaml"
        internal LineChartControl.LineChartControlLib myLineChart4;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LineChartControlTest;component/multiplelinecharts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MultipleLineCharts.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            
            #line 16 "..\..\MultipleLineCharts.xaml"
            this.grid1.SizeChanged += new System.Windows.SizeChangedEventHandler(this.grid1_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myLineChart1 = ((LineChartControl.LineChartControlLib)(target));
            return;
            case 3:
            this.grid2 = ((System.Windows.Controls.Grid)(target));
            
            #line 21 "..\..\MultipleLineCharts.xaml"
            this.grid2.SizeChanged += new System.Windows.SizeChangedEventHandler(this.grid2_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.myLineChart2 = ((LineChartControl.LineChartControlLib)(target));
            return;
            case 5:
            this.grid3 = ((System.Windows.Controls.Grid)(target));
            
            #line 26 "..\..\MultipleLineCharts.xaml"
            this.grid3.SizeChanged += new System.Windows.SizeChangedEventHandler(this.grid3_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.myLineChart3 = ((LineChartControl.LineChartControlLib)(target));
            return;
            case 7:
            this.grid4 = ((System.Windows.Controls.Grid)(target));
            
            #line 31 "..\..\MultipleLineCharts.xaml"
            this.grid4.SizeChanged += new System.Windows.SizeChangedEventHandler(this.grid4_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.myLineChart4 = ((LineChartControl.LineChartControlLib)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}