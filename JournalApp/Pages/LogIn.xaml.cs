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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        //TODO: Check User Values

        public LogIn()
        {
            InitializeComponent();
        }

        private void UserLogIn_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Check input
            this.NavigationService.Navigate(new Uri(@"Pages\EntryView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void NewUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri(@"Pages\CreateUser.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
