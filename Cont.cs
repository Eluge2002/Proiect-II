
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace proiect
{
    [Serializable]
    public class Cont
    {
        // MongoDB will generate _id automatically
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("username"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }

        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }

        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("score"), BsonRepresentation(BsonType.Int32)]
        public int Score { get; set; }

        [BsonElement("level1"), BsonRepresentation(BsonType.Int32)]
        public int Level1 { get; set; }

        [BsonElement("Level2"), BsonRepresentation(BsonType.Int32)]
        public int Level2 { get; set; }

        [BsonElement("Level3"), BsonRepresentation(BsonType.Int32)]
        public int Level3 { get; set; }
    }
}
