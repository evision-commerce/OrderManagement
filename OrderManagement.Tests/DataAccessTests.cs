using System;
using System.Linq;
using System.Runtime.InteropServices;
using OrderManagement.Exceptions;
using Xunit;
using Xunit.Abstractions;
using static Xunit.Assert;

namespace OrderManagement.Tests
{
    public class DataAccessTests
    {
        private readonly ITestOutputHelper output;
        public DataAccessTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData("devuser", "Etrade5678", "1c165e8e-b762-47a6-87c4-9aa2440ec45d", "29736")]
        public void GetEshopSalesOrders(string userName, string password, string accessToken, string companyId)
        {
            Core.InitializeCore(userName, password, accessToken, companyId).GetAwaiter().GetResult();

            var salesOrderHeaders = DataAccess.SalesOrderAccess.GetEshopSalesOrderHeaders();
            output.WriteLine($"--------------------------------E-shop Sales Order Header Results--------------------------------");
            foreach (var eshopSalesOrderHeader in salesOrderHeaders.OrderBy(o=>o.eSalesNumber))
            {
                output.WriteLine($"EShop sales number: {eshopSalesOrderHeader.eSalesNumber}, Name: {eshopSalesOrderHeader.Name}, ShopId: {eshopSalesOrderHeader.ShopId}");
            }
        }
    }
}
