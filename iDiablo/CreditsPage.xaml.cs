using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для CreditsPage.xaml
    /// </summary>
    public partial class CreditsPage : Page
    {
        public CreditsPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.GoBack();
        }

        private void GitHub_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start(new ProcessStartInfo("https://github.com/ScryerZz") { UseShellExecute = true });
        }

        private void DoubleAnimation_Completed_Back(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void DoubleAnimation_Completed_Git(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ScryerZz") { UseShellExecute = true });
        }
    }           
}
