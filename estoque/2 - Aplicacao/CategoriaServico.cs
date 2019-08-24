using System.Collections.Generic;
using Aplicacao.Interfaces;
using Repositorio;
using Repositorio.Interfaces;
using Dominio;

namespace Aplicacao
{

    public class CategoriaServico : ICategoriaServico
    {
        private readonly ICategoriaRepositorio _CategoriaRepositorio;
        public CategoriaServico()
        {
            _CategoriaRepositorio = new CategoriaRepositorio();
        }

        public void Alterar(Categoria Objeto)
        {
            _CategoriaRepositorio.Alterar(Objeto);
        }

        public void Cadastrar(Categoria Objeto)
        {
            _CategoriaRepositorio.Cadastrar(Objeto);
        }

        public void Excluir(int Id)
        {
            _CategoriaRepositorio.Excluir(Id);
        }

        public IList<Categoria> Listar()
        {
            return _CategoriaRepositorio.Listar();
        }

        public IList<Categoria> ListarCategoriaFiltro(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Categoria ListarPorId(int Id)
        {
            return _CategoriaRepositorio.ListarPorId(Id);
        }
    }
}
