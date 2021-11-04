using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Receita
{
    public class IncluirModel : PageModel
    {
        public readonly Database database;

        public IncluirModel(Database database)
        {
            this.database = database;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty()]
        public Domain.Models.Receita Receita { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            database.Receitas.Add(Receita);
            database.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
