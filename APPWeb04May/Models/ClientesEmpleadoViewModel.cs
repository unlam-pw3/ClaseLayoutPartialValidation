using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
namespace APPWebLayoutPartialVal.Models
{
    public class ClientesEmpleadoViewModel
    {
        public List<Cliente> Clientes { get; set; }
        public Empleado Empleado { get; set; }

        public ClientesEmpleadoViewModel(List<Cliente> clientes, Empleado em)
        {
            this.Clientes = clientes;
            this.Empleado = em; 
        }

    }
}
