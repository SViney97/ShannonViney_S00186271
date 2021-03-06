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

namespace ShannonViney_S00186271
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           var query = from p in db.Phones
                        select new
                        {
                            p.OS_Image,
                            p.Name
                        };
            string selected = LBXPhones.ItemsSource as string; 
        }

        private void LBXPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone Phone = LBXPhones.SelectedItem as Phone;

            if (Phone != null)
            {
                TBLKPrice.Text = Phone.Price.ToString("c");
                IMGPhone.Source = new BitmapImage(new Uri(Phone.Phone_Image, UriKind.RelativeOrAbsolute));
            }
            
        }
    }
}
