using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBPoc.Features.Category;

public class Category
{
    private string id;
    
    private string name;
    
    public string Id
    {
        get => id;
        set => id = value;
    }
    
    public string Name
    {
        get => name;
        set => name = value;
    }
}