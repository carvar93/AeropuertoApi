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
    public class Acceso_Usuario
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

        public Acceso_Usuario()
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
        /// Método para agregar una Usuario en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo Usuario</param>
        /// <returns>TRUE = Correcto</returns>
        public bool AgregarUsuario(Usuarios entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Usuarios>("Usuario");

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
        /// Método para modificar una Usuario en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo Usuario</param>
        /// <returns>TRUE = Correcto</returns>
        public bool ModificarUsuario(Usuarios entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Usuarios>("Usuario");

                //coleccion.ReplaceOne(d => d.codigo == A_entidad.codigo);
                coleccion.ReplaceOne(d => d.Identificacion == entidad.Identificacion, entidad);
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
        /// Método para eliminar una Usuario en la colección de mongoDb
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo Usuario</param>
        /// <returns>TRUE = Correcto</returns>
        public bool EliminarUsuario(Usuarios A_entidad)
        {
            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Usuarios>("Usuario");

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
        /// Método de consulta de los registros de Usuario
        /// </summary>
        /// <param name="P_entidad">Entidad de tipo Usuario, por defecto puede ir NULL</param>
        /// <returns>Entidad de tipo Lista Usuario</returns>
        public List<Usuarios> ListarUsuarios(Usuarios A_entidad = null)
        {
            List<Usuarios> lstresultado = new List<Usuarios>();

            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Usuarios>("Usuario");

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
        /// <param name="E_entidad"></param>
        /// <returns></returns>
        public List<Usuarios> FiltrarUsuario(Usuarios E_entidad = null)
        {
            List<Usuarios> lstresultado = new List<Usuarios>();


            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Usuarios>("Usuario");

                if (E_entidad == null)
                {
                    lstresultado = coleccion.Find(d => true).ToList();
                }
                else
                {
                    List<Usuarios> tmpList = new List<Usuarios>();
                    tmpList = coleccion.Find(d => true).ToList();

                    foreach (Usuarios item in tmpList)
                    {
                        if (item.Estado_Usuario.Equals(E_entidad.Estado_Usuario))
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

        /// <summary>
        /// metodo para Login
        /// </summary>
        /// <param name="E_entidad"></param>
        /// <returns></returns>
        public List<Usuarios> LoginUsuarios(Usuarios E_entidad = null)
        {
            List<Usuarios> lstresultado = new List<Usuarios>();

            try
            {
                GetConexion(NombreBD);
                var coleccion = basedatos.GetCollection<Usuarios>("Usuario");

                if (E_entidad == null)
                {
                    lstresultado = coleccion.Find(d => true).ToList();
                }

                else
                {
                    List<Usuarios> tmpList = new List<Usuarios>();
                    tmpList = coleccion.Find(d => true).ToList();
                    foreach (Usuarios item in tmpList)
                    {
                        if (item.Usuario.Equals(E_entidad.Usuario) && item.Password.Equals(E_entidad.Password))
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
