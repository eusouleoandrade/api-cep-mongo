using cepService;
using cepService.Interfaces;
using Xunit;

namespace ApiTests
{
    public class ViaCepServiceCtor
    {
        private ICepService _cepService;

        [Fact]
        public void CheckCreationObject()
        {
            // Arranje / Act
            _cepService = new ViaCepService();

            // Assert
            Assert.NotNull(_cepService);
        }
    }
}
