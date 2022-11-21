using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDBPoc.Db;

namespace DbTest;

public class DbFixture : IDisposable
{
    public MongodbContext DbContext { get; }
    
    public string ConnectionString { get; }
    
    public string DbName { get; }
    
    public DbFixture()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("./appsettings.json")
            .Build();

        ConnectionString = config.GetConnectionString("db");
        DbName = $"test_db_{Guid.NewGuid()}";
        
        DbContext = new MongodbContext(ConnectionString, DbName);
        MockData.InitData(this);
    }

    public void Dispose()
    {
        var client = new MongoClient(ConnectionString);
        client.DropDatabase(DbName);
    }
}