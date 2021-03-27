using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Logica_EstadoAeronaves
    {
        #region Metodos de Estado_Aeronaves

        public static bool AgregarEstado_Aeronaves(Estado_Aeronaves A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_EstadoAeronave objacceso = new Acceso_EstadoAeronave();
                result = objacceso.AgregarEstadoAeronave(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarEstado_Aeronaves(Estado_Aeronaves A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_EstadoAeronave objacceso = new Acceso_EstadoAeronave();
                result = objacceso.ModificarEstadoAeronave(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarEstado_Aeronaves(Estado_Aeronaves A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_EstadoAeronave objacceso = new Acceso_EstadoAeronave();
                result = objacceso.EliminarEstadoAeronave(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Estado_Aeronaves> ListarEstado_Aeronaves(Estado_Aeronaves A_entidad = null)
        {
            List<Estado_Aeronaves> result = new List<Estado_Aeronaves>();

            try
            {
                Acceso_EstadoAeronave objacceso = new Acceso_EstadoAeronave();
                result = objacceso.ListarEstadoAeronave(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        #endregion
    }
}
