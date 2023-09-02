using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            Inicializer();
        }

        private void Inicializer()
        {
            ViewBag.Index = "";
            ViewBag.Producto = "";
            ViewBag.About = "";
            ViewBag.Contact = "";

        }

        public IActionResult Index()
        {
            ViewBag.Index = "active";
            return View();
        }

        public IActionResult Productos()
        {
            ViewBag.Producto = "active";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.About = "active";
            return View();
        }

        public IActionResult Contact()
        {

            ViewBag.Contact = "active";
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