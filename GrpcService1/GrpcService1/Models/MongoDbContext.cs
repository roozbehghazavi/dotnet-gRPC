using MongoDB.Driver;

namespace GrpcService1.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = "mongodb://localhost:27017";
            var mongoClient = new MongoClient(connectionString);
            _database = mongoClient.GetDatabase("Test"); // Replace with your database name
        }

        public IMongoCollection<MongoCustomer> Customers => _database.GetCollection<MongoCustomer>("Customers");
    }
}
