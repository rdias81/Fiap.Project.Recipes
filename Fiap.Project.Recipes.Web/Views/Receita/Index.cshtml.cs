using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
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

        public async Task OnGetAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44320/api");               
                using var httpResponse =
                    await client.GetAsync("/receitas/Listar");
                if (httpResponse.IsSuccessStatusCode)
                {
                    using var responseStream = await httpResponse.Content.ReadAsStreamAsync();
                   Receitas = await JsonSerializer.DeserializeAsync<List<Domain.Models.Receita>>(responseStream);                  
                }
            }
           
        }
    }
}
