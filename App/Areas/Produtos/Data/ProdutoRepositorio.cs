using App.Areas.Produtos.Interfaces;
using App.Areas.Produtos.Models;
using App.Data;

namespace App.Areas.Produtos.Data
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public Produto ObterProduto()
        {
            return new Produto();
        }
    }
}
