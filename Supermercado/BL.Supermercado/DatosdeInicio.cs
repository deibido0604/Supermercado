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
            usuarioAdmin.EsAdmin = true;
            contexto.Usuarios.Add(usuarioAdmin);

            var usuarioCaja = new Usuario();
            usuarioCaja.Nombre = "caja";
            usuarioCaja.Contrasena = "123";
            usuarioCaja.PuedeAccederFacturas = true;
            contexto.Usuarios.Add(usuarioCaja);

            var usuarioGerente = new Usuario();
            usuarioGerente.Nombre = "gerente";
            usuarioGerente.Contrasena = "123";
            usuarioGerente.PuedeAccederReportes = true;
            contexto.Usuarios.Add(usuarioGerente);

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
            categoria14.Descripcion = "Panaderia";
            contexto.Categorias.Add(categoria14);

            var categoria15 = new Categoria();
            categoria15.Descripcion = "Mariscos";
            contexto.Categorias.Add(categoria15);

            var categoria16 = new Categoria();
            categoria16.Descripcion = "Embutidos";
            contexto.Categorias.Add(categoria16);

            var categoria17 = new Categoria();
            categoria17.Descripcion = "Snacks";
            contexto.Categorias.Add(categoria17);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Producto Nacional";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Producto Extranjero";
            contexto.Tipos.Add(tipo2);

           
            var cliente1 = new Cliente();
            cliente1.Nombre = "David";
            contexto.Clientes.Add(cliente1);
           
            base.Seed(contexto);
        }
    }
}
 