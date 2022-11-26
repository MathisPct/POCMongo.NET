using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBPoc.Features.Category;
using MongoDBPoc.Features.Video;

namespace DbTest;

public class MockData
{
    public static void InitData(DbFixture fixture)
    {
        fixture.DbContext.Video().InsertMany(new List<Video>()
        {
            new Video()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Category = new List<Category>()
                {
                    new Category()
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = "Jeux vidéos"
                    },
                    new Category()
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = "Fun"
                    }
                },
                Name = "Mario Kart 8",
                Description = "Description",
                YoutubeurId = "Youtubeur 1"
            },
            new Video()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Category = new List<Category>()
                {
                    new Category()
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = "Jeux vidéos"
                    },
                    new Category()
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = "Jeux de tir"
                    }
                },
                Name = "Splatoon 2",
                Description = "Description",
                YoutubeurId = "Youtubeur 1"
            }
        }   
        );
    }
}