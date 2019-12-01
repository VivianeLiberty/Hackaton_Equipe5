using Liberty.DesafioOferta.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Liberty.DesafioOferta.API.Controllers
{
    [RoutePrefix("Proposta")]
    [AllowAnonymous]
    public class PropostaController : ApiController
    {
        [Route("CriarVida")]
        [HttpPost]
        public IHttpActionResult CriarVida([FromBody] PropostaVidaRequest request)
        {
            // Grava os dados do request

            // Direciona os dados para os corretores de acordo com CEP ou fila personalizada

            return Ok();
        }
    }
}