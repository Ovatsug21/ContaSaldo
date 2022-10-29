using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Saldo_API.Models
{
    public class Consulta
    {
        [JsonIgnore]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }

        [JsonIgnore]
        [BsonElement("Valor")]
        public decimal Valor { get; set; }
    }
}
}
