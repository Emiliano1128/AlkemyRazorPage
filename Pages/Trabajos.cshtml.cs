using EmpresaAlkemyServicios.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmpresaAlkemyServicios.Pages
{
    public class TrabajosModel : PageModel
    {
        public List<TrabajosModels> Trabajos { get; set; }
        public async Task OnGetAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://localhost:7032/api/TrabajosModels");
                
                if (response.IsSuccessStatusCode)
                {
                    Trabajos = await response.Content.ReadFromJsonAsync<List<TrabajosModels>>();
                }
                else
                {
                    Trabajos = new List<TrabajosModels>();
                }
            }
        }
    }
}
