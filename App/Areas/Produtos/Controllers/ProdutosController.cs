using System;
using System.Linq;
using App.Areas.Produtos.Interfaces;
using App.Areas.Produtos.Models;
using App.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly AppDbContext _dbContext;

        public ProdutosController(IProdutoRepositorio produtoRepositorio, AppDbContext dbContext)
        {
            _produtoRepositorio = produtoRepositorio;
            _dbContext = dbContext;
        }

        [Route("Lista")]
        public IActionResult Index()
        {
            var produtos = _dbContext.Produtos.ToList();

            return View();
        }

        [Route("Busca/{id:Guid}")]
        public IActionResult Busca(Guid id)
        {
            var produto = _dbContext.Produtos.Find(id);

            return View();
        }

        [Route("Adicionar")]
        public IActionResult Adicionar(Produto produto)
        {
            _dbContext.Produtos.Add(produto);
            _dbContext.SaveChanges();
            return Ok();
        }


    }
}
