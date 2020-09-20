using System;
using System.Collections.Generic;
using System.Text;
using Uniconta.DataModel;

namespace OrderManagement.Models
{
    public class EshopSalesOrderLines : TableDataWithKey
    {
        public override int UserDefinedId { get { return 50213; } }

        public string eSalesNumber
        {
            get { return this.GetUserFieldString(0); }
            set { this.SetUserFieldString(0, value); NotifyPropertyChanged("eSalesNumber"); }
        }

        public long LINETYPE
        {
            get { return this.GetUserFieldInt64(1); }
            set { this.SetUserFieldInt64(1, value); NotifyPropertyChanged("LINETYPE"); }
        }

        public long LineNumber
        {
            get { return this.GetUserFieldInt64(2); }
            set { this.SetUserFieldInt64(2, value); NotifyPropertyChanged("LineNumber"); }
        }

        public string ItemNumber
        {
            get { return this.GetUserFieldString(3); }
            set { this.SetUserFieldString(3, value); NotifyPropertyChanged("ItemNumber"); }
        }

        public string Variant1
        {
            get { return this.GetUserFieldString(4); }
            set { this.SetUserFieldString(4, value); NotifyPropertyChanged("Variant1"); }
        }

        public string Variant2
        {
            get { return this.GetUserFieldString(5); }
            set { this.SetUserFieldString(5, value); NotifyPropertyChanged("Variant2"); }
        }

        public string Variant3
        {
            get { return this.GetUserFieldString(6); }
            set { this.SetUserFieldString(6, value); NotifyPropertyChanged("Variant3"); }
        }

        public string VatCode
        {
            get { return this.GetUserFieldString(7); }
            set { this.SetUserFieldString(7, value); NotifyPropertyChanged("VatCode"); }
        }

        public DateTime DeliveryDate
        {
            get { return this.GetUserFieldDateTime(8); }
            set { this.SetUserFieldDateTime(8, value); NotifyPropertyChanged("DeliveryDate"); }
        }

        public DateTime LastChanged
        {
            get { return this.GetUserFieldDateTime(9); }
            set { this.SetUserFieldDateTime(9, value); NotifyPropertyChanged("LastChanged"); }
        }

        public string ItemDescription
        {
            get { return this.GetUserFieldString(10); }
            set { this.SetUserFieldString(10, value); NotifyPropertyChanged("ItemDescription"); }
        }

        public string Unitcode
        {
            get { return this.GetUserFieldString(11); }
            set { this.SetUserFieldString(11, value); NotifyPropertyChanged("Unitcode"); }
        }

        public long qty
        {
            get { return this.GetUserFieldInt64(12); }
            set { this.SetUserFieldInt64(12, value); NotifyPropertyChanged("qty"); }
        }

        public long QtyDecimals
        {
            get { return this.GetUserFieldInt64(13); }
            set { this.SetUserFieldInt64(13, value); NotifyPropertyChanged("QtyDecimals"); }
        }

        public long PriceUnit
        {
            get { return this.GetUserFieldInt64(14); }
            set { this.SetUserFieldInt64(14, value); NotifyPropertyChanged("PriceUnit"); }
        }

        public double salesprice
        {
            get { return this.GetUserFieldDouble(15); }
            set { this.SetUserFieldDouble(15, value); NotifyPropertyChanged("salesprice"); }
        }

        public long LineDiscAmount
        {
            get { return this.GetUserFieldInt64(16); }
            set { this.SetUserFieldInt64(16, value); NotifyPropertyChanged("LineDiscAmount"); }
        }

        public long LineDiscPct
        {
            get { return this.GetUserFieldInt64(17); }
            set { this.SetUserFieldInt64(17, value); NotifyPropertyChanged("LineDiscPct"); }
        }

        public double VatAmount
        {
            get { return this.GetUserFieldDouble(18); }
            set { this.SetUserFieldDouble(18, value); NotifyPropertyChanged("VatAmount"); }
        }

        public double LineAmount
        {
            get { return this.GetUserFieldDouble(19); }
            set { this.SetUserFieldDouble(19, value); NotifyPropertyChanged("LineAmount"); }
        }

        public string LineNote
        {
            get { return this.GetUserFieldString(20); }
            set { this.SetUserFieldString(20, value); NotifyPropertyChanged("LineNote"); }
        }
    }
}
