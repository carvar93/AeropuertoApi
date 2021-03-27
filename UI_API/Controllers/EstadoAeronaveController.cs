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
    [RoutePrefix("api/EstadoAeronaves")]
    public class EstadoAeronaveController : ApiController
    {

        [HttpGet]
        [Route(nameof(ListarEstadoAeronaves))]
        public IEnumerable<Estado_Aeronaves> ListarEstadoAeronaves(Estado_Aeronaves entidad)
        {

            try
            {
                return Logica_EstadoAeronaves.ListarEstado_Aeronaves(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(AgregarEstadoAeronaves))]
        public bool AgregarEstadoAeronaves(Estado_Aeronaves entidad)
        {
            try
            {
                return Logica_EstadoAeronaves.AgregarEstado_Aeronaves(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarEstadoAeronaves))]
        public bool ModificarEstadoAeronaves(Estado_Aeronaves entidad)
        {
            try
            {
                return Logica_EstadoAeronaves.ModificarEstado_Aeronaves(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarEstadoAeronaves))]
        public bool EliminarEstadoAeronaves(Estado_Aeronaves entidad)
        {
            try
            {
                return Logica_EstadoAeronaves.EliminarEstado_Aeronaves(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



    }
}
