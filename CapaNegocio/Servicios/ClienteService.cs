using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Servicios
{
    public class ClienteService
    {
        public static List<Cliente> Clientes;

        static ClienteService()
        {
            Clientes = new List<Cliente>() { new Cliente() { ConfirmEmail = "mail@gmail.com", Email= "mail@gmail.com", EdadCIO = 10, RazonSocial = "Asociados", UserName = "asociados" } };
        }

        public void Agregar(Cliente cli)
        {
            Clientes.Add(cli); 
        }


        public List<Cliente> Todos()
        {
            return Clientes.ToList();
        }
    }
}
