using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
