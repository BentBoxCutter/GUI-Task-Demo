using System;
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
    /// Interaction logic for NewRestaurantFinder.xaml
    /// </summary>
    public partial class NewRestaurantFinder : Window
    {
        public NewRestaurantFinder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CookieFinder cf = new CookieFinder();
            cf.Show();
        }

        private void FilterClick(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["OpenMenu"] as Storyboard;
            sb.Begin(FilterMenu);
            sb = Resources["FadeDark"] as Storyboard;
            sb.Begin(MainMenu);
            WalmartButton.IsEnabled = false;
            WalmartButton.Opacity = 0.5;
            FredMeyerButton.IsEnabled = false;
            FredMeyerButton.Opacity = 0.5;
            SubwayButton.IsEnabled = false;
            SubwayButton.Opacity = 0.5;
        }

        private void FilterCloseClick(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["CloseMenu"] as Storyboard;
            sb.Begin(FilterMenu);
            sb = Resources["FadeLight"] as Storyboard;
            sb.Begin(MainMenu);
            WalmartButton.IsEnabled = true;
            WalmartButton.Opacity = 1;
            FredMeyerButton.IsEnabled = true;
            FredMeyerButton.Opacity = 1;
            SubwayButton.IsEnabled = true;
            SubwayButton.Opacity = 1;
        }
    }
}
