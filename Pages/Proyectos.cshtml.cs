using EmpresaAlkemyServicios.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmpresaAlkemyServicios.Pages
{
    public class ProyectosModel : PageModel
    {
        public List<ProyectosModels> Proyectos { get; set; }
        public async Task OnGetAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://localhost:7032/api/ProyectosModels");
                
                if (response.IsSuccessStatusCode)
                {
                    Proyectos = await response.Content.ReadFromJsonAsync<List<ProyectosModels>>();
                }
                else
                {
                    Proyectos = new List<ProyectosModels>();
                }
            }
        }
    }
}
//public async Task OnGetAsync()
//{


//    using (var httpClient = new HttpClient())
//    {
//        var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");

//        //var response = await httpClient.GetAsync("https://localhost:7239/WeatherForecast/");
//        //Console.WriteLine(response);
//        if (response.IsSuccessStatusCode)
//        {
//            Pokemons = await response.Content.ReadFromJsonAsync<List<PokemonModels>>();
//        }
//        else
//        {
//            Pokemons = new List<PokemonModels>();
//        }
//    }
//}
