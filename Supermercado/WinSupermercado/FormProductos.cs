using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Supermercado;
using System.IO;

namespace WinSupermercado
{
    public partial class FormProductos : Form
    {
        ProductosBL _productos;
        TipoBL _tiposBL;
        CategoriaBL _categoriasBL;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _tiposBL = new TipoBL();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();

            _categoriasBL = new CategoriaBL();
            listaCategoriasBindingSource.DataSource = _categoriasBL.ObtenerCategoria();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void productoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productoExtranjeroCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void productoExtranjeroLabel_Click(object sender, EventArgs e)
        {

        }

        private void productoNacionalLabel_Click(object sender, EventArgs e)
        {

        }

        private void productoNacionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void existenciaLabel_Click(object sender, EventArgs e)
        {

        }

        //Guarda producto
        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto=(Producto)listaProductosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);

            }
            else
            {
                producto.Foto = null;
            }
            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        //Agrega
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool Valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = Valor;
            bindingNavigatorMoveLastItem.Enabled = Valor;
            bindingNavigatorMovePreviousItem.Enabled = Valor;
            bindingNavigatorMoveNextItem.Enabled = Valor;
            bindingNavigatorPositionItem.Enabled = Valor;

            bindingNavigatorAddNewItem.Enabled = Valor;
            bindingNavigatorDeleteItem.Enabled = Valor;
            toolStripButtonCancelar.Visible = !Valor;
        }
        private void DeshabilitarHabilitarBotones()
        {
            throw new NotImplementedException();
        }

        //elimina
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if  (idTextBox.Text != "")
            {
                var Resultado = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo);

                if (Resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
               
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            if (producto != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un producto antes de asignar una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void listaProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text;

            if (buscar != "")
            {
                listaProductosBindingSource.DataSource = _productos.ObtenerProductos(buscar);
            }
            else
            {
               listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
            }

            listaProductosBindingSource.ResetBindings(false);
        }
    }
}
