using Fiap.Project.Recipes.Web.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Web.Views.Receita
{
    public class EditarModel : PageModel
    {
        [BindProperty()]
        public Fiap.Project.Recipes.Domain.Models.Receita Receita { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            if (Receita == null)
            {
                return NotFound();
            }

            return Page();
        }



        [Authorize]
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
                                      JsonSerializer.Serialize(Receita),
                                      Encoding.UTF8,
                                      "application/json");
                using var httpResponse =
                    await client.PostAsync("/receitas/incluir", categoria);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
            }
            return RedirectToPage("./Error");
        }
    }
}
