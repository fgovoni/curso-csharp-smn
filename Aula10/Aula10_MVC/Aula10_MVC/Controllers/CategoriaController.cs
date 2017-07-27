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

                    var categorias = JsonConvert.DeserializeObject<CategoriaViewModel>(
                    resposta.Content.ReadAsStringAsync().Result);
 
                }

                return View("_Dados", categoria);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }
    }
}