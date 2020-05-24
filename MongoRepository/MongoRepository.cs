using MongoDB.Driver;

namespace MongoRepository
{
    public abstract class MongoRepository
    {
        private readonly string _connectionString = Properties.Settings.Default.connectionStringApiCepDB;
        protected IMongoClient _client;
        protected IMongoDatabase _dataBase;

        protected MongoRepository()
        {
            _client = new MongoClient(_connectionString);
            _dataBase = _client.GetDatabase("apicepdb");
        }
    }
}
