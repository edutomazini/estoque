using System.Collections.Generic;

namespace Repositorio.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepositorio<T>
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
        List<T> Listar();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T ListarPorId(int Id);
    }
}
