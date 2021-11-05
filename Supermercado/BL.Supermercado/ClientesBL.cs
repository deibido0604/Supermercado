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
            cliente1.Email = "David@hotmail.com";
            cliente1.Telefono = 88476055;

            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Activo = true;
            cliente2.Nombre = "Isis";
            cliente2.Email = "Isis@hotmail.com";
            cliente2.Telefono = 98129656;

            ListaClientes.Add(cliente2);
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {//Guardar cliente
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if(cliente.Id == 0)
            {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado; 
        }

        public void AgregarCliente()
        {//AGREGAR CLIENTE
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarCliente(int id)
        {//Eliminar Cliente
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Email) == true)
            {
                resultado.Mensaje = "Ingrese un Email";
                resultado.Exitoso = false;
            }
          /*  if (cliente.Telefono)
            {
                resultado.Mensaje = "Ingrese el número de Telefono";
                resultado.Exitoso = false;
            }*/
            return resultado;
        }
    }

    public class Cliente
    {//Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
       public bool Exitoso { get; set; }
       public string Mensaje { get; set; }
    }
}
