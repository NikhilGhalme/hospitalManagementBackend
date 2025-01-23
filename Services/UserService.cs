using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

public class UserService
{
    private readonly IMongoCollection<User> _users;

    public UserService(IConfiguration config)
    {
        var client = new MongoClient(config["ConnectionString"]);
        var database = client.GetDatabase(config["DatabaseName"]);
        _users = database.GetCollection<User>("user");
    }

    public async Task CreateAsync(User user) => await _users.InsertOneAsync(user);
}