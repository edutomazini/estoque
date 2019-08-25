using Dominio;
using System.Collections.Generic;

namespace Repositorio.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICategoriaRepositorio : IBaseRepositorio<Categoria>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        IList<Categoria> ListarCategoriaFiltro(string nome);
    }
}
