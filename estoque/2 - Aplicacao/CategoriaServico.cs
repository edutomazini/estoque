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
            try
            {
                _CategoriaRepositorio.Cadastrar(Objeto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Excluir(int Id)
        {
            try
            {
                _CategoriaRepositorio.Excluir(Id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public IList<Categoria> Listar()
        {
            try
            {
                return _CategoriaRepositorio.Listar();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public IList<Categoria> ListarCategoriaFiltro(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Categoria ListarPorId(int Id)
        {
            try
            {
                return _CategoriaRepositorio.ListarPorId(Id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
