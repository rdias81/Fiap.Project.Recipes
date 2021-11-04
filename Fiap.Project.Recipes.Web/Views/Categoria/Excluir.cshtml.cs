using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Categoria
{
    public class ExcluirModel : PageModel
    {
        public readonly Database database;

        public ExcluirModel(Database database)
        {
            this.database = database;
        }

        [BindProperty()]
        public Domain.Models.Categoria Categoria { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categoria = database.Categorias.Find(id.Value);

            if (Categoria == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cr = database.Categorias.Find(id);

            if (cr != null)
            {
                database.Categorias.Remove(cr);
                database.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
