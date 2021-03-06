using BL.Supermercado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSupermercado
{
    public partial class FormClientes : Form
    {
        ClientesBL _clientes;

        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();

            

        }

        

        

        private void DeshabilitarHabilitarBotones(bool valor)
        {//navigation de siguiente
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            //Agregar
            bindingNavigatorAddNewItem.Enabled = valor;
            //eliminar
            bindingNavigatorDeleteItem.Enabled = valor;
            //cancelar
            toolStripButtonCancelar.Visible = !valor;


        }
        

        private void Eliminar(int id)
        {//Metodo eliminar
           
            var resultado = _clientes.EliminarCliente(id);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Cliente");
            }
        }
        
        

        private void listaClientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaClientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                cliente.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                cliente.Foto = null;
            }
            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClientesBindingSource.MoveLast();
            //Metodo de deshabilitar
            DeshabilitarHabilitarBotones(false);
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            _clientes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientesBindingSource.Current;

            if (cliente != null)
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
                MessageBox.Show("Cree un cliente antes de asignale una imagen.,");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
