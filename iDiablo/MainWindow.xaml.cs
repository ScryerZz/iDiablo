using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            frame.NavigationService.Navigate(new MainMenu(sp));
            sp.SoundLocation = "Musics/musicMenu.wav";
            sp.Load();
            sp.PlayLooping();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MainMenu mainMenu = new MainMenu();
        //    mainMenu.Show();
        //    Close();
        //}
    }
}
