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
using System.Windows.Shapes;

namespace GUI_Task_Demo
{
    /// <summary>
    /// Interaction logic for RestarauntFInder.xaml
    /// </summary>
    public partial class RestarauntFInder : Window
    {
        public RestarauntFInder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CookieFinder cf = new CookieFinder();
            cf.Show();
        }
    }
}
