using BL.Supermercado;
using System.Data.Entity;

namespace BL.Supermercado
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed (Contexto contexto)
        {
            var UsuarioAdmin = new Usuario();
            //UsuarioAdmin.Nombre = 'admin';
            //UsuarioAdmin.Contrasena = '123';

            contexto.Usuarios.Add(UsuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Granos";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Lacteos";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Carnes";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Vegetales";
            contexto.Categorias.Add(categoria4);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Nacional";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Extranjero";
            contexto.Tipos.Add(tipo2);

            base.Seed(contexto);
        }
    }
}