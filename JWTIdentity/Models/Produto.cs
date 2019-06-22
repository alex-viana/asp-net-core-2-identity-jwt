using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTIdentity.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
