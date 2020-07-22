using Exceptions;
using System;
using Xunit;

namespace ApiTests
{
    public class ViaCepServiceExceptionCtor
    {
        private ViaCepServiceException _exception;
        private readonly string _message = "ViaCep service unavailable.";

        [Fact]
        public void CheckCreatingObject()
        {
            // Arranje / Act
            _exception = new ViaCepServiceException();

            // Assert
            Assert.NotNull(_exception);
        }

        [Fact]
        public void CheckCreationObjectWithMessage()
        {
            // Arranje / Act
            _exception = new ViaCepServiceException(_message);

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
            _exception = new ViaCepServiceException(_message, innerException);

            // Assert
            Assert.NotNull(_exception);
            Assert.NotNull(_exception.InnerException);
            Assert.Equal(_message, _exception.Message);
        }

        [Fact]
        public void CheckCreationObjectWithInnerException()
        {
            // Arranje
            var innerException = new Exception();

            // Act
            _exception = new ViaCepServiceException(innerException);

            // Assert
            Assert.NotNull(_exception);
            Assert.NotNull(_exception.InnerException);
            Assert.Equal(_message, _exception.Message);
        }
    }
}
