using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using LogicaNegocios;

using Entidades;

namespace UI_API.Controllers
{
    [RoutePrefix("api/Usuarios")]
    public class UsuarioController : ApiController
    {

        [HttpGet]
        [Route(nameof(ListarUsuarios))]
        public IEnumerable<Entidades.Usuarios> ListarUsuarios(Usuarios entidad)
        {

            try
            {
                return Logica_Usuario.ListarUsuarios(entidad).ToList();
            }
            catch (Exception ex)
            {
              
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(AgregarUsuarios))]
        public bool AgregarUsuarios(Usuarios entidad)
        {
            try
            {
                return Logica_Usuario.AgregarUsuario(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarUsuarios))]
        public bool ModificarUsuarios(Usuarios entidad)
        {
            try
            {
                return Logica_Usuario.ModificarUsuario(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarUsuarios))]
        public bool EliminarUsuarios(Usuarios entidad)
        {
            try
            {
                return Logica_Usuario.EliminarUsuario(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(FiltarUsuarios))]
        public IEnumerable<Usuarios> FiltarUsuarios(Usuarios entidad)
        {
            try
            {
                return Logica_Usuario.FiltrarUsuario(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(LoginUsuarios))]
        public IEnumerable<Usuarios> LoginUsuarios(Usuarios A_entidad)
        {
            try
            {
                return Logica_Usuario.LoginUsuarios(A_entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}
