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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public IList<Categoria> Listar()
        {
            throw new System.NotImplementedException();
        }

        public IList<Categoria> ListarCategoriaFiltro(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Categoria ListarPorId(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
