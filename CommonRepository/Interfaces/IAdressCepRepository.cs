using models;

namespace CommonRepository.Interfaces
{
    public interface IAdressCepRepository
    {
        void Save(AdressCep adressCep);
        long GetCount(string cep);
    }
}
