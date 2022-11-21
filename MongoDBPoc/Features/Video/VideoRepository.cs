using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBPoc.Features.Category;
using MongoDBPoc.Features.Video;

namespace MongoDBPoc.Db;

public class VideoRepository
{
    private IMongoCollection<Video> videoCollection;
    
    public VideoRepository(MongodbContext mongodbContext)
    {
        videoCollection = mongodbContext.Video();
    }

    public List<Video> FindAll()
    {
        // find all videos and include the category which is referenced by the category id
        List<Video> videos = videoCollection.Find(video => true).ToList();
        return videos;
    }
    
    public List<Video> FindByCategoryName(string categoryName)
    {
        var filter = Builders<Video>
            .Filter
            .ElemMatch(video =>  video.Category, category => category.Name.Equals(categoryName));
        var videos = videoCollection.Find(filter).ToList();
        return videos;
    }
    
    public List<Video> FindByVideoName(string videoName)
    {
        List<Video> videosByVideoName = videoCollection.Find(video => video.Name.Equals(videoName)).ToList();
        return videosByVideoName;
    }
}