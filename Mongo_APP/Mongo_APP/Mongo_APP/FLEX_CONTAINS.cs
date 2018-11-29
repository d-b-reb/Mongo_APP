using MongoDB.Driver;

namespace Mongo_APP
{
    class FLEX_CONTAINS
    {
        private IMongoDatabase db;
        public FLEX_CONTAINS()
        {
            var connection_string = "mongod://localhost:27017";
            var client = new MongoClient(connection_string);
            this.db = client.GetDatabase("FLEX");
            var collection = db.GetCollection<FLEX>("FLEX");
        }
        public IMongoCollection<FLEX> Flexes => db.GetCollection<FLEX>("FLEX");
    }
}
