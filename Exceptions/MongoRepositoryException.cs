using System;

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

        public MongoRepositoryException(Exception innerException) : base("Failed to connect the database.", innerException)
        {
        }
    }
}
