﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace savicehv20pr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public enum pages
        {
            settings
        }

        public OpenPage(pages _pages)
        {
            if (_pages == pages.settings)
                frame.Navigate(new Pages.Settings(this));
        }
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.settings);
        }
    }
}
