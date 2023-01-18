using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NameAndCountry.Models
{
	[BsonIgnoreExtraElements]
	public class Country
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string? Id { get; set; }

		[BsonElement("name")]
		public string PersonName { get; set; } = string.Empty;

		[BsonElement("country")]
		public string CountryName { get; set; } = string.Empty;
	}
}
