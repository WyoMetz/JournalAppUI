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
            Entries = ListCreate();
            EntryList.ItemsSource = Entries;
        }

        public List<string> ListCreate()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                list.Add($"New Entry Title{i}");
            }
            return list;
        }

        public void NavigateToNew()
        {
            this.NavigationService.Navigate(new Uri(@"Pages\NewEntryView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void NewEntry_Click(object sender, RoutedEventArgs e)
        {
            NavigateToNew();
        }
    }
}
