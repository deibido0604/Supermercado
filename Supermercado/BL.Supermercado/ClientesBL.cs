using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            ListaClientes = new BindingList<Cliente>();
            
            var cliente1 = new Cliente();
            cliente1.Activo = true;
            cliente1.Nombre = "David";
            cliente1.Telefono = 88476055;

            ListaClientes.Add(cliente1);
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
    }
}
