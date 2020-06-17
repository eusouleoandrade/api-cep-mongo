using System;

namespace Exceptions
{
    public class WebManiaCepServiceException : ApiException
    {
        public WebManiaCepServiceException()
        {
        }

        public WebManiaCepServiceException(string message) : base(message)
        {
        }

        public WebManiaCepServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
