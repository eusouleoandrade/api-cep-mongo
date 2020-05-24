using models;

namespace cepService.Interfaces
{
    public interface ICepService
    {
        AdressCep GetAdressCep(string cep);

        bool IsValid(string cep);
    }
}
