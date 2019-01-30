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

namespace JournalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(new Uri(@"Pages\LogIn.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        

        public void Navigation(string Uri)
        {
           ContentFrame.Navigate(new Uri(Uri, UriKind.RelativeOrAbsolute));
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            Navigation(@"Pages\UserInfoView.xaml");
        }

        private void TopBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
