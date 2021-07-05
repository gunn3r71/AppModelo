using System;

namespace App.Models
{
    public class Produto
    {
        public Produto()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}