using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Entidades
{
    public class Aeronaves
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Cod")]
        public string Cod { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Id_vuelo")]
        public string Id_vuelo { get; set; }

        [BsonElement("Tipo")]
        public string Tipo { get; set; }

        [BsonElement("Estado")]
        public string Estado { get; set; }

        [BsonElement("Observaciones")]
        public string Observaciones { get; set; }

        public Aeronaves()
        {
            Observaciones = string.Empty;
            Estado = string.Empty;
            Tipo = string.Empty;
            Id_vuelo = string.Empty;
        }
    }
}
