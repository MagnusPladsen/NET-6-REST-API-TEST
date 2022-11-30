namespace Catalog.settings
{
    public class MongoDbSettings
    {
        public string ConnectionString { get 
        {
            return "mongodb://localhost:27017";
        } }
        public string DatabaseName { get; set; } = null!;

        public string CollectionName { get; set; } = null!;
    }
}