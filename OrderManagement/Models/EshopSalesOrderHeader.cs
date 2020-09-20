using System;
using System.Collections.Generic;
using System.Text;
using Uniconta.Common;
using Uniconta.DataModel;

namespace OrderManagement.Models
{
    public class EshopSalesOrderHeader : TableDataWithKey
    {
        public override int UserDefinedId { get { return 50203; } }

        public string eSalesNumber
        {
            get { return this.GetUserFieldString(0); }
            set { this.SetUserFieldString(0, value); NotifyPropertyChanged("eSalesNumber"); }
        }

        public string SalesNumber
        {
            get { return this.GetUserFieldString(1); }
            set { this.SetUserFieldString(1, value); NotifyPropertyChanged("SalesNumber"); }
        }

        public string CustAccount
        {
            get { return this.GetUserFieldString(2); }
            set { this.SetUserFieldString(2, value); NotifyPropertyChanged("CustAccount"); }
        }

        public string ContactId
        {
            get { return this.GetUserFieldString(3); }
            set { this.SetUserFieldString(3, value); NotifyPropertyChanged("ContactId"); }
        }

        public string ProfileID
        {
            get { return this.GetUserFieldString(4); }
            set { this.SetUserFieldString(4, value); NotifyPropertyChanged("ProfileID"); }
        }

        public string ShopId
        {
            get { return this.GetUserFieldString(5); }
            set { this.SetUserFieldString(5, value); NotifyPropertyChanged("ShopId"); }
        }

        public string PriceGroup
        {
            get { return this.GetUserFieldString(6); }
            set { this.SetUserFieldString(6, value); NotifyPropertyChanged("PriceGroup"); }
        }

        public string WareHouse
        {
            get { return this.GetUserFieldString(7); }
            set { this.SetUserFieldString(7, value); NotifyPropertyChanged("WareHouse"); }
        }

        public string DiscGroup
        {
            get { return this.GetUserFieldString(8); }
            set { this.SetUserFieldString(8, value); NotifyPropertyChanged("DiscGroup"); }
        }

        public string Currency
        {
            get { return this.GetUserFieldString(9); }
            set { this.SetUserFieldString(9, value); NotifyPropertyChanged("Currency"); }
        }

        public string PaymentId
        {
            get { return this.GetUserFieldString(10); }
            set { this.SetUserFieldString(10, value); NotifyPropertyChanged("PaymentId"); }
        }

        public string Payment
        {
            get { return this.GetUserFieldString(11); }
            set { this.SetUserFieldString(11, value); NotifyPropertyChanged("Payment"); }
        }

        public string DeliveryMode
        {
            get { return this.GetUserFieldString(12); }
            set { this.SetUserFieldString(12, value); NotifyPropertyChanged("DeliveryMode"); }
        }

        public string VatCode
        {
            get { return this.GetUserFieldString(13); }
            set { this.SetUserFieldString(13, value); NotifyPropertyChanged("VatCode"); }
        }

        public DateTime CreateDate
        {
            get { return this.GetUserFieldDateTime(14); }
            set { this.SetUserFieldDateTime(14, value); NotifyPropertyChanged("CreateDate"); }
        }

        public long Status
        {
            get { return this.GetUserFieldInt64(15); }
            set { this.SetUserFieldInt64(15, value); NotifyPropertyChanged("Status"); }
        }

        public string Requisition
        {
            get { return this.GetUserFieldString(16); }
            set { this.SetUserFieldString(16, value); NotifyPropertyChanged("Requisition"); }
        }

        public string EREFERENCENUMBER
        {
            get { return this.GetUserFieldString(17); }
            set { this.SetUserFieldString(17, value); NotifyPropertyChanged("EREFERENCENUMBER"); }
        }

        public DateTime LastChanged
        {
            get { return this.GetUserFieldDateTime(18); }
            set { this.SetUserFieldDateTime(18, value); NotifyPropertyChanged("LastChanged"); }
        }

        public string Name
        {
            get { return this.GetUserFieldString(19); }
            set { this.SetUserFieldString(19, value); NotifyPropertyChanged("Name"); }
        }

        public string Debtoratt
        {
            get { return this.GetUserFieldString(20); }
            set { this.SetUserFieldString(20, value); NotifyPropertyChanged("Debtoratt"); }
        }

        public string Address1
        {
            get { return this.GetUserFieldString(21); }
            set { this.SetUserFieldString(21, value); NotifyPropertyChanged("Address1"); }
        }

        public string Address2
        {
            get { return this.GetUserFieldString(22); }
            set { this.SetUserFieldString(22, value); NotifyPropertyChanged("Address2"); }
        }

        public string zipcode
        {
            get { return this.GetUserFieldString(23); }
            set { this.SetUserFieldString(23, value); NotifyPropertyChanged("zipcode"); }
        }

        public string Address3
        {
            get { return this.GetUserFieldString(24); }
            set { this.SetUserFieldString(24, value); NotifyPropertyChanged("Address3"); }
        }

        public string region
        {
            get { return this.GetUserFieldString(25); }
            set { this.SetUserFieldString(25, value); NotifyPropertyChanged("region"); }
        }

        public string Country
        {
            get { return this.GetUserFieldString(26); }
            set { this.SetUserFieldString(26, value); NotifyPropertyChanged("Country"); }
        }

        public string Phone
        {
            get { return this.GetUserFieldString(27); }
            set { this.SetUserFieldString(27, value); NotifyPropertyChanged("Phone"); }
        }

        public string Email
        {
            get { return this.GetUserFieldString(28); }
            set { this.SetUserFieldString(28, value); NotifyPropertyChanged("Email"); }
        }

        public string dlvName
        {
            get { return this.GetUserFieldString(29); }
            set { this.SetUserFieldString(29, value); NotifyPropertyChanged("dlvName"); }
        }

        public string DeliveryAtt
        {
            get { return this.GetUserFieldString(30); }
            set { this.SetUserFieldString(30, value); NotifyPropertyChanged("DeliveryAtt"); }
        }

        public string dlvAddress1
        {
            get { return this.GetUserFieldString(31); }
            set { this.SetUserFieldString(31, value); NotifyPropertyChanged("dlvAddress1"); }
        }

        public string dlvAddress2
        {
            get { return this.GetUserFieldString(32); }
            set { this.SetUserFieldString(32, value); NotifyPropertyChanged("dlvAddress2"); }
        }

        public string dlvzipcode
        {
            get { return this.GetUserFieldString(33); }
            set { this.SetUserFieldString(33, value); NotifyPropertyChanged("dlvzipcode"); }
        }

        public string dlvAddress3
        {
            get { return this.GetUserFieldString(34); }
            set { this.SetUserFieldString(34, value); NotifyPropertyChanged("dlvAddress3"); }
        }

        public string dlvCountry
        {
            get { return this.GetUserFieldString(35); }
            set { this.SetUserFieldString(35, value); NotifyPropertyChanged("dlvCountry"); }
        }

        public string PaymentText
        {
            get { return this.GetUserFieldString(36); }
            set { this.SetUserFieldString(36, value); NotifyPropertyChanged("PaymentText"); }
        }

        public string DeliveryText
        {
            get { return this.GetUserFieldString(37); }
            set { this.SetUserFieldString(37, value); NotifyPropertyChanged("DeliveryText"); }
        }

        public bool PriceInclVat
        {
            get { return this.GetUserFieldBoolean(38); }
            set { this.SetUserFieldBoolean(38, value); NotifyPropertyChanged("PriceInclVat"); }
        }

        public string Delivery
        {
            get { return this.GetUserFieldString(39); }
            set { this.SetUserFieldString(39, value); NotifyPropertyChanged("Delivery"); }
        }

        public double SUBTOTALAMOUNT
        {
            get { return this.GetUserFieldDouble(40); }
            set { this.SetUserFieldDouble(40, value); NotifyPropertyChanged("SUBTOTALAMOUNT"); }
        }

        public double VatAmount
        {
            get { return this.GetUserFieldDouble(41); }
            set { this.SetUserFieldDouble(41, value); NotifyPropertyChanged("VatAmount"); }
        }

        public double InvoiceAmount
        {
            get { return this.GetUserFieldDouble(42); }
            set { this.SetUserFieldDouble(42, value); NotifyPropertyChanged("InvoiceAmount"); }
        }

        public long Lines
        {
            get { return this.GetUserFieldInt64(43); }
            set { this.SetUserFieldInt64(43, value); NotifyPropertyChanged("Lines"); }
        }

        public long eshop
        {
            get { return this.GetUserFieldInt64(44); }
            set { this.SetUserFieldInt64(44, value); NotifyPropertyChanged("eshop"); }
        }

        public DateTime DeliveryDate
        {
            get { return this.GetUserFieldDateTime(45); }
            set { this.SetUserFieldDateTime(45, value); NotifyPropertyChanged("DeliveryDate"); }
        }

        public string ErrorStatus
        {
            get { return this.GetUserFieldString(46); }
            set { this.SetUserFieldString(46, value); NotifyPropertyChanged("ErrorStatus"); }
        }
    }
}
