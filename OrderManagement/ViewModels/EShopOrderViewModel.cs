using OrderManagement.DataAccess;
using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.ViewModels
{
    public class EShopOrderViewModel : INotifyPropertyChanged
    {
        public List<EshopSalesOrderHeader> orderList { get; set; }

        private EshopSalesOrderHeader selectedHeader;
        public EshopSalesOrderHeader SelectedHeader
        {
            get { return selectedHeader; }
            set
            {
                selectedHeader = value;
                NotifyPropertyChanged("SelectedHeader");
            }
        }


        public EShopOrderViewModel()
        {
            var elist = new List<EshopSalesOrderHeader>();
            elist = SalesOrderAccess.GetEshopSalesOrderHeaders()?.ToList();
            orderList = elist;

        }

        public void Excute(object header)
        {
            SelectedHeader = (EshopSalesOrderHeader)header;
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

}
