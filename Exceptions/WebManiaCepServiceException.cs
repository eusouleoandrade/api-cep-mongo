using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
