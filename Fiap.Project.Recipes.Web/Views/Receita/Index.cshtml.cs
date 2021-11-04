using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Receita
{
    public class IndexModel : PageModel
    {
        public readonly Database database;

        public IndexModel(Database database)
        {
            this.database = database;
        }

        public IEnumerable<Domain.Models.Receita> Receitas { get; private set; }

        public void OnGet()
        {
            Receitas = database.Receitas;
        }
    }
}
