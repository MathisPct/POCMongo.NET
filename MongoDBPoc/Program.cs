using MongoDBPoc.Db.Domain;

var builder = WebApplication.CreateBuilder(args);
CategoryMap categoryMap = new CategoryMap();
categoryMap.Map();
VideoMap videoMap = new VideoMap();
videoMap.Map();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();