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
    [RoutePrefix("api/Pais")]
    public class PaisController : ApiController
    {
        [HttpGet]
        [Route(nameof(ListarPaises))]
        public IEnumerable<Paises> ListarPaises(Paises entidad)
        {

            try
            {
                return Logica_Pais.ListarPaises(entidad).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        [HttpPost]
        [Route(nameof(AgregarPaises))]
        public bool AgregarPaises(Paises entidad)
        {
            try
            {
                return Logica_Pais.AgregarPaises(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(ModificarPaises))]
        public bool ModificarPaises(Paises entidad)
        {
            try
            {
                return Logica_Pais.ModificarPaises(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        [Route(nameof(EliminarPaises))]
        public bool EliminarPaises(Paises entidad)
        {
            try
            {
                return Logica_Pais.EliminarPaises(entidad);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
