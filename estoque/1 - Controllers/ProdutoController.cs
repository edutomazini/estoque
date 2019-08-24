using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Aplicacao.Interfaces;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        readonly IProdutoServico _ProdutoServico;
        public ProdutoController(IProdutoServico ProdutoServico)
        {
            _ProdutoServico = ProdutoServico;
        }
        // GET api/values
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

        // GET api/values/5
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

        // POST api/values
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

        // PUT api/values/5
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

        // DELETE api/values/5
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
