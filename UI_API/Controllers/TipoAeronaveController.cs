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
    [RoutePrefix("api/TipoAeronaves")]
    public class TipoAeronaveController : ApiController
    {
        [HttpGet]
        [Route(nameof(ListarTipoAeronaves))]
        public IEnumerable<Tipo_Aeronaves> ListarTipoAeronaves(Tipo_Aeronaves entidad)
        {

            try
            {
                return Logica_TipoAeronave.ListarTipoAeronaves(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(AgregarTipoAeronaves))]
        public bool AgregarTipoAeronaves(Tipo_Aeronaves entidad)
        {
            try
            {
                return Logica_TipoAeronave.AgregarTipoAeronave(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarTipoAeronaves))]
        public bool ModificarTipoAeronaves(Tipo_Aeronaves entidad)
        {
            try
            {
                return Logica_TipoAeronave.ModificarTipoAeronave(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarTipoAeronaves))]
        public bool EliminarTipoAeronaves(Tipo_Aeronaves entidad)
        {
            try
            {
                return Logica_TipoAeronave.EliminarTipoAeronave(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



    }
}
