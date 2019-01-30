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

namespace JournalApp.Pages
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Page
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri(@"Pages\LogIn.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Check Values and Create new User
            this.NavigationService.Navigate(new Uri(@"Pages\LogIn.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
