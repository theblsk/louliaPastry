using System;
using theAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace theAPI.DALC
{
	public class DALC
	{
		public IConfiguration _config;

		public string cnxStr;

		public IMongoDatabase DB;

		public DALC(IConfiguration config) {

			_config = config;

			cnxStr = _config["mongoConnectionString"]; //should use .env, extra secure paired with cors

			var mongoClient = new MongoClient(cnxStr);

			DB = mongoClient.GetDatabase(_config["DatabaseName"]);

		}


		public async Task<List<MenuItem>> GetChosen(string choice)
        {
			var chosenCollection = DB.GetCollection<MenuItem>(choice);
			return await chosenCollection.Find(_ => true).ToListAsync();
		}

	}
}

