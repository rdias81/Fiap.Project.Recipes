using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Categoria
{
    public class EditarModel : PageModel
    {
        public readonly Database database;

        public EditarModel(Database database)
        {
            this.database = database;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categoria = database.Categorias.Find(id);

            if (Categoria == null)
            {
                return NotFound();
            }

            return Page();
        }

        [BindProperty()]
        public Fiap.Project.Recipes.Domain.Models.Categoria Categoria { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            database.Categorias.Update(Categoria);
            database.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}

