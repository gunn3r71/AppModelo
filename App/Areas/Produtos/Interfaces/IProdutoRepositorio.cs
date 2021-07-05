using App.Areas.Produtos.Models;

namespace App.Areas.Produtos.Interfaces
{
    public interface IProdutoRepositorio
    {
        Produto ObterProduto();
    }
}