using Dominio;
using MySql.Data.MySqlClient;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        public void Alterar(Categoria Categoria)
        {
            Categoria CategoriaAlterar = this.ListarPorId(Categoria.IdCategoria);
            if (CategoriaAlterar == null)
                throw new Exception("Categoria inexistente");

            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_categoria_alterar", _MySqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", Categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@NOME", Categoria.NomeCategoria);

                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Cadastrar(Categoria Categoria)
        {
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_categoria_inserir", _MySqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOME", Categoria.NomeCategoria);
                
                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int Id)
        {
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_categoria_excluir", _MySqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", Id);

                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Categoria> Listar()
        {
            Categoria Categoria;
            List<Categoria> Categorias;
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_categoria_listar", _MySqlConnection))
            {
                Categorias = new List<Categoria>();
                cmd.CommandType = CommandType.StoredProcedure;

                _MySqlConnection.Open();

                MySqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {
                    Categoria = new Categoria();
                    Categoria.IdCategoria = Convert.ToInt32(sdr["id"]);
                    Categoria.NomeCategoria = sdr["nome"].ToString();
                    Categorias.Add(Categoria);
                }
            }
            return Categorias;
        }

        public IList<Categoria> ListarCategoriaFiltro(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Categoria ListarPorId(int Id)
        {
            Categoria Categoria;
            List<Categoria> Categorias;

            Categoria = new Categoria();
            Categorias = new List<Categoria>();

            Categorias = this.Listar();

            Categoria = Categorias.Find(o => o.IdCategoria == Id);

            return Categoria;
        }
    }
}
