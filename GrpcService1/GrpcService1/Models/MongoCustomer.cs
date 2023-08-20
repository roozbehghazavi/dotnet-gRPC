namespace GrpcService1.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoCustomer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CustomerId { get; set; }
        public int BirthYear { get; set; }
        public int WalletBalance { get; set; }
        public int TotalCart { get; set; }
    }
}
