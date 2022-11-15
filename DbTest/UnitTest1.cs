using MongoDBPoc.Db;
using MongoDBPoc.Db.Domain;
using MongoDBPoc.Features.Video;

namespace DbTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        VideoMap videoMap = new VideoMap();
        videoMap.Map();
        CategoryMap categoryMap = new CategoryMap();
        categoryMap.Map();
        MongodbContext mongodbContext = new MongodbContext();
        VideoRepository videoRepository = new VideoRepository(mongodbContext);
        List<Video> videos = videoRepository.FindAll();
        Assert.Equal(2, videos.Count);
    }
    
    [Fact]
    public void TestVideoByCategory()
    {
        MongodbContext mongodbContext = new MongodbContext();
        VideoRepository videoRepository = new VideoRepository(mongodbContext);
        List<Video> videos = videoRepository.FindByCategoryName("Jeux vidéos");
        Assert.Equal(2, videos.Count);
    }

    [Fact]
    public void TestVideoByName()
    {
        MongodbContext mongodbContext = new MongodbContext();
        VideoRepository videoRepository = new VideoRepository(mongodbContext);
        List<Video> videos = videoRepository.FindByVideoName("Splatoon3");
        Assert.Single(videos);
    }
}