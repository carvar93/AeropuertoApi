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
    [RoutePrefix("api/Vuelos")]
    public class VueloController : ApiController
    {
        [HttpGet]
        [Route(nameof(ListarVuelos))]
        public IEnumerable<Vuelos> ListarVuelos(Vuelos A_entidad)
        {

            try
            {
                return Logica_Vuelo.ListarVuelos(A_entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route(nameof(AgregarVuelos))]
        public bool AgregarVuelos(Vuelos entidad)
        {
            try
            {
                return Logica_Vuelo.AgregarVuelo(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarVuelos))]
        public bool ModificarVuelos(Vuelos entidad)
        {
            try
            {
                return Logica_Vuelo.ModificarVuelo(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarVuelos))]
        public bool EliminarVuelos(Vuelos entidad)
        {
            try
            {
                return Logica_Vuelo.EliminarVuelo(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
