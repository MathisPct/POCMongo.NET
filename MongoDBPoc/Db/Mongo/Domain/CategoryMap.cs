using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using MongoDBPoc.Features.Category;

namespace MongoDBPoc.Db.Domain;

public class CategoryMap : IMongoMapper
{
    public void Map()
    {
        BsonClassMap.RegisterClassMap<Category>(map =>
        {
            map.AutoMap();
            map.SetIgnoreExtraElements(true);
            map.MapIdMember(category => category.Id).SetSerializer(new StringSerializer(BsonType.ObjectId));;
            map.MapMember(category => category.Name).SetElementName("name");
        });
    }
}