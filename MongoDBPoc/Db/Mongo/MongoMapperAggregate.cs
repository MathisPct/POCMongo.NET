namespace MongoDBPoc.Db;

public class MongoMapperAggregate : IMongoMapper
{
    private List<IMongoMapper> _mappers;

    public List<IMongoMapper> Mappers => _mappers;

    public void Add(IMongoMapper mapper)
    {
        _mappers.Add(mapper);
    }
    
    /// <summary>
    /// Map all Domain objects to MongoDb objects
    /// </summary>
    public void Map()
    {
        foreach (IMongoMapper mongoMapper in this._mappers)
        {
            mongoMapper.Map();
        }
    }
}