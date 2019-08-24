using Dominio;
using MySql.Data.MySqlClient;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        readonly ICategoriaRepositorio _CategoriaRepositorio;
        public ProdutoRepositorio()
        {
            _CategoriaRepositorio = new CategoriaRepositorio();
        }
        public void Alterar(Produto Produto)
        {
            Produto ProdutoAlterar = this.ListarPorId(Produto.IdProduto);
            if (ProdutoAlterar == null)
                throw new Exception("Produto inexistente");

            if (Produto.NomeProduto != null)
                ProdutoAlterar.NomeProduto = Produto.NomeProduto;
            if (Produto.IdCategoria != 0)
                ProdutoAlterar.IdCategoria = Produto.IdCategoria;
            if (Produto.Quantidade != null)
                ProdutoAlterar.Quantidade = Produto.Quantidade;

            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_produto_alterar", _MySqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PRODUTO", Produto.IdProduto);
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", ProdutoAlterar.IdCategoria);
                cmd.Parameters.AddWithValue("@QUANTIDADE", ProdutoAlterar.Quantidade);
                cmd.Parameters.AddWithValue("@NOME", ProdutoAlterar.NomeProduto);

                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Cadastrar(Produto Produto)
        {
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_produto_inserir", _MySqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOME", Produto.NomeProduto);
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", Produto.IdCategoria);
                cmd.Parameters.AddWithValue("@QUANTIDADE", Produto.Quantidade);

                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int Id)
        {
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_produto_excluir", _MySqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PRODUTO", Id);

                _MySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Produto> Listar()
        {
            Produto Produto;
            List<Produto> Produtos;
            using (MySqlConnection _MySqlConnection = new MySqlConnection(ConexaoBanco.ConexaoMySQL))
            using (var cmd = new MySqlCommand("sp_produto_listar", _MySqlConnection))
            {
                Produtos = new List<Produto>();
                cmd.CommandType = CommandType.StoredProcedure;

                _MySqlConnection.Open();

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Produto = new Produto();
                    Produto.IdProduto = Convert.ToInt32(sdr["id"]);
                    Produto.NomeProduto = sdr["nome"].ToString();
                    Produto.Quantidade = Convert.ToInt32(sdr["quantidade"]);
                    Produto.IdCategoria = Convert.ToInt32(sdr["idcategoria"]);
                    Produto.Categoria = _CategoriaRepositorio.ListarPorId(Produto.IdCategoria);
                    Produtos.Add(Produto);
                }
            }
            return Produtos;
        }

        public Produto ListarPorId(int Id)
        {
            Produto Produto;
            List<Produto> Produtos;

            Produto = new Produto();
            Produtos = new List<Produto>();

            Produtos = this.Listar();

            Produto = Produtos.Find(o => o.IdProduto == Id);

            return Produto;
        }
    }
}
