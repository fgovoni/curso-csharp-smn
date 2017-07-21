using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LancamentoRepositorio;

namespace Aula9_WebAPI_Lancamento.Controllers
{
    public class LancamentoController : ApiController
    {
        private LancamentoRepository _lancamentoRepositorio;

        public LancamentoController()
        {
            _lancamentoRepositorio = new LancamentoRepository();
        }

        public IHttpActionResult Post(Lancamento lancamento)
        {
            _lancamentoRepositorio.Post(lancamento);
            return Ok();
        }
    }
}
