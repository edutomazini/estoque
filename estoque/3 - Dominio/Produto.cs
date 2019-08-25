using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    /// <summary>
    /// 
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// 
        /// </summary>
        public Produto()
        {
            //DataCadastro = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int IdProduto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NomeProduto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Quantidade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IdCategoria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Categoria Categoria { get; set; }
    }
}
