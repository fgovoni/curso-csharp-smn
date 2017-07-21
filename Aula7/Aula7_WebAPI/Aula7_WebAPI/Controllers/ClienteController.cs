using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aula7_WebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        public string BATATA()
        {
            return "Hey!";
        }

        [HttpGet]
        public object Teste(string nome)
        {
            return new
            {
                nome = nome
            };
        }

        [HttpGet]
        [Route("api2/clientes/{idCliente}")]
        public object ListarCliente(int idCliente)
        {
            return new { id = idCliente, nome = "Nome", sobrenome = "Sobrenome" };
        }

        [HttpGet]
        [Route("api/cep/{cep}")]
        public object BuscarCep(string cep)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://engcep.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
            );
            HttpResponseMessage res = client.GetAsync($"api/cep/{cep}").Result;

            if (res.IsSuccessStatusCode)
            {
                var meuCep = res.Content.ReadAsAsync<object>().Result;
                return meuCep;
            }
            else
            {
                return new { erro = ":(" };
            }
        }
    }
}
