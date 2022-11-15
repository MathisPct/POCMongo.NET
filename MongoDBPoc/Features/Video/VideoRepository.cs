using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBPoc.Features.Category;
using MongoDBPoc.Features.Video;

namespace MongoDBPoc.Db;

public class VideoRepository
{
    private IMongoCollection<Video> videoCollection;

    private IMongoCollection<Category> categoryCollection;

    public VideoRepository(MongodbContext mongodbContext)
    {
        videoCollection = mongodbContext.Video();
        categoryCollection = mongodbContext.Category();
    }

    public List<Video> FindAll()
    {
        // find all videos and include the category which is referenced by the category id
        List<Video> videos = videoCollection.Find(video => true).ToList();
        videos.ForEach(video =>
        {
            video.Category = categoryCollection.Find(category => category.Id == video.CategoryId).FirstOrDefault();
        });
        return videos;
    }
    
    public List<Video> FindByCategoryName(string categoryName)
    {
        // find all videos by category name and include the category which is referenced by the category id
        categoryCollection.Find(category => true).ToList();
        Category category = categoryCollection.Find(category => category.Name.Equals(categoryName)).FirstOrDefault();
        List<Video> videosByCategoryName = videoCollection.Find(video => video.CategoryId == category.Id).ToList();
        foreach (Video video in videosByCategoryName)
        {
            video.Category = category;
        }
        return videosByCategoryName;
    }
    
    public List<Video> FindByVideoName(string videoName)
    {
        List<Video> videosByVideoName = videoCollection.Find(video => video.Name.Equals(videoName)).ToList();
        videosByVideoName.ForEach(video =>
        {
            video.Category = categoryCollection.Find(category => category.Id == video.CategoryId).FirstOrDefault();
        });
        return videosByVideoName;
    }
}