using EmpresaAlkemyServicios.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmpresaAlkemyServicios.Pages
{
    public class ServiciosModel : PageModel
    {
      public List<ServiciosModels> Servicios { get; set; }
      public async Task OnGetAsync()
      {
         using (var httpClient = new HttpClient())
         {
        var response = await httpClient.GetAsync("https://localhost:7032/api/ServiciosModels");

           if (response.IsSuccessStatusCode)
           {
             Servicios = await response.Content.ReadFromJsonAsync<List<ServiciosModels>>();
           }
           else
           {
             Servicios = new List<ServiciosModels>();
           }
         }
      }  
    }
}

