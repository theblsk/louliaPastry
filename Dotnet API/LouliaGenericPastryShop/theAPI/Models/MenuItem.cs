using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace theAPI.Models
{
	public class MenuItem
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } //the Object ID defined by mongoDB
        public int ItemNB { get; set; } //the id I define
        [BsonElement("Name")]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PicturePath { get; set; } = null!;
    }
}

