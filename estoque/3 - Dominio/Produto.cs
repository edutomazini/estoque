using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Produto
    {
        public Produto()
        {
            //DataCadastro = DateTime.Now;
        }

        [Key]
        public int IdProduto { get; set; }
        //public DateTime? DataCadastro { get; set; }
        public string NomeProduto { get; set; }
        public int ?Quantidade { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
