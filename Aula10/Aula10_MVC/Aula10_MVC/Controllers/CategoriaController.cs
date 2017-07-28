using Aula10_MVC.Infra;
using Aula10_MVC.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula10_MVC.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscarGrid()
        {
            try
            {
                var resposta = Requisicao.Get("http://localhost:5000/api/Categoria");
                if (!resposta.IsSuccessStatusCode)
                    return View("Error", "Erro ao buscar categorias");

                var categorias = JsonConvert.DeserializeObject<IEnumerable<CategoriaViewModel>>(
                    resposta.Content.ReadAsStringAsync().Result);

                return View("_Grid", categorias);
            }
            catch (Exception ex)
            {

                return View("Error", ex.Message);
            }
        }

        public ActionResult BuscarDados(int? idCategoria)
        {
            try
            {
                var categoria = new CategoriaViewModel();
                if (idCategoria.HasValue)
                {
                    var resposta = Requisicao.Get("http://localhost:5000/api/Categoria?id=" + idCategoria);
                    if (!resposta.IsSuccessStatusCode)
                        return View("Error", "Erro ao buscar categorias");

                    categoria = JsonConvert.DeserializeObject<CategoriaViewModel>(
                    resposta.Content.ReadAsStringAsync().Result);

                }

                return View("_Dados", categoria);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        public ActionResult Post(CategoriaViewModel categoria)
        {
            try
            {
                var resposta = Requisicao.Post("http://localhost:5000/api/Categoria", categoria);
                if (!resposta.IsSuccessStatusCode)
                {
                    Response.TrySkipIisCustomErrors = true;
                    Response.StatusCode = 500;
                    return Content("Erro ao cadastrar categoria");
                }

                Response.StatusCode = 200;
                return Content("OK");
            }
            catch (Exception ex)
            {
                Response.TrySkipIisCustomErrors = true;
                Response.StatusCode = 400;
                return Content(ex.Message);
            }
        }

        public ActionResult Put(CategoriaViewModel categoria)
        {
            try
            {
                var resposta = Requisicao.Put("http://localhost:5000/api/Categoria", categoria);
                if (!resposta.IsSuccessStatusCode)
                {
                    Response.TrySkipIisCustomErrors = true;
                    Response.StatusCode = 400;
                    return Content("Erro ao editar categoria");
                }

                Response.StatusCode = 200;
                return Content("OK");
            }
            catch (Exception ex)
            {
                Response.TrySkipIisCustomErrors = true;
                Response.StatusCode = 500;
                return Content(ex.Message);
            }
        }

        public ActionResult Delete(int idCategoria)
        {
            try
            {
                var resposta = Requisicao.Delete("http://localhost:5000/api/Categoria?idCategoria=" + idCategoria);
                if (!resposta.IsSuccessStatusCode)
                {
                    Response.TrySkipIisCustomErrors = true;
                    Response.StatusCode = 400;
                    return Content("Erro ao excluir categoria");
                }

                Response.StatusCode = 200;
                return Content("OK");
            }
            catch (Exception ex)
            {
                Response.TrySkipIisCustomErrors = true;
                Response.StatusCode = 500;
                return Content(ex.Message);
            }
        }
    }
}