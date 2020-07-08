using apiService;
using apiService.Interfaces;
using cepService;
using cepService.Interfaces;
using CommonRepository.Interfaces;
using MongoRepository;
using Xunit;

namespace ApiTests
{
    public class AdressCepServiceGetCount
    {
        [Fact]
        public void ReturnPositiveValue()
        {
            // Arranje
            string cep = "53080800";
            ICepService cepService = new ViaCepService();
            IAdressCepRepository repository = new AdressCepMongoRepository();
            IAdressCepService adressCepService = new AdressCepService(cepService, repository);

            // Act
            var result = adressCepService.GetCount(cep);
            var positive = result >= 0 ? true : false;

            // Assert
            Assert.True(positive);
        }
    }
}
