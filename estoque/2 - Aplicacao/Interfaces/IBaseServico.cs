using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IBaseServico<T> where T : class
    {
        void Cadastrar(T Objeto);

        void Alterar(T Objeto);

        void Excluir(int Id);

        IList<T> Listar();

        T ListarPorId(int Id);
    }
}
