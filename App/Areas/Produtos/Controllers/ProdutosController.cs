using App.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutosController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

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

        [Route("GetProduto")]
        public IActionResult GetProduto()
        {
            var produto = _produtoRepositorio.ObterProduto();
            return Ok(produto);
        }
    }
}
