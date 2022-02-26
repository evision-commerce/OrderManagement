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
    /// Interaction logic for EshopOrdersWindow.xaml
    /// </summary>
    public partial class EshopOrders : Page
    {
        public static List<EshopSalesOrderHeader> acceptedOrdersArray;
        public EshopOrders()
        {
            InitializeComponent();
            App.ParentWindow.ParentFrame.LoadCompleted += DebitorAccount_Loaded;
        }
        void DebitorAccount_Loaded(object sender, NavigationEventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            busyIndicator.IsBusy = true;
            var collection = SalesOrderAccess.GetEshopSalesOrderHeaders();
            dataGrid.ItemsSource = collection;
            busyIndicator.IsBusy = false;
        }

        private void EditEShopOrder(object sender, RoutedEventArgs e)
        {
            var eSalesNumber = ((Button)sender)?.Tag?.ToString();
            App.ParentWindow.ParentFrame.Navigate(new EshopSalesOrderHeaders(), eSalesNumber);

        }

        private void LinesEShopOrder(object sender, RoutedEventArgs e)
        {
            var eSalesNumber = ((Button)sender)?.Tag?.ToString();
            App.ParentWindow.ParentFrame.Navigate(new EShopSalesOrderLines(), eSalesNumber);
        }


        //private void AcceptOrders_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        var eshopSalesOrderHeadersArray = Helpers.EshopSalesOrderHeaderESalesNumbers;
        //        var collection = (IEnumerable<EshopSalesOrderHeader>)dataGrid.ItemsSource;
        //        if (eshopSalesOrderHeadersArray?.Any() == true && collection?.Any() == true)
        //        {
        //            collection = collection?.Where(x => !string.IsNullOrEmpty(x?.eSalesNumber) && eshopSalesOrderHeadersArray?.Contains(x?.eSalesNumber?.Trim()) == true)
        //                ?.GroupBy(p => p?.eSalesNumber)?.Select(x => x?.FirstOrDefault());
        //            if (collection?.Any() == true)
        //            {
        //                 SalesOrderAccess.InsertEshopSalesOrderHeaders(collection?.ToArray());
        //                //SalesOrderAccess.InsertSalesOrderHeaders(collection?.ToArray());
        //            }
        //        }
        //    }
        //    catch (Exception ex) 
        //    {
        //    }
        //}

        private void AcceptOrders_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var collection = (IEnumerable<EshopSalesOrderHeader>)SalesOrderAccess.GetAcceptedEshopSalesOrderHeaders();
                if (collection?.Any() == true)
                {
                    collection = collection?.Where(x => !string.IsNullOrEmpty(x?.eSalesNumber))
                        ?.GroupBy(p => p?.eSalesNumber)?.Select(x => x?.FirstOrDefault());
                    if (collection?.Any() == true)
                    {
                        SalesOrderAccess.InsertEshopSalesOrderHeaders(collection?.ToArray());
                        //SalesOrderAccess.InsertSalesOrderHeaders(collection?.ToArray());
                    }
                }
            }
            catch (Exception)
            { 
           
            }
        }
    }
}
