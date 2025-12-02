using InterfaceAdapters.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapters.Data
{
    public class MongoDbContext
    {
        
        private readonly IMongoDatabase _database;

         public MongoDbContext(MongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
             _database = client.GetDatabase(settings.DatabaseName);
        }

         public IMongoCollection<LogInDocument> LogIns =>
            _database.GetCollection<LogInDocument>("LogIns");
        
    }
}
