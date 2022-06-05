using Microsoft.AspNetCore.Mvc;
using PaginaWeb1.Models;
namespace PaginaWeb1.Controllers
{
    public class Contactoscontroller : Controller
    {
        List<Datoscontacto> datos = new List<Datoscontacto>() {
       new Datoscontacto() { Correo="hbdj@mfdq.com",Nombre="nadir"},
        };
        public IActionResult Index()
        {
            return View(datos);
        }
    }
}
