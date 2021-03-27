using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Logica_Vuelo
    {
        #region Metodos de Vuelo

        public static bool AgregarVuelo(Vuelos A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Vuelo objacceso = new Acceso_Vuelo();
                result = objacceso.AgregarVuelo(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarVuelo(Vuelos A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Vuelo objacceso = new Acceso_Vuelo();
                result = objacceso.ModificarVuelo(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarVuelo(Vuelos A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Vuelo objacceso = new Acceso_Vuelo();
                result = objacceso.EliminarVuelo(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Vuelos> ListarVuelos(Vuelos A_entidad = null)
        {
            List<Vuelos> result = new List<Vuelos>();

            try
            {
                Acceso_Vuelo objacceso = new Acceso_Vuelo();
                result = objacceso.ListarVuelo(A_entidad);
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
