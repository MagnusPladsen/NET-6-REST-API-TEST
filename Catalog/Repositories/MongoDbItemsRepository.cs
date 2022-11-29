using Catalog.Entities;
using MongoDB.Driver;

namespace Catalog.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string databaseName = "catalog";
        private const string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;

        public MongoDbItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);
        }

        public void CreateItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void DeleteItem(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}