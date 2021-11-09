using BL.Supermercado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSupermercado
{
    public partial class FromFactura : Form
    {
        FacturaBL _facturaBL;
        ClientesBL _clientesBL;
        ProductosBL _productosBL;

        public FromFactura()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new ProductosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //cancelar
            DeshabilitarHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaClientesBindingSource.MoveLast();

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

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();

            var factura = (Factura)listaFacturasBindingSource.Current;
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaClientesBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            listaFacturasBindingSource.ResetBindings(false);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox1.Text != "")
            {
                var resultado = MessageBox.Show("Desea anular esta factura", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox1.Text);
                    Anular(id);
                }
            }
        }
        public void Anular(int id)
        {
            var resultado = _facturaBL.AnularFactura(id);
            if (resultado == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura", "Anular", MessageBoxButtons.YesNo);

            }
        }

        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaClientesBindingSource.Current;
            if(factura != null && factura.Id !=0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }


        }
    }
}
