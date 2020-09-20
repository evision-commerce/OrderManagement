using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Exceptions;
using Uniconta.API.Service;
using Uniconta.API.System;
using Uniconta.Common;
using Uniconta.Common.User;
using Uniconta.DataModel;

namespace OrderManagement
{
    public static class Core
    {
        private static UnicontaConnection Connection { get; set; }
        public static Session Session { get; set; }
        public static CrudAPI CAPI;
        public static QueryAPI QAPI;
        public static Company Company;
        private static void InstantiateConnection()
        {
            try
            {
                Connection = new UnicontaConnection(APITarget.Live);
                Session = new Session(Connection);
            }
            catch (Exception e)
            {
                throw new CoreExceptions.ConnectionException("Failed to establish a connection", e);
            }
        }

        private static async Task Login(string userName, string password, string accessToken)
        {
            var loginResult = await Session.LoginAsync(userName, password, LoginType.API, new Guid(accessToken));
            if (loginResult != ErrorCodes.Succes)
            {
                throw new CoreExceptions.LoginException("Login Failed");
            }
        }

        private static async Task InstantiateCompany(int companyId)
        {
            try
            {
                Company = new Company();
                Company = await Session.GetCompany(companyId);
                if (Company == null)
                {
                    throw new Exception("Failed to get company details");
                }
            }
            catch (Exception e)
            {
                throw new CoreExceptions.CompanyInitializeException("Failed to load company", e);
            }
        }

        private static void InstantiateApi()
        {
            CAPI = new CrudAPI(Session, Company);
            QAPI = new QueryAPI(Session, Company);
            if (CAPI == null)
            {
                throw new CoreExceptions.ApiInitializeException("CRUD API is null");
            }

            if (QAPI == null)
            {
                throw new CoreExceptions.ApiInitializeException("Query API is null");
            }
        }
        /// <summary>
        /// InitializesCore
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when validation of the parameters failed</exception>
        /// <exception cref="CoreExceptions.ConnectionException">Thrown when cannot establish a connection</exception>
        /// <exception cref="CoreExceptions.LoginException">Thrown when login fails</exception>
        /// <exception cref="CoreExceptions.CompanyInitializeException">Thrown when cannot retrieve a company</exception>
        /// <exception cref="CoreExceptions.ApiInitializeException">Thrown when cannot retrieve a Query api and crud api</exception>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public static async Task InitializeCore(string userName, string password, string accessToken, string companyId)
        {
            if(string.IsNullOrEmpty(userName)) throw new ArgumentException("UserName cannot be empty");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("Password cannot be empty");
            if (string.IsNullOrEmpty(accessToken)) throw new ArgumentException("AccessToken cannot be empty");
            if (string.IsNullOrEmpty(userName)) throw new ArgumentException("UserName cannot be empty");
            if (!Guid.TryParse(accessToken, out _)) throw new ArgumentException("Invalid AccessToken");
            if (new Guid(accessToken) == Guid.Empty) throw new ArgumentException("Invalid AccessToken");
            if (string.IsNullOrEmpty(companyId)) throw new ArgumentException("CompanyId cannot be empty");
            if (!int.TryParse(companyId, out var convertedCompany)) throw new ArgumentException("Invalid CompanyId");
            InstantiateConnection();
            await Login(userName, password, accessToken);
            await InstantiateCompany(convertedCompany);
            InstantiateApi();
        }
    }
}
