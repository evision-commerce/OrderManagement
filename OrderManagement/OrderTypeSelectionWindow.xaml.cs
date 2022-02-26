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
    /// Interaction logic for OrderTypeSelection.xaml
    /// </summary>
    public partial class OrderTypeSelectionWindow : Window
    {
        public OrderTypeSelectionWindow()
        {
            InitializeComponent();
            this.salesOrderButton.Click += SalesOrderButton_Click;
            this.eshopsalesOrderButton.Click += EshopsalesOrderButton_Click;
        }
        void SalesOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Helpers.OrderType = "SalesOrders";
            new MainWindow().Show();
            this.Close();
        }
        void EshopsalesOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Helpers.OrderType = "EshopOrders";
            new MainWindow().Show();
            this.Close();
        }
    }
}
