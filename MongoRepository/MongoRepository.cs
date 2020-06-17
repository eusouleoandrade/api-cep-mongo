using MongoDB.Driver;
using System.Security.Authentication;

namespace MongoRepository
{
    public abstract class MongoRepository
    {
        private readonly string _connectionString = Properties.Settings.Default.connectionStringApiCepDB;
        protected IMongoClient _client;
        protected IMongoDatabase _dataBase;
        protected readonly string _exceptionMessage = "Failed to connect the database.";

        protected MongoRepository()
        {
            // Default connection
            _client = new MongoClient(_connectionString);
            _dataBase = _client.GetDatabase("apicepdb");

            // SSL connection
            //MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(_connectionString));
            //settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            //_client = new MongoClient(settings);
            //_dataBase = _client.GetDatabase("apicepdb");
        }
    }
}
