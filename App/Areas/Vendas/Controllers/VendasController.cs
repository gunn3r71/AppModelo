using Microsoft.AspNetCore.Mvc;

namespace App.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("vendas")]
    public class VendasController : Controller
    {
        [Route("listar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
