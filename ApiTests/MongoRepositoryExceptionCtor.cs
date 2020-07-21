using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTests
{
    public class MongoRepositoryExceptionCtor
    {
        private MongoRepositoryException _exception;
        private readonly string _message = "Failed to connect the database.";

        [Fact]
        public void CheckCreationObject()
        {
            // Arranje / Act
            _exception = new MongoRepositoryException();

            // Assert
            Assert.NotNull(_exception);
        }

        [Fact]
        public void CheckCreationObjectWithMessage()
        {
            // Arranje / Act
            _exception = new MongoRepositoryException(_message);

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
            _exception = new MongoRepositoryException(_message, innerException);

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
            _exception = new MongoRepositoryException(innerException);

            // Assert
            Assert.NotNull(_exception);
            Assert.NotNull(_exception.InnerException);
            Assert.Equal(_message, _exception.Message);
        }
    }
}
