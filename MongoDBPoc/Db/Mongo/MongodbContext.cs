using MongoDB.Driver;
using MongoDBPoc.Features.Category;
using MongoDBPoc.Features.Video;

namespace MongoDBPoc.Db;

public class MongodbContext
{
    private readonly IMongoDatabase _database;
    
    public MongodbContext()
    {
        var mongoClient = new MongoClient("mongodb://localhost:27017");
        this._database = mongoClient.GetDatabase("youstattest");
        MongoMapperInitializer.Initialize();
    }

    public MongodbContext(string connectionString, string databaseName)
    {
        var mongoClient = new MongoClient(connectionString);
        _database = mongoClient.GetDatabase(databaseName);
        MongoMapperInitializer.Initialize();
    }

    public IMongoCollection<Video> Video()
    {
        return _database.GetCollection<Video>("video");
    }
}