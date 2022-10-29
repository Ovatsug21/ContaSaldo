using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Transacao_API.Models
{
    public class Transacao
    {
        [JsonIgnore]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }

        [BsonElement("Valor")]
        public decimal Valor { get; set; }
    }
}
