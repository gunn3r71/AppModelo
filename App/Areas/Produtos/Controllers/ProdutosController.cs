using Microsoft.AspNetCore.Mvc;

namespace App.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        [Route("Lista")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Busca/")]
        public IActionResult Busca()
        {
            return View();
        }

        [Route("BuscaId/{id:int?}")]
        public IActionResult BuscaPorId()
        {
            return View();
        }
    }
}
