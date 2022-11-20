namespace MongoDBPoc.Features.Video;

public class Video
{
    private string id;
    
    private string name;
    
    private string youtubeurId;
    
    private string description;
    
    private List<Category.Category> category;
    
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
    
    public List<Category.Category> Category
    {
        get => category;
        set => category = value;
    }
}