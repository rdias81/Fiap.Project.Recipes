using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Categoria
{
    public class IndexModel : PageModel
    {

       
            public readonly Database database;

            public IndexModel(Database database)
            {
                this.database = database;
            }

            public IEnumerable<Domain.Models.Categoria> Categorias { get; private set; }

            public async Task OnGetAsync()
            {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44320/api");
                using var httpResponse =
                    await client.GetAsync("/categorias/Listar");
                if (httpResponse.IsSuccessStatusCode)
                {
                    using var responseStream = await httpResponse.Content.ReadAsStreamAsync();
                    Categorias = await JsonSerializer.DeserializeAsync<List<Domain.Models.Categoria>>(responseStream);
                }
            }
            Categorias = database.Categorias;
            }
        
    }
}
