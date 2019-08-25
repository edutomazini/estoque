using Dominio;
using System.Collections.Generic;

namespace Aplicacao.Interfaces 
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICategoriaServico : IBaseServico<Categoria>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        IList<Categoria> ListarCategoriaFiltro(string nome);
    }
}
