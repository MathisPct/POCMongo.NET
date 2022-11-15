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
    }

    public IMongoCollection<Video> Video()
    {
        return _database.GetCollection<Video>("video");
    } 
    
    public IMongoCollection<Category> Category()
    {
        return _database.GetCollection<Category>("category");
    } 
}