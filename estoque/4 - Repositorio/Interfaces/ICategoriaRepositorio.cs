using Dominio;
using System.Collections.Generic;

namespace Repositorio.Interfaces
{
    public interface ICategoriaRepositorio : IBaseRepositorio<Categoria>
    {
        IList<Categoria> ListarCategoriaFiltro(string nome);
    }
}
