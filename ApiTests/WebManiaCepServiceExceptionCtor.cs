using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTests
{
    public class WebManiaCepServiceExceptionCtor
    {
        private WebManiaCepServiceException _exception;
        private readonly string _message = "WebManiaCep service unavailable.";

        [Fact]
        public void CheckCreatingObject()
        {
            // Arranje / Act
            _exception = new WebManiaCepServiceException();

            // Assert
            Assert.NotNull(_exception);
        }

        [Fact]
        public void CheckCreationObjectWithMessage()
        {
            // Arranje / Act
            _exception = new WebManiaCepServiceException(_message);

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
            _exception = new WebManiaCepServiceException(_message, innerException);

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
            _exception = new WebManiaCepServiceException(innerException);

            // Assert
            Assert.NotNull(_exception);
            Assert.NotNull(_exception.InnerException);
            Assert.Equal(_message, _exception.Message);
        }
    }
}
