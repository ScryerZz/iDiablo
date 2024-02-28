using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
        SoundPlayer sp;
        public MainMenu(SoundPlayer player)
        {
            InitializeComponent();
            sp = player;
        }

        private void SinglePlayer_Click(object sender, RoutedEventArgs e)
        {
            //Thread.Sleep(500);
            //NavigationService.Navigate(new SinglePlayer());
        }

        private void MultiPlayer_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new MultiPlayer());
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new SettingsMenu());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new CreditsPage());
        }

        private void MuteMusic_Click(object sender, RoutedEventArgs e)
        {
            //if (Convert.ToString(MuteMusic.Content) == "🔉")
            //{
            //    sp.Stop();
            //    MuteMusic.Content = "🔇";
            //}
            //else
            //{
            //    sp.PlayLooping();
            //    MuteMusic.Content = "🔉";
            //}
        }

        private void DoubleAnimation_Completed_SP(object sender, EventArgs e)
        {
            NavigationService.Navigate(new ClassSelection());
        }

        private void DoubleAnimation_Completed_MP(object sender, EventArgs e)
        {
            NavigationService.Navigate(new MultiPlayer());
        }

        private void DoubleAnimation_Completed_Set(object sender, EventArgs e)
        {
            NavigationService.Navigate(new SettingsMenu());
        }

        private void DoubleAnimation_Completed_Ex(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DoubleAnimation_Completed_Cred(object sender, EventArgs e)
        {
            NavigationService.Navigate(new CreditsPage());
        }

        private void DoubleAnimation_Completed_MM(object sender, EventArgs e)
        {
            if (Convert.ToString(MuteMusic.Content) == "🔉")
            {
                sp.Stop();
                MuteMusic.Content = "🔇";
            }
            else
            {
                sp.PlayLooping();
                MuteMusic.Content = "🔉";
            }
        }
    }
}
