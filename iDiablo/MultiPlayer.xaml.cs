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
    /// Логика взаимодействия для MultiPlayer.xaml
    /// </summary>
    public partial class MultiPlayer : Page
    {
        public MultiPlayer()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.GoBack();
        }

        private void DoubleAnimation_Completed_Back(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
