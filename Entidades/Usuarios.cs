using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace Entidades
{
    public class Usuarios
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Identificacion")]
        public string Identificacion { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Apellido")]
        public string Apellido { get; set; }

        [BsonElement("Correo")]
        public string Correo { get; set; }

        [BsonElement("Telefono")]
        public string Telefono { get; set; }

        [BsonElement("Usuario")]
        public string Usuario { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Perfil_Usuario")]
        public string Perfil_Usuario { get; set; }

        [BsonElement("Estado_Usuario")]
        public string Estado_Usuario { get; set; }

        public Usuarios()
        {
            Identificacion = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Usuario = string.Empty;
            Password = string.Empty;
            Perfil_Usuario = string.Empty;
            Estado_Usuario = string.Empty;
        }
    }
}
