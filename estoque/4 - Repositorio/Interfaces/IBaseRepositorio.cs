using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IBaseRepositorio<T>
    {
        void Cadastrar(T Objeto);
        void Alterar(T Objeto);
        void Excluir(int Id);
        IList<T> Listar();
        T ListarPorId(int Id);
    }
}
