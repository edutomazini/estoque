using System;
using Aplicacao.Interfaces;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace estoque.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        readonly IProdutoServico _ProdutoServico;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProdutoServico"></param>
        public ProdutoController(IProdutoServico ProdutoServico)
        {
            _ProdutoServico = ProdutoServico;
        }
        /// <summary>
        /// Retorna todos Produtos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Object Get()
        {
            try
            {
                return _ProdutoServico.Listar();
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }
            
        }

        /// <summary>
        /// Retorna Produto por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Object Get(int id)
        {
            try
            {
                return _ProdutoServico.ListarPorId(id);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }
            
        }

        /// <summary>
        /// Grava Produto
        /// </summary>
        /// <param name="Produto"></param>
        /// <returns></returns>
        [HttpPost]
        public Object Post([FromBody] Produto Produto)
        {
            try
            {
                _ProdutoServico.Cadastrar(Produto);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }
            
        }

        /// <summary>
        /// Altera Produto por ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Produto"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public Object Put(int id, [FromBody] Produto Produto)
        {
            try
            {
                Produto.IdProduto = id;
                _ProdutoServico.Alterar(Produto);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }
 
        }

        /// <summary>
        /// Deleta Produto por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public Object Delete(int id)
        {
            try
            {
                _ProdutoServico.Excluir(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }
            
        }
    }
}
