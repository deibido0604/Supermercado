using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();
            return ListaClientes;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {//Guardar cliente
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

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
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un Cliente valido";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
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
            /*if (cliente.Telefono > 8)
            {
                resultado.Mensaje = "El numero de telefono debe ser mayor que 8";
                resultado.Exitoso = false;
            }
            //*/
          /*  if (cliente.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una Categoria";
                resultado.Exitoso = false;
            }

            if (cliente.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un Tipo";
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
        public byte[] Foto { get; set; }
   /*     //categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        //tipo
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public bool Activo { get; set; }*/
    }
   

    public class Resultado
    {
       public bool Exitoso { get; set; }
       public string Mensaje { get; set; }
    }
}
