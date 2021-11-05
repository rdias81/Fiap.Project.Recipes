using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiap.Project.Recipes.Web.Views.Categoria
{
    public class EditarModel : PageModel
    {      
        [BindProperty()]
        public Fiap.Project.Recipes.Domain.Models.Categoria Categoria { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44320/api/");

                using var httpResponse =
                    await client.GetAsync($"/categorias/obter?id={id}");
                if (httpResponse.IsSuccessStatusCode)
                {
                    using var responseStream = await httpResponse.Content.ReadAsStreamAsync();
                    Categoria = await JsonSerializer.DeserializeAsync<Domain.Models.Categoria>(responseStream);
                    return RedirectToPage("./Index");
                }
            }

            if (Categoria == null)
            {
                return NotFound();
            }

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44320/api/");
                var categoria = new StringContent(
                                      JsonSerializer.Serialize(Categoria),
                                      Encoding.UTF8,
                                      "application/json");
                using var httpResponse =
                    await client.PostAsync("/categorias/atualizar", categoria);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
            }

            return RedirectToPage("./Index");
        }
    }
}

