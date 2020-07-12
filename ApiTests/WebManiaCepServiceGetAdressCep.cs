using cepService;
using cepService.Interfaces;
using models;
using Newtonsoft.Json;
using Xunit;

namespace ApiTests
{
    public class WebManiaCepServiceGetAdressCep
    {
        //[Fact]
        public void ReturnValidAdressCep()
        {
            // Arranje
            string cep = "53080800";
            ICepService cepService = new WebManiaCepService(); // TODO
            //ConfigurationManager.AppSettings["appKeyWebManiaCep"] = "ikyU0WL1M0X6BhyIRO0dAsRglTA81HSr";
            //ConfigurationManager.AppSettings["appSecretWebManiaCep"] = "WcnaDY2xNKWehyAKUW63rlEvDPj42JCw0cXNZHwampaBRcFf";

            // Act
            var result = cepService.GetAdressCep(cep);

            // Assert
            var expectResult = new AdressCep()
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

            var jsonExpectResult = JsonConvert.SerializeObject(expectResult);
            var jsonResult = JsonConvert.SerializeObject(result);

            Assert.Equal(jsonExpectResult, jsonResult);
        }
    }
}
