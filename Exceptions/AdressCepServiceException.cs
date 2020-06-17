using System;

namespace Exceptions
{
    public class AdressCepServiceException : ApiException
    {
        public AdressCepServiceException()
        {
        }

        public AdressCepServiceException(string message) : base(message)
        {
        }

        public AdressCepServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
