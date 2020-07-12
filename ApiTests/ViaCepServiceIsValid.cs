using cepService;
using cepService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTests
{
    public class ViaCepServiceIsValid
    {
        private ICepService _cepService;

        [Theory]
        [InlineData(false, "530808000")]
        [InlineData(false, "53080")]
        [InlineData(false, "53080A00")]
        [InlineData(true, "53080800")]
        [InlineData(true, "52041550")]
        [InlineData(true, "53150600")]
        public void CheckIfCepIsValidAndNotValid(bool isValid, string cep)
        {
            // Arranje
            _cepService = new ViaCepService();

            // Act
            var result = _cepService.IsValid(cep);

            // Assert
            if (isValid)
                Assert.True(result);
            else
                Assert.False(result);
        }
    }
}
