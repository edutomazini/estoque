using Aplicacao.Interfaces;
using Dominio;
using Repositorio;
using Repositorio.Interfaces;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _ProdutoRepositorio;
        public ProdutoServico()
        {
            _ProdutoRepositorio = new ProdutoRepositorio();
        }

        public void Alterar(Produto Produto)
        {
            _ProdutoRepositorio.Alterar(Produto);
        }

        public void Cadastrar(Produto Produto)
        {
            _ProdutoRepositorio.Cadastrar(Produto);
        }

        public void Excluir(int Id)
        {
            _ProdutoRepositorio.Excluir(Id);
        }

        public IList<Produto> Listar()
        {
            return _ProdutoRepositorio.Listar();
        }

        public Produto ListarPorId(int Id)
        {
            return _ProdutoRepositorio.ListarPorId(Id);
        }
    }
}
