﻿using System;
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
    /// Interaction logic for NewEntryView.xaml
    /// </summary>
    public partial class NewEntryView : Page
    {
        //TODO: Instaniate a new Entry Object.

        public NewEntryView()
        {
            InitializeComponent();
        }

        private void DialogHost_DialogClosing(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {
            //TODO: Save Location Info
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Save all Entry Items.
            SnackbarThree.MessageQueue.Enqueue("Save Button Clicked.");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri(@"Pages\EntryView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
