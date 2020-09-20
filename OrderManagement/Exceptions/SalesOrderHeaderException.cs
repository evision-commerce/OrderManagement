using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Exceptions
{
    public class SalesOrderHeaderException: Exception
    {
        public SalesOrderHeaderException()
        {
        }

        public SalesOrderHeaderException(string message)
            : base(message)
        {
        }

        public SalesOrderHeaderException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
