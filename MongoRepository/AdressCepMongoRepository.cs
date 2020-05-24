using CommonRepository.Interfaces;
using models;
using MongoDB.Driver;

namespace MongoRepository
{
    public class AdressCepMongoRepository : MongoRepository, IAdressCepRepository
    {
        public long GetCount(string cep)
        {
            return _dataBase.GetCollection<AdressCep>("adressCep").CountDocuments(c => c.Cep == cep);
        }

        public void Save(AdressCep adressCep)
        {
            var collection = _dataBase.GetCollection<AdressCep>("adressCep");
            collection.InsertOne(adressCep);
        }
    }
}
