using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public BindingList<Usuario> ListaUsuarios { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public Usuario Autorizar(string usuario, string contrasena)
        {

            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if(usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                }
            }

            return null;
        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();
            return ListaUsuarios;
        }


        public Resultado GuardarUsuario(Usuario usuario)
        {//Guardar usuario
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }


        public void AgregarUsuario()
        {//AGREGAR CLIENTE
            var nuevoUsuario = new Usuario();
            ListaUsuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {//Eliminar Usuario
            foreach (var usuario in ListaUsuarios)
            {
                if (usuario.Id == id)
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }


        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un Usuario valido";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(usuario.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(usuario.Email) == true)
            {
                resultado.Mensaje = "Ingrese un Email";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Mensaje = "Ingrese la contrasena del usuario";
                resultado.Exitoso = false;
            }
            /*if (usuario.Telefono > 8)
            {
                resultado.Mensaje = "El numero de telefono debe ser mayor que 8";
                resultado.Exitoso = false;
            }
            //*/
            /*  if (usuario.CategoriaId == 0)
              {
                  resultado.Mensaje = "Seleccione una Categoria";
                  resultado.Exitoso = false;
              }

              if (usuario.TipoId == 0)
              {
                  resultado.Mensaje = "Seleccione un Tipo";
                  resultado.Exitoso = false;
              }*/
            return resultado;
        }

        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Contrasena { get; set; }
            public string TipoUsuario { get; set; }
            public byte[] Foto { get; set; }

            public bool EsAdmin { get; set; }
            public bool PuedeAccederClientes { get; set; }
            public bool PuedeAccederProductos { get; set; }
            public bool PuedeAccederFacturas { get; set; }
            public bool PuedeAccederReportes { get; set; }
            public string Email { get; set; }
            public string Direccion { get; set; }
        }
    }
}
