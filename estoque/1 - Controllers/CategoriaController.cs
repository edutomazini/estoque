using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Interfaces;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        readonly ICategoriaServico _CategoriaServico;
        public CategoriaController(ICategoriaServico CategoriaServico)
        {
            _CategoriaServico = CategoriaServico;
        }
        // GET api/values
        [HttpGet]
        public object Get()
        {
            try
            {
                return _CategoriaServico.Listar();
            }
            catch (Exception ex)
            {

                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            try
            {
                return _CategoriaServico.ListarPorId(id);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }

        }

        // POST api/values
        [HttpPost]
        public object Post([FromBody] Categoria Categoria)
        {
            try
            {
                _CategoriaServico.Cadastrar(Categoria);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public object Put(int id, [FromBody] Categoria Categoria)
        {
            try
            {
                Categoria.IdCategoria = id;
                _CategoriaServico.Alterar(Categoria);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            try
            {
                _CategoriaServico.Excluir(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "{ \"erro\": \"" + ex.Message + "\"}");
            }

        }
    }
}
