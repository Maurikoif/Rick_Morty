using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Rick_Morty.Models;

namespace Rick_Morty.Controllers;

 public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tutorial()
        {
            return View();
        }
        public IActionResult Comenzar()
        {
            Escape.InicializarJuego();
            
            return View("Habitacion_1");
        }
        [HttpPost]
        public IActionResult Habitacion(int Sala, string clave)
        {
            
            if(Escape.ResolverSala(Sala, clave)){
                if(Escape.EstadoJuego>3){
                    return View("Victoria");
                }
                else{
                    return View("Habitacion_" + Escape.EstadoJuego);
                }
                
            }
            else{
                return View("Error");
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
}
