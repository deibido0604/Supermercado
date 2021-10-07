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
        BindingList<Producto> ListaProductos;
        //constructor
        public ProductosBL()
        {

        }
    }
    public class Producto
    {//propiedades de la clase producto
        public int id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}
