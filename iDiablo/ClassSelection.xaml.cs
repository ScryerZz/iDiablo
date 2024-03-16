using iDiablo.Units;
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
    /// Логика взаимодействия для ClassSelection.xaml
    /// </summary>
    public partial class ClassSelection : Page
    {
        public ClassSelection()
        {
            InitializeComponent();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        private void Warrior_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri uri = new Uri("/Images/Classes/warrior.png", UriKind.Relative);
            hero.Source = new BitmapImage(uri);
        }
        private void Rogue_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri uri = new Uri("/Images/Classes/rogue.png", UriKind.Relative);
            hero.Source = new BitmapImage(uri);
        }
        private void Wizard_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri uri = new Uri("/Images/Classes/wizard.png", UriKind.Relative);
            hero.Source = new BitmapImage(uri);
        }

        private void DoubleAnimation_Completed_War(object sender, EventArgs e)
        {
            NavigationService.Navigate(new SinglePlayer());
            App.Current.Resources["HeroClass"] = warrior.Content;
        }

        private void DoubleAnimation_Completed_Rog(object sender, EventArgs e)
        {
            NavigationService.Navigate(new SinglePlayer());
            App.Current.Resources["HeroClass"] = rogue.Content;
        }

        private void DoubleAnimation_Completed_Wiz(object sender, EventArgs e)
        {
            NavigationService.Navigate(new SinglePlayer());
            App.Current.Resources["HeroClass"] = wizard.Content;
        }
        private void DoubleAnimation_Completed_Back(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
