using Fiap.Project.Recipes.Api.Helpers;
using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceitaController : ControllerBase
    {

        private readonly IReceitaService _receitaService;

        public ReceitaController(IReceitaService service)
        {
            _receitaService = service;
        }

        [Authorize]
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Receita> Obter(int? id)
        {
            if (id == null)
                return NotFound();

            var receita = _receitaService.Obter(id.Value);

            if (receita == null)
                return NotFound();

            return receita;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<Receita>> Listar()
        {
            return Ok(_receitaService.Listar().ToList());
        }

        [Authorize]
        [HttpGet]
        [Route("PorCategoria/{categoria}")]
        public ActionResult<IEnumerable<Receita>> Listar(int categoria)
        {
            var receitas = _receitaService.Listar(categoria).ToList();

            if (receitas?.Count > 0)
                return Ok(receitas);

            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public ActionResult<Categoria> Incluir([FromBody] Receita receita)
        {
            if (receita == null)
                return BadRequest();

            _receitaService.Incluir(receita);

            return Created($"/api/receita/{receita.Id}", receita);
        }

        [Authorize]
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var receita = _receitaService.Obter(id);

            if (receita == null)
                return NotFound();

            _receitaService.Excluir(id);
            return NoContent();
        }

        [Authorize]
        [HttpPut]
        public ActionResult<Receita> Atualizar(Receita receita)
        {
            if (ModelState.IsValid)
            {
                _receitaService.Atualizar(receita);
                return Ok(receita);
            }

            return BadRequest(ModelState);
        }

    }
}
