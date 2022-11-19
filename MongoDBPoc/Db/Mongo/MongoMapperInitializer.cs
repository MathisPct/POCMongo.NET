using MongoDBPoc.Db.Domain;
using MongoDBPoc.Features.Category;

namespace MongoDBPoc.Db;

public class MongoMapperInitializer
{
    public static void Initialize()
    {
        MongoMapperAggregate mongoMapperAggregate = new MongoMapperAggregate();
        
        CategoryMap categoryMap = new CategoryMap();
        VideoMap videoMap = new VideoMap();
        mongoMapperAggregate.Add(categoryMap);
        mongoMapperAggregate.Add(videoMap);
        
        mongoMapperAggregate.Map();
    }
}