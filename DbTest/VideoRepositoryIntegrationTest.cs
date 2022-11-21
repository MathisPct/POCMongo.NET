using MongoDBPoc.Db;
using MongoDBPoc.Features.Video;

namespace DbTest;

public class UnitTest1 : IClassFixture<DbFixture>
{
    private readonly DbFixture _dbFixture;
    
    public UnitTest1(DbFixture dbFixture)
    {
        _dbFixture = dbFixture;
    }
    
    [Fact]
    public void Test1()
    {
        VideoRepository videoRepository = new VideoRepository(_dbFixture.DbContext);
        List<Video> videos = videoRepository.FindAll();
        Assert.Equal(2, videos.Count);
    }
    
    [Fact]
    public void TestVideoByCategory()
    {
        VideoRepository videoRepository = new VideoRepository(_dbFixture.DbContext);
        List<Video> videos = videoRepository.FindByCategoryName("Jeux vidéos");
        Assert.Equal(2, videos.Count);
    }

    [Fact]
    public void TestVideoByName()
    {
        VideoRepository videoRepository = new VideoRepository(_dbFixture.DbContext);
        List<Video> videos = videoRepository.FindByVideoName("Splatoon 2");
        Assert.Equal(1, videos.Count);
    }
}