using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Exceptions
{
    public static class CoreExceptions
    {
        public class ConnectionException : Exception
        {
            public ConnectionException()
            {
            }

            public ConnectionException(string message)
                : base(message)
            {
            }

            public ConnectionException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }

        public class LoginException : Exception
        {
            public LoginException()
            {
            }

            public LoginException(string message)
                : base(message)
            {
            }

            public LoginException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }

        public class CompanyInitializeException : Exception
        {
            public CompanyInitializeException()
            {
            }

            public CompanyInitializeException(string message)
                : base(message)
            {
            }

            public CompanyInitializeException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }

        public class ApiInitializeException : Exception
        {
            public ApiInitializeException()
            {
            }

            public ApiInitializeException(string message)
                : base(message)
            {
            }

            public ApiInitializeException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    }
}
