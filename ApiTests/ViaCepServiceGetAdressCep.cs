using cepService;
using cepService.Interfaces;
using models;
using Newtonsoft.Json;
using Xunit;

namespace ApiTests
{
    public class ViaCepServiceGetAdressCep
    {
        private ICepService _cepService;

        [Fact]
        public void ReturnAdressCepIfCepIsValid()
        {
            // Arranje
            string cep = "53080800";
            _cepService = new ViaCepService();

            // Act
            var result = _cepService.GetAdressCep(cep);

            // Assert
            var expectedResult = new AdressCep()
            {
                Cep = "53080-800",
                Rua = "Avenida das Garças",
                Complemento = "(4ª Etapa)",
                Bairro = "Rio Doce",
                Cidade = "Olinda",
                Estado = "PE",
                Unidade = "",
                Ibge = "2609600",
                Gia = ""
            };

            var jsonResult = JsonConvert.SerializeObject(result);
            var jsonExpectedResult = JsonConvert.SerializeObject(expectedResult);

            Assert.Equal(jsonExpectedResult, jsonResult);
        }
        [Theory]
        [InlineData("53080A00")]
        [InlineData("53080")]
        public void ReturnNullIfCepIsInvalid(string cep)
        {
            // Arranje
            _cepService = new ViaCepService();

            // Act
            var result = _cepService.GetAdressCep(cep);

            // Assert
            Assert.Null(result);
        }
    }
}
