﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class ProductosBL
    {
        Contexto _contexto;
        //propiedad 
        public BindingList<Producto>ListaProductos { get; set; }
        //constructor
        public ProductosBL()
        {
            _contexto = new Contexto();

            ListaProductos = new BindingList<Producto>();
            
        }

        public BindingList<Producto> ObtenerProductos()
        {//LISTA DE PRODUCTO0
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }

        public Resultado  GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.id==id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

       private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }
            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.PrecioUnidad < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }
    public class Producto
    {//propiedades de la clase producto
        public int id { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnidad { get; set; }
       // public double PrecioTotal { get; set; }
        public int Existencia { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
        public bool ProductoNacional { get; set; }
        public bool ProductoExtranjero { get; set; }
        //public int codigo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string  Mensaje { get; set; } 
    }
}
