using Exceptions;
using System;
using Xunit;

namespace ApiTests
{
    public class AdressCepServiceExceptionCtor
    {
        private AdressCepServiceException _exception;
        private readonly string _message = "AdressCepService unavailable.";

        [Fact]
        public void CheckCreatingObject()
        {
            // Arranje / Act
            _exception = new AdressCepServiceException();

            // Assert
            Assert.NotNull(_exception);
        }

        [Fact]
        public void CheckCreationObjectWithMessage()
        {
            // Arranje / Act
            _exception = new AdressCepServiceException(_message);

            // Assert
            Assert.NotNull(_exception);
            Assert.Equal(_message, _exception.Message);
        }

        [Fact]
        public void CheckCreationObjectWithMessageAndInnerException()
        {
            // Arranje
            var innerException = new Exception();

            // Act
            _exception = new AdressCepServiceException(_message, innerException);

            // Assert
            Assert.NotNull(_exception);
            Assert.NotNull(_exception.InnerException);
            Assert.Equal(_message, _exception.Message);
        }
    }
}
