using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    /// <summary>
    /// 
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int IdCategoria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NomeCategoria { get; set; }
    }
}
