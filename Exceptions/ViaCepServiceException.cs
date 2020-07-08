using System;

namespace Exceptions
{
    public class ViaCepServiceException : ApiException
    {
        public ViaCepServiceException()
        {
        }

        public ViaCepServiceException(string message) : base(message)
        {
        }

        public ViaCepServiceException(string message, Exception innerException) : base(message,innerException)
        {
        }

        public ViaCepServiceException(Exception innerException) : base("ViaCep service unavailable.", innerException)
        {
        }
    }
}
