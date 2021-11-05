using Fiap.Project.Recipes.Api.Helpers;
using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService service)
        {
            _categoriaService = service;
        }


      
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Categoria> Obter(int? id)
        {
            if (id == null)
                return NotFound();

            var categoria = _categoriaService.Obter(id.Value);

            if (categoria == null)
                return NotFound();

            return categoria;
        }


      
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Listar()
        {
            return Ok(_categoriaService.Listar().ToList());
        }


        [Authorize]
        [HttpPost]
        public ActionResult<Categoria> Incluir([FromBody]Categoria categoria)
        {
            if (categoria == null)
                return BadRequest();

            _categoriaService.Incluir(categoria);

            return Created($"/api/categoria/{categoria.Id}", categoria);
        }


        [Authorize]
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var catagoria = _categoriaService.Obter(id);

            if (catagoria == null)
                return NotFound();
            
            _categoriaService.Excluir(id);
            return NoContent();
        }


        [Authorize]
        [HttpPut]
        public ActionResult<Categoria> Atualizar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaService.Atualizar(categoria);
                return Ok(categoria);
            }

            return BadRequest(ModelState);
        }
    }
}
