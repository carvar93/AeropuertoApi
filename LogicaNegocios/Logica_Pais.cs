using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Logica_Pais
    {
        /// <summary>
        /// Metodo para listar los paises destinos del aeropuerto
        /// </summary>
        /// <param name="pais"></param>
        /// <returns>Lista de tipo Pais </returns>
        public static List<Paises> ListarPaises(Paises pais = null)
        {
            List<Paises> result = new List<Paises>();

            try
            {
                Acceso_Paises objacceso = new Acceso_Paises();
                result = objacceso.ListarPaises(pais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool AgregarPaises(Paises pais)
        {
            bool result = false;

            try
            {
                Acceso_Paises objacceso = new Acceso_Paises();
                result = objacceso.AgregarPaises(pais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarPaises(Paises pais)
        {
            bool result = false;

            try
            {
                Acceso_Paises objacceso = new Acceso_Paises();
                result = objacceso.ModificarPaises(pais);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarPaises(Paises pais)
        {
            bool result = false;

            try
            {
                Acceso_Paises objacceso = new Acceso_Paises();
                result = objacceso.EliminarPaises(pais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }


    }
}
