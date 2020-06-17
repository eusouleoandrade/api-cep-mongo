using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MongoRepositoryException : ApiException
    {
        public MongoRepositoryException()
        {
        }

        public MongoRepositoryException(string message) : base(message)
        {
        }

        public MongoRepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
