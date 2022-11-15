using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using MongoDBPoc.Features.Category;
using MongoDBPoc.Features.Video;

namespace MongoDBPoc.Db.Domain;

public class VideoMap : IMongoMapper
{
    public void Map()
    {
        BsonClassMap.RegisterClassMap<Video>(map =>
        {
            map.AutoMap();
            map.SetIgnoreExtraElements(true);
            map.MapIdMember(video => video.Id).SetSerializer(new StringSerializer(BsonType.ObjectId));
            map.MapMember(video => video.Name).SetElementName("name");
            map.MapMember(video => video.YoutubeurId).SetElementName("youtubeurId");
            map.MapMember(video => video.Description).SetElementName("description");
            map.MapMember(video => video.CategoryId).SetElementName("categoryId").SetSerializer(new StringSerializer(BsonType.ObjectId));
        });
    }
}