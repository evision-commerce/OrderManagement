using OrderManagement.DataAccess;
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
    /// Interaction logic for LinesEShopSalesOrder.xaml
    /// </summary>
    public partial class EShopSalesOrderLines : Page
    {
        public EShopSalesOrderLines()
        {
            InitializeComponent();
            App.ParentWindow.ParentFrame.LoadCompleted += EshopSalesOrderLines_Loaded;
        }
        void EshopSalesOrderLines_Loaded(object sender, NavigationEventArgs e)
        {
            var eSalesNumber = (string)e.ExtraData;
            dataGrid.ItemsSource = SalesOrderAccess.GetEshopSalesOrderLines(eSalesNumber);
        }
    }
}
