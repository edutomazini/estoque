using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebEstoque
{
    public class LstProdutos
    {
        public List<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Nome do produto deve ser informado!")]
        [Display(Name = "Nome")]
        public string NomeProduto { get; set; }
        [Required]
        [Display(Name = "Quantidade")]
        public string Quantidade { get; set; }
        public int IdCategoria { get; set; }
        [Display(Name = "Categoria")]
        public Categoria Categoria { get; set; }
    }
}