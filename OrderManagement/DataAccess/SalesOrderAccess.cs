using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evision.Etrade5.Models.UnicontaExtensions;
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

        public static ErrorCodes InsertEshopSalesOrderHeaders_(params EshopSalesOrderHeader[] eshopSalesOrderHeaders)
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

        public static ErrorCodes InsertEshopSalesOrderLines_(params EshopSalesOrderLines[] eshopSalesOrderLines)
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

        //##--------------------------- Etra Added By Phases Dev Team ----------------------------------------##

        /// <summary>
        /// For deleting Eshop SalesOrder Header
        /// </summary>
        /// <param name="eshopSalesOrderHeader"></param>
        /// <returns></returns>
        public static ErrorCodes DeletetEshopSalesOrderHeader(EshopSalesOrderHeader eshopSalesOrderHeader)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                result = Core.CAPI.Delete(eshopSalesOrderHeader).Result;
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        /// <summary>
        /// For deleting Eshop SalesOrder Header
        /// </summary>
        /// <param name="eshopSalesOrderHeader"></param>
        /// <returns></returns>
        public static ErrorCodes UpdatetEshopSalesOrderHeader(EshopSalesOrderHeader eshopSalesOrderHeader)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                result = Core.CAPI.Update(eshopSalesOrderHeader).Result;
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }
        /// <summary>
        /// Considering status = 1 as accepted
        /// </summary>
        /// <returns></returns>
        public static EshopSalesOrderHeader[] GetAcceptedEshopSalesOrderHeaders()
        {
            EshopSalesOrderHeader[] result = null;
            try
            {
                result = Core.QAPI.Query<EshopSalesOrderHeader>(Utils.CRIT.Add("Satus", 1).ValuePairs).Result;
            }
            catch (Exception e)
            {
                //TODO logging
                throw;
            }

            return result;
        }


        /// <summary>
        /// For Test Purpose
        /// </summary>
        /// <returns></returns>
        public static ErrorCodes DeleteSalesOrder()
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                var data = Core.QAPI.Query<DebtorOrderClientModel>(Utils.CRIT.Add("OrderNumber", "0").ValuePairs).Result;
                result = Core.CAPI.Delete(data).Result;
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        /// <summary>
        /// For Insert EshopSalesOrderHeaders
        /// </summary>
        /// <param name="eshopSalesOrderHeaders"></param>
        /// <returns></returns>
        public static ErrorCodes InsertEshopSalesOrderHeaders(params EshopSalesOrderHeader[] eshopSalesOrderHeaders)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                if (eshopSalesOrderHeaders?.Any() == true)
                {
                    EshopSalesOrderLines[] eshopSalesOrderLines = null;
                    foreach (var eshopSalesOrderHeader in eshopSalesOrderHeaders)
                    {
                        result = Core.CAPI.Insert(eshopSalesOrderHeader).Result;
                        if (result == ErrorCodes.Succes)
                        {
                            eshopSalesOrderLines = GetEshopSalesOrderLines(eshopSalesOrderHeader?.eSalesNumber)?.ToArray();
                            InsertEshopSalesOrderLines(eshopSalesOrderHeader, eshopSalesOrderLines);
                        }
                    }

                }

                //result = Core.CAPI.Insert(eshopSalesOrderHeaders).Result;
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }
        public static ErrorCodes InsertEshopSalesOrderLines(EshopSalesOrderHeader eshopSalesOrderHeader = null, params EshopSalesOrderLines[] eshopSalesOrderLines)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                foreach (var eshopSalesOrderLine in eshopSalesOrderLines)
                {
                    //if (eshopSalesOrderLine?.MasterIsSet() == false)
                    //{
                        eshopSalesOrderLine?.SetMaster(eshopSalesOrderHeader);
                   // }
                    result = Core.CAPI.Insert(eshopSalesOrderLine).Result;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }




        /// <summary>
        /// GetSalesOrderHeaders
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<DebtorOrderLineClientModel> GetSalesOrderLines(string OrderNumber)
        {
            DebtorOrderLineClientModel[] result = null;
            try
            {
                result = Core.QAPI.Query<DebtorOrderLineClientModel>(Utils.CRIT.Add("OrderNumber", OrderNumber).ValuePairs).Result;
            }
            catch (Exception e)
            {
                //TODO logging
                throw new SalesOrderHeaderException($"Error occured while getting sales order lines for OrderNumber: {OrderNumber}", e);
            }

            return result;
        }

        public static IEnumerable<DebtorOrderClientModel> GetSalesOrderHeaders()
        {
            DebtorOrderClientModel[] result = null; ;
            try
            {
                result = Core.QAPI.Query<DebtorOrderClientModel>().Result;
            }
            catch (Exception e)
            {
                //TODO logging
                throw;
            }

            return result;
        }



        public static IEnumerable<DebtorOrderLineClientModel> GetSalesOrderLines()
        {
            DebtorOrderLineClientModel[] result = null; ;
            try
            {
                result = Core.QAPI.Query<DebtorOrderLineClientModel>().Result;
            }
            catch (Exception e)
            {
                //TODO logging
                throw;
            }

            return result;
        }



        public static ErrorCodes InsertSalesOrderHeaders(params EshopSalesOrderHeader[] eshopSalesOrderHeaders)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                if (eshopSalesOrderHeaders?.Any() == true)
                {
                    DebtorOrderClientModel debtorOrderClientModel = null;
                    EshopSalesOrderLines[] eshopSalesOrderLines = null;
                    foreach (var eshopSalesOrderHeader in eshopSalesOrderHeaders)
                    {
                        debtorOrderClientModel = MapToDebtorOrderClientModel(eshopSalesOrderHeader);
                        result = Core.CAPI.Insert(debtorOrderClientModel).Result;
                        if (result == ErrorCodes.Succes)
                        {
                            eshopSalesOrderLines = GetEshopSalesOrderLines(eshopSalesOrderHeader?.eSalesNumber)?.ToArray();
                            InsertSalesOrderLines(debtorOrderClientModel, eshopSalesOrderLines);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        public static ErrorCodes InsertSalesOrderLines(DebtorOrderClientModel Order = null, params EshopSalesOrderLines[] eshopSalesOrderLines)
        {
            var result = ErrorCodes.NoSucces;
            try
            {
                DebtorOrderLineClientModel debtorOrderLineClientModel = null;
                foreach (var eshopSalesOrderLine in eshopSalesOrderLines)
                {
                    debtorOrderLineClientModel = MapToDebtorOrderLineClientModel(eshopSalesOrderLine);
                    if (debtorOrderLineClientModel?.MasterIsSet() == false)
                    {
                        debtorOrderLineClientModel?.SetMaster(Order);
                    }
                    result = Core.CAPI.Insert(debtorOrderLineClientModel).Result;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        public static DebtorOrderClientModel MapToDebtorOrderClientModel(EshopSalesOrderHeader eshopSalesOrderHeader)
        {
            DebtorOrderClientModel result = null;
            try
            {
                result = new DebtorOrderClientModel()
                {
                    _OrderNumber = int.TryParse(eshopSalesOrderHeader?.SalesNumber, out int orderNumber) ? orderNumber : 0,
                    _InvoiceAmount = eshopSalesOrderHeader.InvoiceAmount,
                    _CustomsNo = eshopSalesOrderHeader?.CustAccount,
                    _Warehouse = eshopSalesOrderHeader?.WareHouse,
                    Currency = eshopSalesOrderHeader?.Currency,
                    _PaymentId = eshopSalesOrderHeader?.PaymentId,
                    _Payment = eshopSalesOrderHeader?.Payment,
                    _Created = eshopSalesOrderHeader.CreateDate,
                    _Requisition = eshopSalesOrderHeader.Requisition,
                    _DeliveryName = eshopSalesOrderHeader.dlvName,
                    _DeliveryAddress1 = eshopSalesOrderHeader.dlvAddress1,
                    _DeliveryAddress2 = eshopSalesOrderHeader.dlvAddress2,
                    _DeliveryAddress3 = eshopSalesOrderHeader.dlvAddress3,
                    _DeliveryZipCode = eshopSalesOrderHeader.dlvzipcode,
                    _PricesInclVat = eshopSalesOrderHeader.PriceInclVat,
                    _EnteredVatAmount = eshopSalesOrderHeader.VatAmount,
                    _Lines = int.TryParse(eshopSalesOrderHeader.Lines.ToString(), out int line) ? line : 0,
                    _DeliveryDate = eshopSalesOrderHeader.DeliveryDate,


                   // eShopSalesNumber = eshopSalesOrderHeader?.eSalesNumber,
                    //eShopPaymentId = eshopSalesOrderHeader?.PaymentId,
                    //eShopShopId = eshopSalesOrderHeader?.ShopId
                };

            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        public static DebtorOrderLineClientModel MapToDebtorOrderLineClientModel(EshopSalesOrderLines eshopSalesOrderLines)
        {
            DebtorOrderLineClientModel result = null;
            try
            {
                result = new DebtorOrderLineClientModel()
                {
                    _LineNumber = double.TryParse(eshopSalesOrderLines?.LineNumber.ToString(), out double lineN) ? lineN : 0,
                    _Item = eshopSalesOrderLines?.ItemNumber,
                    _Variant1 = eshopSalesOrderLines?.Variant1,
                    _Variant2 = eshopSalesOrderLines?.Variant2,
                    _Variant3 = eshopSalesOrderLines?.Variant3,
                    _Vat = eshopSalesOrderLines?.VatCode,
                    _Qty = double.TryParse(eshopSalesOrderLines?.QtyDecimals.ToString(), out double qtyDecimals) ? qtyDecimals : double.TryParse(eshopSalesOrderLines?.qty.ToString(), out qtyDecimals) ? qtyDecimals : 0,
                    _Price = double.TryParse(eshopSalesOrderLines?.PriceUnit.ToString(), out double priceUnit) ? priceUnit : 0,
                    _SalesPrice = double.TryParse(eshopSalesOrderLines?.salesprice.ToString(), out double salesprice) ? salesprice : 0,
                    _Discount = double.TryParse(eshopSalesOrderLines?.LineDiscAmount.ToString(), out double lineDiscAmount) ? lineDiscAmount : 0,
                    //_Vat = eshopSalesOrderLines.VatAmount,
                    _AmountEntered = eshopSalesOrderLines.LineAmount,
                    _Note = eshopSalesOrderLines?.LineNote,
                    _OrderNumber = int.TryParse(eshopSalesOrderLines?.eSalesNumber, out int orderNumber) ? orderNumber : 0,
                };

            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }

        //---------------------------End----------------------------------------------
    }
}
