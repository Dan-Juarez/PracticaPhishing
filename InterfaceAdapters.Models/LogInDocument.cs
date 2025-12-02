using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InterfaceAdapters.Models
{
    public class LogInDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("usuario")]
        public string Usuario { get; set; }

        [BsonElement("contrasena")]
        public string Contrasena { get; set; }
    }
}
