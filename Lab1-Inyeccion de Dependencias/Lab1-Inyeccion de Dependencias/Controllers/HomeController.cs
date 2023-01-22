using Lab1_Inyeccion_de_Dependencias.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace Lab1_Inyeccion_de_Dependencias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ITransientC Carrera;

        public HomeController(ITransientC _carrera)
        {
            Carrera = _carrera;
        }


        public IActionResult Index()
        {
            ViewBag.Carrera = Carrera;
            return View();
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