using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace OrderManagement
{
    public static class Helpers
    {
        public static string AccessToken => ConfigurationManager.AppSettings["DeveloperAccessToken"];
        public static string CompanyId => ConfigurationManager.AppSettings["CompanyId"];
        public static string UserName => ConfigurationManager.AppSettings["UserName"];
        public static string PassWord => ConfigurationManager.AppSettings["Password"];
        //public static string OrderType => ConfigurationManager.AppSettings["OrderType"];
        public static string OrderType { get; set; }

        public static List<string> EshopSalesOrderHeaderESalesNumbers = new List<string>();
    }
}