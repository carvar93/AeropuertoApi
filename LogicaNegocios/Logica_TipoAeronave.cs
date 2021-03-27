using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocios
{
    public class Logica_TipoAeronave
    {
        #region Metodos de TipoAeronave

        public static bool AgregarTipoAeronave(Tipo_Aeronaves A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_TipoAeronave objacceso = new Acceso_TipoAeronave();
                result = objacceso.AgregarTipoAeronave(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarTipoAeronave(Tipo_Aeronaves A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_TipoAeronave objacceso = new Acceso_TipoAeronave();
                result = objacceso.ModificarTipoAeronave(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarTipoAeronave(Tipo_Aeronaves A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_TipoAeronave objacceso = new Acceso_TipoAeronave();
                result = objacceso.EliminarTipoAeronave(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Tipo_Aeronaves> ListarTipoAeronaves(Tipo_Aeronaves A_entidad = null)
        {
            List<Tipo_Aeronaves> result = new List<Tipo_Aeronaves>();

            try
            {
                Acceso_TipoAeronave objacceso = new Acceso_TipoAeronave();
                result = objacceso.ListarTipoAeronave(A_entidad);
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
