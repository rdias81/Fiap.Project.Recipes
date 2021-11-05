using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Web.Views.Categoria
{
    public class IncluirModel : PageModel
    {      
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty()]
        public Domain.Models.Categoria Categoria { get; set; }

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
                    await client.PostAsync("/categorias/incluir", categoria);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
            }
            return RedirectToPage("./Erro");
        }
    }
}
