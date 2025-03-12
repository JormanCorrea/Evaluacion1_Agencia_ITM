using Agencia_Viviendas_ITM.Clases;
using Agencia_Viviendas_ITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Agencia_Viviendas_ITM.Controllers
{
    [RoutePrefix("api/Viviendas")]
    public class ViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarViviendas")]
        public List<Vivienda> ConsultarViviendas()
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Vivienda Consultar(int id)
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vivienda vivienda)
        {
            clsVivienda Vivienda = new clsVivienda();
            // Se asigna el objeto 'vivienda' (recibido como parámetro) a la propiedad 'vivienda' de la instancia 'Vivienda'.
            Vivienda.vivienda = vivienda;
            return Vivienda.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vivienda vivienda)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = vivienda;
            return Vivienda.Actualizar();
        }

        [HttpPut]
        [Route("Activar")]
        public string Activar(int Id)
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.ModificarActivo(Id, true);
        }

        [HttpPut]
        [Route("Inactivar")]
        public string Inactivar(int Id)
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.ModificarActivo(Id, false);
        }


        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Vivienda vivienda)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = vivienda;
            return Vivienda.Eliminar();
        }



    }
}