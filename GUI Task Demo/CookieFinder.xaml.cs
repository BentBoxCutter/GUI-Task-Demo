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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_Task_Demo
{
    /// <summary>
    /// Interaction logic for CookieFinder.xaml
    /// </summary>
    public partial class CookieFinder : Window
    {
        public CookieFinder()
        {
            InitializeComponent();
        }

        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            OrderDetails od = new OrderDetails();
            od.Show();
        }

        private void FilterClick(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["OpenMenu"] as Storyboard;
            sb.Begin(FilterMenu);
            sb = Resources["FadeDark"] as Storyboard;
            sb.Begin(MainMenu);
            ChocolateChipButton.IsEnabled = false;
            ChocolateChipButton.Opacity = 0.5;
            PeanutButterButton.IsEnabled = false;
            PeanutButterButton.Opacity = 0.5;
        }

        private void FilterCloseClick(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["CloseMenu"] as Storyboard;
            sb.Begin(FilterMenu);
            sb = Resources["FadeLight"] as Storyboard;
            sb.Begin(MainMenu);
            ChocolateChipButton.IsEnabled = true;
            ChocolateChipButton.Opacity = 1;
            PeanutButterButton.IsEnabled = true;
            PeanutButterButton.Opacity = 1;
        }

        private void GotoMainMenu(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
