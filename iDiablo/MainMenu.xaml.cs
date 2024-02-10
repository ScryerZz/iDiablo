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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace iDiablo
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SinglePlay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SinglePlayer());
        }

        private void MultiPlayer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MultiPlayer());
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsMenu());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreditsPage());
        }
    }
}
