﻿using OrderManagement.Pages.EshopSalesOrder;
using OrderManagement.Pages.SalesOrder;
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
using System.Windows.Shapes;

namespace OrderManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.ParentWindow = this;
            await Core.InitializeCore(Helpers.UserName, Helpers.PassWord, Helpers.AccessToken, Helpers.CompanyId);

            if (Helpers.OrderType.Equals("EshopOrders"))
            {
               this.ParentFrame.Navigate(new EshopOrders());
            }
            else
            {
               this.ParentFrame.Navigate(new SalesOrders());
            }
            //this.ParentFrame.Navigate(new SalesOrders());
        }
    }
}
