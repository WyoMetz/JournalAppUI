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
    /// Interaction logic for EntryView.xaml
    /// </summary>
    public partial class EntryView : Page
    {
        List<string> Entries = new List<string>();
        public EntryView()
        {
            InitializeComponent();
            Application.Current.Resources["GridVisibility"] = Visibility.Visible;
        }

        private void NewEntry_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri(@"Pages\NewEntryView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void EntryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: Load in the Selected Entry
            //TitleText.Text =
            //DateText.Text =
            //LocationText.Text = 
        }

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {
            SnackbarThree.MessageQueue.Enqueue("Save Edit Clicked");
            //TODO: Save The Edit
        }
    }
}
