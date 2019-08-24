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
        public IList<Categoria> Get()
        {
            return _CategoriaServico.Listar();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Categoria Get(int id)
        {
            return _CategoriaServico.ListarPorId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Categoria Categoria)
        {
            _CategoriaServico.Cadastrar(Categoria);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Categoria Categoria)
        {
            Categoria.IdCategoria = id;
            _CategoriaServico.Alterar(Categoria);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _CategoriaServico.Excluir(id);
        }
    }
}
