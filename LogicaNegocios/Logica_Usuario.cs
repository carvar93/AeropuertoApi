using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;


namespace LogicaNegocios
{
    public class Logica_Usuario
    {
        #region Metodos de Usuario

        public static bool AgregarUsuario(Usuarios A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Usuario objacceso = new Acceso_Usuario();
                result = objacceso.AgregarUsuario(A_entidad);

                if (result)
                {
                    SendPassword(A_entidad);
                }
                else
                {
                    throw new Exception("Error al crear usuario");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Usuarios> LoginUsuarios(Usuarios A_entidad = null)
        {
            List<Usuarios> result = new List<Usuarios>();

            try
            {
                Acceso_Usuario objacceso = new Acceso_Usuario();
                result = objacceso.LoginUsuarios(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool ModificarUsuario(Usuarios A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Usuario objacceso = new Acceso_Usuario();
                result = objacceso.ModificarUsuario(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool EliminarUsuario(Usuarios A_entidad)
        {
            bool result = false;

            try
            {
                Acceso_Usuario objacceso = new Acceso_Usuario();
                result = objacceso.EliminarUsuario(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Usuarios> ListarUsuarios(Usuarios A_entidad = null)
        {
            List<Usuarios> result = new List<Usuarios>();

            try
            {
                Acceso_Usuario objacceso = new Acceso_Usuario();
                result = objacceso.ListarUsuarios(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static List<Usuarios> FiltrarUsuario(Usuarios A_entidad = null)
        {
            List<Usuarios> result = new List<Usuarios>();
            try
            {
                Acceso_Usuario objacceso = new Acceso_Usuario();
                result = objacceso.FiltrarUsuario(A_entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return result;
        }

        #endregion

        #region Recuperacion de contraseña
        /// <summary>
        /// Metod para recuperar el password de acceso del usuario 
        /// </summary>
        /// <param name="A_entidad"></param>
        private static void SendPassword(Usuarios A_entidad)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(A_entidad.Correo);
            msg.Subject = "" + A_entidad.Nombre + ", Contraseña Inicial.";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Estimado(a) " + A_entidad.Nombre + ", Se adjnta la contraseña para inicio de sessión : " + A_entidad.Password;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("proyectoa776@gmail.com");

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("cavaal93@gmail.com", "UAM2021@");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(" no se pudo enviar!! " + ex.Message);
            }
        }
        #endregion


    }
}
