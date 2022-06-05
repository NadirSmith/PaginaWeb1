using Microsoft.AspNetCore.Mvc;
using PaginaWeb1.Models;
using System.Diagnostics;

namespace PaginaWeb1.Controllers
{
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
        public IActionResult Contactanos()
        {
          Datoscontacto dc = new Datoscontacto();
           // dc.Nombre = "nadir";
           // dc.Correo = "nadir@bensa.cr.com";
           // dc.Comentario = "esta lindo";
            return View();
        }
        [HttpPost]
        public IActionResult Contactanos(Datoscontacto DC)
        {
            DC.Comentario = "Comentario genérico";
            return View ("ContactenosGracias",DC); 
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
}