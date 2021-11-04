using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Receita
{
    public class ExcluirModel : PageModel
    {
        public readonly Database database;

        public ExcluirModel(Database database)
        {
            this.database = database;
        }

        [BindProperty()]
        public Domain.Models.Receita Receita { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Receita = database.Receitas.Find(id.Value);

            if (Receita == null)
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

            var cr = database.Receitas.Find(id);

            if (cr != null)
            {
                database.Receitas.Remove(cr);
                database.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
