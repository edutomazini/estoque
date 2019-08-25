using Aplicacao.Interfaces;
using Dominio;
using Repositorio;
using Repositorio.Interfaces;
using System.Collections.Generic;

namespace Aplicacao
{
    /// <summary>
    /// 
    /// </summary>
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _ProdutoRepositorio;
        /// <summary>
        /// 
        /// </summary>
        public ProdutoServico()
        {
            _ProdutoRepositorio = new ProdutoRepositorio();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Produto"></param>
        public void Alterar(Produto Produto)
        {
            _ProdutoRepositorio.Alterar(Produto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Produto"></param>
        public void Cadastrar(Produto Produto)
        {
            _ProdutoRepositorio.Cadastrar(Produto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        public void Excluir(int Id)
        {
            _ProdutoRepositorio.Excluir(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Produto> Listar()
        {
            return _ProdutoRepositorio.Listar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Produto ListarPorId(int Id)
        {
            return _ProdutoRepositorio.ListarPorId(Id);
        }
    }
}
