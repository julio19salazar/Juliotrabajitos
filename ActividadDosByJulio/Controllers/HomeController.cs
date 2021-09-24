using ActividadDosByJulio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadDosByJulio.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hola, para continuar ingresa la dirección /Home/PaginaPromedio";
        }
        public IActionResult PaginaPromedio(PaginaPromedioViewModel vm)
        {
           
            return View(vm);
        }
    }
}
