using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class ProductosBL
    {
        //propiedad 
        public BindingList<Producto>ListaProductos { get; set; }
        //constructor
        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.id = 1;
            producto1.Descripcion = "Arroz";
            producto1.PrecioUnidad = 10;
            producto1.Existencia = 2;
            producto1.Activo = true;
            producto1.ProductoNacional = true;
            producto1.ProductoExtranjero = false;
            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.id = 2;
            producto2.Descripcion = "Frijoles";
            producto2.PrecioUnidad = 60;
            producto2.Existencia = 5;
            producto2.Activo = true;
            producto2.ProductoNacional = true;
            producto2.ProductoExtranjero = false;
            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.id = 3;
            producto3.Descripcion = "Huevos";
            producto3.PrecioUnidad = 3;
            producto3.Existencia = 89;
            producto3.Activo = true;
            producto3.ProductoNacional = true;
            producto3.ProductoExtranjero = false;
            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.id = 4;
            producto4.Descripcion = "Queso";
            producto4.PrecioUnidad = 35;
            producto4.Existencia = 245;
            producto4.Activo = true;
            producto4.ProductoNacional = true;
            producto4.ProductoExtranjero = false;
            ListaProductos.Add(producto4);
        }

        public BindingList<Producto> ObtenerProducto()
        {
            return ListaProductos;
        }

    }
    public class Producto
    {//propiedades de la clase producto
        public int id { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnidad { get; set; }
       // public double PrecioTotal { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
        public bool ProductoNacional { get; set; }
        public bool ProductoExtranjero { get; set; }
        //public int codigo { get; set; }
    }
}
