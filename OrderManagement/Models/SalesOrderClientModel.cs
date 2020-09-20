using System.Collections.Generic;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;

namespace evision.Etrade5.Models.UnicontaExtensions
{
    public class DebtorOrderClientModel : DebtorOrderClient
    {
        public string eShopSalesNumber
        {
            get { return ((GetUserField("eShopSalesNumber") != null) ? GetUserField("eShopSalesNumber").ToString() : ""); }
            set { this.SetUserField("eShopSalesNumber", value); }
        }

        public string eShopPaymentId
        {
            get { return ((GetUserField("eShopPaymentId") != null) ? GetUserField("eShopPaymentId").ToString() : ""); }
            set { this.SetUserField("eShopPaymentId", value); }
        }

        public string eShopShopId
        {
            get { return ((GetUserField("eShopShopId") != null) ? GetUserField("eShopShopId").ToString() : ""); }
            set { this.SetUserField("eShopShopId", value); }
        }
    }
}
