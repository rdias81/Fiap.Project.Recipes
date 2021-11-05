using Fiap.Project.Recipes.Web.Helpers;
using Fiap.Project.Recipes.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Web.Views.Categoria
{
    public class ExcluirModel : PageModel
    {
       
        [BindProperty()]
        public Domain.Models.Categoria Categoria { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (Categoria == null)
            {
                return NotFound();
            }

            return Page();
        }

        [Authorize]
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
                var token = ((ClaimsPrincipal)HttpContext.User.Identity).FindFirst("AcessToken").Value;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44320/api/");
                    client.DefaultRequestHeaders.Authorization =
                              new AuthenticationHeaderValue("Bearer", token);
                    var categoria = new StringContent(
                                      JsonSerializer.Serialize(id),
                                      Encoding.UTF8,
                                      "application/json");
                    using var httpResponse =
                        await client.PostAsync("/receitas/incluir?id", categoria);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        return RedirectToPage("./Index");
                    }
                }
            }

            return RedirectToPage("./Error");
        }
    }
}
