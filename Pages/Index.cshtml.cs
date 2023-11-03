using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace EmpresaAlkemyServicios.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public async Task OnPostAsync()
        {
            var nombre = Request.Form["nombre"];
            var contraseña = Request.Form["contraseña"];

            var data = new { nombre, contraseña };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "aplication/json" );
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync("https://localhost:7032/api/Autenticacion/validar", content);
                 Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    var token = await response.Content.ReadAsStringAsync();
                   
                }
                else
                {

                }
            }
        }
    }
}