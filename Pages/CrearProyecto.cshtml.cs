using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text;

namespace EmpresaAlkemyServicios.Pages
{
    public class CrearProyectoModel : PageModel
    {
        public void OnGet()
        {
        }
        public async Task OnPostAsync()
        {
            var nombre = Request.Form["nombre"];
            var direccion = Request.Form["direccion"];

            var data = new
            {
                codProyecto = 0,
                nombre,
                direccion,
                estado = 1
            };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "aplication/json");
            Console.WriteLine(content);
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync("https://localhost:7032/api/ProyectosModels", content);
                Console.WriteLine(response);
            }
        }
    }
}
