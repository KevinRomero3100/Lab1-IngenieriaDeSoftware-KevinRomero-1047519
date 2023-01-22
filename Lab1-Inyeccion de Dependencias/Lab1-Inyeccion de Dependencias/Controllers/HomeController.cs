using Lab1_Inyeccion_de_Dependencias.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace Lab1_Inyeccion_de_Dependencias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  ITransient _transientPilot;
        private  IScoped _scopedPilot;
        private  IScoped _scopedPilot2;
        private  ISingelton _singeltonPilot;


        public HomeController(ITransient transient, IScoped scoped, IScoped scoped2, ISingelton singelton)
        {
            _transientPilot = transient;
            _scopedPilot = scoped;
            _scopedPilot2 = scoped2;
            _singeltonPilot = singelton;
        }


        public IActionResult Index()
        {
            ViewBag.transient = _transientPilot;
            ViewBag.scoped = _scopedPilot;
            ViewBag.scoped2 = _scopedPilot2;
            ViewBag.singelton = _singeltonPilot;
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