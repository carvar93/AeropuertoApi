using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace Entidades
{
    public class Perfil_Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { set; get; }

        [BsonElement("Cod")]
        public string Cod { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        public Perfil_Usuario()
        {
            Cod = string.Empty;
            Nombre = string.Empty;
        }
    }
}
