using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;


namespace LogicaNegocios
{
    public class Logica_UsuarioPorPerfil
    {
        #region Metodos de Perfil 

        public static bool AgregarPerfil(Perfil_Usuario A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Perfil objacceso = new Acceso_Perfil();
                result = objacceso.AgregarPerfil(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarPerfil(Perfil_Usuario A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Perfil objacceso = new Acceso_Perfil();
                result = objacceso.ModificarPerfil_Usuario(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarPerfil(Perfil_Usuario A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Perfil objacceso = new Acceso_Perfil();
                result = objacceso.EliminarPerfil_Usuario(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Perfil_Usuario> ListarPerfil(Perfil_Usuario A_entidad = null)
        {
            List<Perfil_Usuario> result = new List<Perfil_Usuario>();

            try
            {
                Acceso_Perfil objacceso = new Acceso_Perfil();
                result = objacceso.ListarPerfil_Usuario(A_entidad);
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
