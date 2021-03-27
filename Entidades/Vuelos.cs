using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Entidades
{
    public class Vuelos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { set; get; }

        [BsonElement("Id_vuelo")]
        public string Id_vuelo { get; set; }

        [BsonElement("Origen")]
        public string Origen { get; set; }

        [BsonElement("Fecha_hora_llegada")]
        public DateTime Fecha_hora_llegada { get; set; }

        [BsonElement("Fecha_hora_salida")]
        public DateTime Fecha_hora_salida { get; set; }

        [BsonElement("Destino")]
        public string Destino { get; set; }

        [BsonElement("Pista")]
        public int Pista { get; set; }

        [BsonElement("Estado_vuelo")]
        public string Estado_vuelo { get; set; }

        [BsonElement("Observaciones")]
        public string Observaciones { get; set; }

        public Vuelos()
        {
            Observaciones = string.Empty;
            Estado_vuelo = string.Empty;
            Pista = 0;
            Destino = string.Empty;
            Fecha_hora_llegada = DateTime.MinValue;
            Fecha_hora_salida = DateTime.MinValue;
            Origen = string.Empty;
            Id_vuelo = string.Empty;
        }
    }
}
