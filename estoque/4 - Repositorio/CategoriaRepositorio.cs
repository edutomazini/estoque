using Dominio;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace Repositorio
{
    public class CategoriaRepositorio : Interfaces.ICategoriaRepositorio
    {
        public void Alterar(Categoria Objeto)
        {
            throw new System.NotImplementedException();
        }

        public void Cadastrar(Categoria Categoria)
        {
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("[sp_categoria_inserir]", _MySqlConnection))
            {
                cmd.Parameters.AddWithValue("@NOME", Categoria.NomeCategoria);
                cmd.CommandType = CommandType.StoredProcedure;
                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
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
