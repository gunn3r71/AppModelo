using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interfaces;
using App.Models;

namespace App.Data
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public Produto ObterProduto()
        {
            return new Produto();
        }
    }
}
