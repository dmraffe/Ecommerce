using Ecommerce.Modelos;
using Ecommerce.Models;
using Ecommerce.Service.Definicion;
using Ecommerce.Service.Implementacion;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductosnterface _Productosnterface;
        private readonly IOrdenesInterface _ordenesInterface;
        private const string Cookie = "Identificador";

        public HomeController(ILogger<HomeController> logger, IProductosnterface  Productosnterface, IOrdenesInterface ordenesInterface)
        {
            _logger = logger;

            _Productosnterface = Productosnterface;
            _ordenesInterface = ordenesInterface;
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
            return View(_Productosnterface.ProductosPantallaPrincipal());
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

        public IActionResult Details(int id)
        {
             var t =    _Productosnterface.ObtenerProducto(id);
            return View(t);
        }


        public IActionResult AddCar(int id)
        {
            
            string identificador = Guid.NewGuid().ToString();   
            if (Request.Cookies.Any(a => a.Key == Cookie))
            {
                identificador = Request.Cookies[Cookie].ToString();
            }

            var producto = _Productosnterface.Producto(id);

            var orden = _ordenesInterface.ObtenerOrdernIdentificador(identificador);

            if(orden == null)
            {
                orden = new Orden()
                {
                    FechaCreacion = new DateTime(),
                    Identificador = identificador,
                    Estatus = "carrito" ,
                    Direccion = string.Empty,
                    FechaUpdate = new DateTime(),
                    IdCliente = 0
                    

                
                };
                _ordenesInterface.GuardarOrdern(orden);
            }
            _ordenesInterface.GuardarOrdernProducto(orden, producto);

            Response.Cookies.Append(Cookie, identificador);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}