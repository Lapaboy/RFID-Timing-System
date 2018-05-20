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
using Core;
using Presentation.WPF.ViewModels;


namespace Presentation.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            // manager.ConnectDevice();
            // manager.TagCatch += manager_tagCatchHandler;
        }

        /*static void manager_tagCatchHandler(object sender, TagCatchEventArgs e)
        {
            RFIDTag tag = e.Tag;
            Console.WriteLine(tag.UID);
        }*/
    }
}