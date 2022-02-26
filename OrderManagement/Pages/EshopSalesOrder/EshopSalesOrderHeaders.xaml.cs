using OrderManagement.DataAccess;
using OrderManagement.Models;
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

namespace OrderManagement.Pages.EshopSalesOrder
{
    /// <summary>
    /// Interaction logic for EditEshopSalesOrder.xaml
    /// </summary>
    public partial class EshopSalesOrderHeaders : Page
    {
        public EshopSalesOrderHeaders()
        {
            InitializeComponent();
            App.ParentWindow.ParentFrame.LoadCompleted += EditEshopSalesOrder_Loaded;
        }
        void EditEshopSalesOrder_Loaded(object sender, NavigationEventArgs e)
        {
            var eSalesNumber = (string)e.ExtraData;
            this.DataContext = SalesOrderAccess.GetEshopSalesOrderHeader(eSalesNumber);
        }
        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            var eSalesNumber = ((Button)sender)?.Tag?.ToString();
            if (!string.IsNullOrEmpty(eSalesNumber))
              //  && Helpers.EshopSalesOrderHeaderESalesNumbers?.Contains(eSalesNumber) == false)
            {
               // Helpers.EshopSalesOrderHeaderESalesNumbers?.Add(eSalesNumber);
               var eshopSalesOrder =  SalesOrderAccess.GetEshopSalesOrderHeader(eSalesNumber);
                if (eshopSalesOrder != null)
                {
                    eshopSalesOrder.Status = 1;
                    SalesOrderAccess.UpdatetEshopSalesOrderHeader(eshopSalesOrder);
                }
            }
            //App.ParentWindow.ParentFrame.Navigate(new EshopOrders());
            App.ParentWindow.ParentFrame.GoBack();
        }

        private void BtnDeny_Click(object sender, RoutedEventArgs e)
        {
            var eSalesNumber = ((Button)sender)?.Tag?.ToString();
            if (!string.IsNullOrEmpty(eSalesNumber))
            {
                SalesOrderAccess.DeletetEshopSalesOrderHeader(SalesOrderAccess.GetEshopSalesOrderHeader(eSalesNumber));
                //Helpers.EshopSalesOrderHeaderESalesNumbers?.Remove(eSalesNumber);
            }
            App.ParentWindow.ParentFrame.GoBack();
        }
    }
}
