using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebEstoque
{
    public class LstCategorias
    {
        public IEnumerable<Categoria> Categorias { get; set; }
    }

    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}