using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Exceptions
{
    public class SalesOrderLinesException: Exception
    {
        public SalesOrderLinesException()
        {
        }

        public SalesOrderLinesException(string message)
            : base(message)
        {
        }

        public SalesOrderLinesException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
