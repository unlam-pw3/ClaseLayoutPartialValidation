using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
using CapaNegocio.Servicios;
using APPWebLayoutPartialVal.Models;
namespace APPWeb04May.Controllers
{
    public class ClienteController : BaseController
    {
        ClienteService service;

        public ClienteController()
        {
             service = new ClienteService();
        }

        public IActionResult Index()
        {
            ViewData["Mensaje"] = "Mensaje Para los clientes";
            
            ViewData["Codigo"] = 123456;

            ViewBag.Nombree = "Romina";
            
            ViewBag.Edad = 33;

            //Tengo que pasarle a la vista index lista clientes y un empleado

            Empleado emp = new Empleado() { Nombre = "Juan Manuel" };
            List<Cliente> clientes = service.Todos();
            
            //ViewBag.MisClientes = clientes;
            //ViewBag.Empleado = emp;
            ClientesEmpleadoViewModel cliEmp = new ClientesEmpleadoViewModel(clientes, emp);
            return View(cliEmp);
        }

        public IActionResult CrearNuevo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearNuevo(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                service.Agregar(cliente);
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

    }
}
