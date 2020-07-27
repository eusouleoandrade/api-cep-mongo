using Newtonsoft.Json.Linq;
using ViewModel;
using Xunit;

namespace ApiTests
{
    public class AdressCepViewModelToJObject
    {
        [Fact]
        public void CheckConvertObjectJson()
        {
            // Arranje
            var viewModel = new AdressCepViewModel()
            {
                bairro = "Rio Doce",
                cep = "53080800",
                cidade = "Olinda",
                complemento = "IV Etapa",
                count = "10",
                estado = "PE",
                gia = "",
                ibge = "",
                rua = "Avenida Das Garças",
                unidade = ""
            };

            //Act
            JObject objectJsonResult = viewModel.ToJObject();

            // Assert
            Assert.NotNull(objectJsonResult);
        }
    }
}