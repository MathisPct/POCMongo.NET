using MongoDBPoc.Db;

var builder = WebApplication.CreateBuilder(args);
MongoMapperInitializer.Initialize();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();