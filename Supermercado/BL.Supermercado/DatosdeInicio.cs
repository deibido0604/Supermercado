using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Supermercado.SeguridadBL;

namespace BL.Supermercado
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Hogar";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Cocina";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Frutas";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Verduras";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Descripcion = "Lacteos";
            contexto.Categorias.Add(categoria5);
            
            var categoria6 = new Categoria();
            categoria6.Descripcion = "Bebidas";
            contexto.Categorias.Add(categoria6);

            var categoria7 = new Categoria();
            categoria7.Descripcion = "Granos";
            contexto.Categorias.Add(categoria7);

            var categoria8 = new Categoria();
            categoria8.Descripcion = "Limpieza";
            contexto.Categorias.Add(categoria8);

            var categoria9 = new Categoria();
            categoria9.Descripcion = "Carnes";
            contexto.Categorias.Add(categoria9);

            var categoria10 = new Categoria();
            categoria10.Descripcion = "Despensa";
            contexto.Categorias.Add(categoria10);

            var categoria11 = new Categoria();
            categoria11.Descripcion = "Mascotas";
            contexto.Categorias.Add(categoria11);

            var categoria14 = new Categoria();
            categoria14.Descripcion = "Pan";
            contexto.Categorias.Add(categoria14);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Producto Nacional";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Producto Extranjero";
            contexto.Tipos.Add(tipo2);
            //Categoria Cliente
            var categoria15= new Categoria();
            categoria15.Descripcion = "Proveedor";
            contexto.Categorias.Add(categoria15);

            var categoria16 = new Categoria();
            categoria16.Descripcion = "Consumidor";
            contexto.Categorias.Add(categoria16);
            //Tipo Cliente
            var tipo3 = new Tipo();
            tipo3.Descripcion = "Clientes Nacionales";
            contexto.Tipos.Add(tipo3);

            var tipo4 = new Tipo();
            tipo4.Descripcion = "Clientes Extranjeros";
            contexto.Tipos.Add(tipo4);

            base.Seed(contexto);
        }
    }
}
 