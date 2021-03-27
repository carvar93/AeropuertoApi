using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Logica_EstadoUsuario
    {
        public static List<Estado_Usuario> ListarEstadoUsuario(Estado_Usuario A_entidad = null)
        {
            List<Estado_Usuario> result = new List<Estado_Usuario>();

            try
            {
                Acceso_EstadoUsuario objacceso = new Acceso_EstadoUsuario();
                result = objacceso.ListarEstado_Usuario(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }


        public static bool AgregarEstadoUsuario(Estado_Usuario estado)
        {
            bool result = false;

            try
            {
                Acceso_EstadoUsuario objacceso = new Acceso_EstadoUsuario();
                result = objacceso.AgregarEstadoUsuario(estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarEstadoUsuario(Estado_Usuario estado)
        {
            bool result = false;

            try
            {
                Acceso_EstadoUsuario objacceso = new Acceso_EstadoUsuario();
                result = objacceso.ModificarEstadoUsuario(estado);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarEstadoUsuario(Estado_Usuario estado)
        {
            bool result = false;

            try
            {
                Acceso_EstadoUsuario objacceso = new Acceso_EstadoUsuario();
                result = objacceso.EliminarEstadoUsuario(estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

    }
}
