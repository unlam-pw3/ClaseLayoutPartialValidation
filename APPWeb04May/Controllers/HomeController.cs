using APPWeb04May.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace APPWeb04May.Controllers
{
    public class HomeController : BaseController                                                              
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Factura fac = new Factura() { Cantidad = 10, Precio = 10 };

            //fac.Facturar();

            //Factura fac1 = new FacturaARG() { Cantidad = 10, Precio = 10 };

            ////FacturaARG facArg = new FacturaARG();

            //fac1.Facturar();


            ////IImprimible fac2 = new FacturaARG();

            //Imprension imp = new Imprension();

            //imp.Imprime(new FacturaARG());

            ////imp.Imprime(new Pedido());



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
