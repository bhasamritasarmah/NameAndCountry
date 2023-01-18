using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NameAndCountry.Models;

namespace NameAndCountry.Services
{
	public class NameAndCountryService
	{
		private readonly IMongoCollection<Country> _countryCollection;

		public NameAndCountryService(
			IOptions<NameAndCountryDatabaseSettings> nameAndCountryDatabaseSettings)
		{
			var mongoClient = new MongoClient(
					nameAndCountryDatabaseSettings.Value.ConnectionString);
			var mongoDatabase = mongoClient.GetDatabase(
					nameAndCountryDatabaseSettings.Value.DatabaseName);
			_countryCollection = mongoDatabase.GetCollection<Country>(
					nameAndCountryDatabaseSettings.Value.CollectionName);
		}

		public async Task<List<Country>> GetAsync() =>
			await _countryCollection.Find(_ => true).ToListAsync();

		public async Task CreateAsync(Country newCountry) =>
			await _countryCollection.InsertOneAsync(newCountry);
	}
}
