using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Exceptions;
using OrderManagement.Models;
using Uniconta.Common;

namespace OrderManagement.DataAccess
{
    public static class SalesOrderAccess
    {
        public static EshopSalesOrderHeader GetEshopSalesOrderHeader(string esalesOrderId)
        {
            EshopSalesOrderHeader result = null;
            try
            {
                result = Core.QAPI.Query<EshopSalesOrderHeader>(Utils.CRIT.Add("eSalesNumber", esalesOrderId).ValuePairs).Result.First();
            }
            catch (Exception e)
            {
                //TODO logging
                throw new SalesOrderHeaderException($"Error occured while getting eshop sales order header for eSalesNumber: {esalesOrderId}", e);
            }

            return result;
        }

        public static IEnumerable<EshopSalesOrderHeader> GetEshopSalesOrderHeaders()
        {
            EshopSalesOrderHeader[] result = null;
            try
            {
                result = Core.QAPI.Query<EshopSalesOrderHeader>().Result;
            }
            catch (Exception e)
            {
                //TODO logging
                throw new SalesOrderHeaderException($"Error occured while getting eshop sales order headers", e);
            }

            return result;
        }

        public static IEnumerable<EshopSalesOrderLines> GetEshopSalesOrderLines(string esalesOrderId)
        {
            EshopSalesOrderLines[] result = null;
            try
            {
                result = Core.QAPI.Query<EshopSalesOrderLines>(Utils.CRIT.Add("eSalesNumber", esalesOrderId).ValuePairs).Result;
            }
            catch (Exception e)
            {
                //TODO logging
                throw new SalesOrderHeaderException($"Error occured while getting eshop sales order lines for eSalesNumber: {esalesOrderId}", e);
            }

            return result;
        }

        public static ErrorCodes InsertEshopSalesOrderHeaders(params EshopSalesOrderHeader[] eshopSalesOrderHeaders)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                result = Core.CAPI.Insert(eshopSalesOrderHeaders).Result;
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        public static ErrorCodes InsertEshopSalesOrderLines(params EshopSalesOrderLines[] eshopSalesOrderLines)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                result = Core.CAPI.Insert(eshopSalesOrderLines).Result;
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }
    }
}
