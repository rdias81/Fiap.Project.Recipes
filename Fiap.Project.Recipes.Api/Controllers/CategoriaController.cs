using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Api.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService service)
        {
            _categoriaService = service;
        }

        public async Task<IActionResult> Obter(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = _categoriaService.Obter(id.Value);

            if (categoria == null)
            {
                return NotFound();
            }

            return (IActionResult)categoria;
        }
    }
}
