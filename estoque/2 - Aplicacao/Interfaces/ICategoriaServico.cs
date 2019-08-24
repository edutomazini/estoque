using Dominio;
using System.Collections.Generic;

namespace Aplicacao.Interfaces 
{
    public interface ICategoriaServico : IBaseServico<Categoria>
    {
        IList<Categoria> ListarCategoriaFiltro(string nome);
    }
}
