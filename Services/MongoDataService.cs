using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;


namespace platzi_asp_net_core.Services
{
  public class MongoDataService {
    
    private string _conexionString;
    private MongoClient _client;
    public MongoDataService (string conexionString) {
      _conexionString = conexionString;
      _client = new MongoClient(_conexionString);
    }

    public async Task<List<BsonDocument>> getAllAsync(string db, string collectionName) {
      var database = _client.GetDatabase(db);
      var collection = database.GetCollection<BsonDocument>(collectionName);

      await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

      var list = await collection.Find(new BsonDocument("Name", "Jack")).ToListAsync();

      return list;
    }
  }
}