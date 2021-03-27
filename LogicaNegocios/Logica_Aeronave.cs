using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Logica_Aeronave
    {
        #region Metodos de Aeronaves

        public static bool AgregarAeronaves(Aeronaves aeronave)
        {
            bool result = false;

            try
            {
                Acceso_Aeronave objacceso = new Acceso_Aeronave();
                result = objacceso.AgregarAeronave(aeronave);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarAeronaves(Aeronaves aeronave)
        {
            bool result = false;

            try
            {
                Acceso_Aeronave objacceso = new Acceso_Aeronave();
                result = objacceso.ModificarAeronave(aeronave);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarAeronaves(Aeronaves aeronave)
        {
            bool result = false;

            try
            {
                Acceso_Aeronave objacceso = new Acceso_Aeronave();
                result = objacceso.EliminarAeronave(aeronave);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Aeronaves> ListarAeronaves(Aeronaves aeronave = null)
        {
            List<Aeronaves> result = new List<Aeronaves>();

            try
            {
                Acceso_Aeronave objacceso = new Acceso_Aeronave();
                result = objacceso.ListarAeronaves(aeronave);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Aeronaves> FiltrarAeronaves(Aeronaves aeronave = null)
        {
            List<Aeronaves> result = new List<Aeronaves>();
            try
            {
                Acceso_Aeronave objacceso = new Acceso_Aeronave();
                result = objacceso.FiltrarAeronave(aeronave);
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
