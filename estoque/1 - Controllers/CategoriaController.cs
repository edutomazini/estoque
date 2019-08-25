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
    public class CategoriaController : ControllerBase
    {
        readonly ICategoriaServico _CategoriaServico;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CategoriaServico"></param>
        public CategoriaController(ICategoriaServico CategoriaServico)
        {
            _CategoriaServico = CategoriaServico;
        }
        /// <summary>
        /// Retorna todas as Categorias
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Retornar uma categoria por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Grava Categoria
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Altera Categoria
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Categoria"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Deleta uma Categoria por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
