using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBPoc.Features.Video;

public class Video
{
    private string id;
    
    private string name;
    
    private string youtubeurId;
    
    private string description;
    
    private Category.Category _category;
    
    public string CategoryId { get; set; }
    
    public string Id
    {
        get => id;
        set => id = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string YoutubeurId
    {
        get => youtubeurId;
        set => youtubeurId = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string Description
    {
        get => description;
        set => description = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Category.Category Category
    {
        get => _category;
        set => _category = value;
    }
}