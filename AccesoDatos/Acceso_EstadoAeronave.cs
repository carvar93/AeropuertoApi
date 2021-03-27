using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AccesoDatos
{
    public class Acceso_EstadoAeronave
    {
        #region atributos

        //Se declara y define la instancia hacia MongoDB, ademas de indicar si requiere autenticación
        private readonly string strConexionMongo = @"mongodb://localhost:27017";

        //Objetos para la conexión a la instancia de mongo y a la base de datos
        private MongoClient instancia;
        private IMongoDatabase basedatos;

        //Aqui se especifica el nombre de la coleccion a manipular
        private const string NombreBD = "Aeropuerto";

        #endregion

        #region constructor

        public Acceso_EstadoAeronave()
        {
            try
            {
                GetConexion(NombreBD);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (instancia != null)
                    instancia = null;
                if (basedatos != null)
                    basedatos = null;
            }
        }

        #endregion

        #region Metodos 

        /// <summary>
        /// Metodo para verificar conexion con MongoDB
        /// </summary>
        /// <param name="P_NombreBD">Nombre de la coleccion a consultar</param>
        /// <returns>TRUE = Conexion Correcta | FALSE = Conexion fallo</returns>
        private bool GetConexion(string P_NombreBD = "")
        {
            bool ConexionCorrecta = false;

            try
            {
                if (P_NombreBD.Length > 0)
                {
                    //Crea instancia de mongodb
                    instancia = new MongoClient(strConexionMongo);

                    //Prueba de conexión a BD
                    basedatos = instancia.GetDatabase(P_NombreBD);

                    //verifica conexion positiva
                    ConexionCorrecta = basedatos.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
                }
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ConexionCorrecta;
        }

        /// <summary>
        /// Método para agregar una EstadoAeronave en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo EstadoAeronave</param>
        /// <returns>TRUE = Correcto</returns>
        public bool AgregarEstadoAeronave(Estado_Aeronaves entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Estado_Aeronaves>("EstadoAeronave");

                coleccion.InsertOne(entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (instancia != null)
                    instancia = null;
                if (basedatos != null)
                    basedatos = null;
            }

            return true;
        }

        /// <summary>
        /// Método para modificar una EstadoAeronave en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo EstadoAeronave</param>
        /// <returns>TRUE = Correcto</returns>
        public bool ModificarEstadoAeronave(Estado_Aeronaves entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Estado_Aeronaves>("EstadoAeronave");

                //coleccion.ReplaceOne(d => d.codigo == A_entidad.codigo);
                coleccion.ReplaceOne(d => d.Cod == entidad.Cod, entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (instancia != null)
                    instancia = null;
                if (basedatos != null)
                    basedatos = null;
            }

            return true;
        }

        /// <summary>
        /// Método para eliminar una EstadoAeronave en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo EstadoAeronave</param>
        /// <returns>TRUE = Correcto</returns>
        public bool EliminarEstadoAeronave(Estado_Aeronaves A_entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Estado_Aeronaves>("EstadoAeronave");

                coleccion.DeleteOne(d => d._id == A_entidad._id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (instancia != null)
                    instancia = null;
                if (basedatos != null)
                    basedatos = null;
            }

            return true;
        }

        /// <summary>
        /// Método de consulta de los registros de EstadoAeronave
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo EstadoAeronave, por defecto puede ir NULL</param>
        /// <returns>Entidad de tipo Lista EstadoAeronave</returns>
        public List<Estado_Aeronaves> ListarEstadoAeronave(Estado_Aeronaves A_entidad = null)
        {
            List<Estado_Aeronaves> lstresultado = new List<Estado_Aeronaves>();

            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Estado_Aeronaves>("EstadoAeronave");

                if (A_entidad == null)
                    lstresultado = coleccion.Find(d => true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (instancia != null)
                    instancia = null;
                if (basedatos != null)
                    basedatos = null;
            }

            return lstresultado;
        }
        #endregion

    }
}
