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
    }
}