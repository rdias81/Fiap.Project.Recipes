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
    public class ReceitaController : Controller
    {

        private readonly IReceitaService _receitaService;

        public ReceitaController(IReceitaService service)
        {
            _receitaService = service;
        }

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

        [HttpGet]
        public ActionResult<IEnumerable<Receita>> Listar()
        {
            return Ok(_receitaService.Listar().ToList());
        }

        [HttpPost]
        public ActionResult<Categoria> Incluir([FromBody] Receita receita)
        {
            if (receita == null)
                return BadRequest();

            _receitaService.Incluir(receita);

            return Created($"/api/receita/{receita.Id}", receita);
        }

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
