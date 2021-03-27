using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Entidades;
namespace AccesoDatos
{
    public class Acceso_Aeronave
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

        public Acceso_Aeronave()
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
        /// Método para agregar una Aeronave en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo Aeronave</param>
        /// <returns>TRUE = Correcto</returns>
        public bool AgregarAeronave(Aeronaves entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Aeronaves>("Aeronave");

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
        /// Método para modificar una Aeronave en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo Aeronave</param>
        /// <returns>TRUE = Correcto</returns>
        public bool ModificarAeronave(Aeronaves entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Aeronaves>("Aeronave");

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
        /// Método para eliminar una Aeronave en la colección de la base de datos
        /// </summary>
        /// <param name="A_entidad">Entidad de tipo Aeronave</param>
        /// <returns>TRUE = Correcto</returns>
        public bool EliminarAeronave(Aeronaves A_entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Aeronaves>("Aeronave");

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
        /// Método de consulta de los registros de Aeronave
        /// </summary>
        /// <param name="A_entidad">Entidad de tipo Aeronave, por defecto puede ir NULL</param>
        /// <returns>Entidad de tipo Lista Aeronave</returns>
        public List<Aeronaves> ListarAeronaves(Aeronaves A_entidad = null)
        {
            List<Aeronaves> lstresultado = new List<Aeronaves>();

            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Aeronaves>("Aeronave");

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

        /// <summary>
        /// metodo para filtrar
        /// </summary>
        /// <param name="A_entidad"></param>
        /// <returns></returns>
        public List<Aeronaves> FiltrarAeronave(Aeronaves A_entidad = null)
        {
            List<Aeronaves> lstresultado = new List<Aeronaves>();


            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Aeronaves>("Aeronave");

                if (A_entidad == null)
                {
                    lstresultado = coleccion.Find(d => true).ToList();
                }
                else
                {
                    List<Aeronaves> tmpList = new List<Aeronaves>();
                    tmpList = coleccion.Find(d => true).ToList();

                    foreach (Aeronaves item in tmpList)
                    {
                        if (item.Observaciones.Equals(A_entidad.Observaciones) ||
                            item.Id_vuelo.Equals(A_entidad.Id_vuelo) || item.Estado.Equals(A_entidad.Estado)
                           )
                        {
                            lstresultado.Add(item);
                        }
                    }
                }

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
