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


namespace OrderManagement.Pages.SalesOrder
{
    /// <summary>
    /// Interaction logic for SalesOrdersWindow.xaml
    /// </summary>
    public partial class SalesOrders : Page
    {
        public SalesOrders()
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
            var collection = SalesOrderAccess.GetSalesOrderHeaders();
            dataGrid.ItemsSource = collection;
            busyIndicator.IsBusy = false;
           // SalesOrderAccess.DeleteSalesOrder();
        }


        private void LinesSalesOrder(object sender, RoutedEventArgs e)
        {
            var OrderNumber = ((Button)sender)?.Tag?.ToString();
            App.ParentWindow.ParentFrame.Navigate(new SalesOrdersLines(), OrderNumber);

        }
    }
}
