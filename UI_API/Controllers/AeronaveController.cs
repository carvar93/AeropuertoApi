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
    [RoutePrefix("api/Aeronaves")]
    public class AeronaveController : ApiController
    {
        [HttpGet]
        [Route(nameof(ListarAeronaves))]
        public IEnumerable<Aeronaves> ListarAeronaves(Aeronaves entidad)
        {

            try
            {
                return Logica_Aeronave.ListarAeronaves(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(AgregarAeronaves))]
        public bool AgregarAeronaves(Aeronaves entidad)
        {
            try
            {
                return Logica_Aeronave.AgregarAeronaves(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarAeronaves))]
        public bool ModificarAeronaves(Aeronaves entidad)
        {
            try
            {
                return Logica_Aeronave.ModificarAeronaves(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarAeronaves))]
        public bool EliminarAeronaves(Aeronaves entidad)
        {
            try
            {
                return Logica_Aeronave.EliminarAeronaves(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(FiltarAeronaves))]
        public IEnumerable<Aeronaves> FiltarAeronaves(Aeronaves entidad)
        {
            try
            {
                return Logica_Aeronave.FiltrarAeronaves(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }




    }
}
