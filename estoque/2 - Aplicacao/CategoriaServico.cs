using System.Collections.Generic;
using Aplicacao.Interfaces;
using Repositorio;
using Repositorio.Interfaces;
using Dominio;

namespace Aplicacao
{
    /// <summary>
    /// 
    /// </summary>
    public class CategoriaServico : ICategoriaServico
    {
        private readonly ICategoriaRepositorio _CategoriaRepositorio;
        /// <summary>
        /// 
        /// </summary>
        public CategoriaServico()
        {
            _CategoriaRepositorio = new CategoriaRepositorio();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Objeto"></param>
        public void Alterar(Categoria Objeto)
        {
            _CategoriaRepositorio.Alterar(Objeto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Objeto"></param>
        public void Cadastrar(Categoria Objeto)
        {
            _CategoriaRepositorio.Cadastrar(Objeto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        public void Excluir(int Id)
        {
            _CategoriaRepositorio.Excluir(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Categoria> Listar()
        {
            return _CategoriaRepositorio.Listar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public IList<Categoria> ListarCategoriaFiltro(string nome)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Categoria ListarPorId(int Id)
        {
            return _CategoriaRepositorio.ListarPorId(Id);
        }
    }
}
