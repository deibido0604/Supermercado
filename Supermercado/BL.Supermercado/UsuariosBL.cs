using System.ComponentModel;
using System.Data.Entity;
/*
namespace BL.Supermercado
{
    public class UsuariosBL
    {
        Contexto _contexto;

        public BindingList<Usuario> ListaUsuarios { get; set; }

        public UsuariosBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Categorias.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }
    }

    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}*/