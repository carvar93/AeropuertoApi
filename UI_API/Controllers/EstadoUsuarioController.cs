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

    [RoutePrefix("api/EstadoUsuarios")]
    public class EstadoUsuarioController : ApiController
    {

        [HttpGet]
        [Route(nameof(ListarEstado_Usuario))]
        public IEnumerable<Estado_Usuario> ListarEstado_Usuario(Estado_Usuario entidad)
        {

            try
            {
                return Logica_EstadoUsuario.ListarEstadoUsuario(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        [HttpPost]
        [Route(nameof(AgregarEstadoUsuario))]
        public bool AgregarEstadoUsuario(Estado_Usuario entidad)
        {
            try
            {
                return Logica_EstadoUsuario.AgregarEstadoUsuario(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarEstadoUsuario))]
        public bool ModificarEstadoUsuario(Estado_Usuario entidad)
        {
            try
            {
                return Logica_EstadoUsuario.ModificarEstadoUsuario(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarEstadoUsuario))]
        public bool EliminarEstadoUsuario(Estado_Usuario entidad)
        {
            try
            {
                return Logica_EstadoUsuario.EliminarEstadoUsuario(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
