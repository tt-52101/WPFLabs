﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasingFunctionDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<IEasingFunction> _allEasingFunctions;

        public List<IEasingFunction> AllEasingFunctions
        {
            get { return _allEasingFunctions; }
            set { _allEasingFunctions = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = new MainWindowViewModel();
        }
    }
}
