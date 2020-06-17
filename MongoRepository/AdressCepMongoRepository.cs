using CommonRepository.Interfaces;
using Exceptions;
using models;
using MongoDB.Driver;

namespace MongoRepository
{
    public class AdressCepMongoRepository : MongoRepository, IAdressCepRepository
    {
        public long GetCount(string cep)
        {
            try
            {
                return _dataBase.GetCollection<AdressCep>("adressCep").CountDocuments(c => c.Cep == cep);
            }
            catch (System.Exception ex)
            {
                throw new MongoRepositoryException(_exceptionMessage, ex);
            }
            
        }

        public void Save(AdressCep adressCep)
        {
            try
            {
                var collection = _dataBase.GetCollection<AdressCep>("adressCep");
                collection.InsertOne(adressCep);
            }
            catch (System.Exception ex)
            {
                throw new MongoRepositoryException(_exceptionMessage, ex);
            }

        }
    }
}
