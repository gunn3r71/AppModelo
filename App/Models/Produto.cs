using System;

namespace App.Models
{
    public class Produto
    {
        public Produto()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}