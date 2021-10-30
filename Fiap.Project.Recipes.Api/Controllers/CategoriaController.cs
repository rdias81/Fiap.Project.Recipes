using Fiap.Project.Recipes.Api.Helpers;
using Fiap.Project.Recipes.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService service)
        {
            _categoriaService = service;
        }

        [HttpPost]
        [Authorize]
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
