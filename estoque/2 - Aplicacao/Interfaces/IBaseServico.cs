using System.Collections.Generic;

namespace Aplicacao.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseServico<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Objeto"></param>
        void Cadastrar(T Objeto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Objeto"></param>
        void Alterar(T Objeto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        void Excluir(int Id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<T> Listar();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T ListarPorId(int Id);
    }
}
