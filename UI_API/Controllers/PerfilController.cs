using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entidades;
using LogicaNegocios;
namespace UI_API.Controllers
{
    [RoutePrefix("api/PerfilesUsuario")]
    public class PerfilController : ApiController
    {
        [HttpGet]
        [Route(nameof(ListarPerfilUsuario))]
        public IEnumerable<Perfil_Usuario> ListarPerfilUsuario(Perfil_Usuario entidad)
        {

            try
            {
                return Logica_UsuarioPorPerfil.ListarPerfil(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(AgregarPerfilUsuario))]
        public bool AgregarPerfilUsuario(Perfil_Usuario entidad)
        {
            try
            {
                return Logica_UsuarioPorPerfil.AgregarPerfil(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarPerfilUsuario))]
        public bool ModificarPerfilUsuario(Perfil_Usuario A_entidad)
        {
            try
            {
                return Logica_UsuarioPorPerfil.ModificarPerfil(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarPerfilUsuario))]
        public bool EliminarPerfilUsuario(Perfil_Usuario A_entidad)
        {
            try
            {
                return Logica_UsuarioPorPerfil.EliminarPerfil(A_entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
