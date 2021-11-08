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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelAdmi.Visible = false;
            panelCompras.Visible = false;
            panelInventarios.Visible = false;
            panelVenta.Visible = false;
        }

        //Creamos metodo para ocultar el subMenu
        private void hideSubMenu()
        {
            if(panelAdmi.Visible == true)
            {
                panelAdmi.Visible = false;
            }

            if (panelCompras.Visible == true)
            {
                panelCompras.Visible = false;
            }

            if (panelInventarios.Visible == true)
            {
                panelInventarios.Visible = false;
            }

            if (panelVenta.Visible == true)
            {
                panelVenta.Visible = false;
            }
        }

        //Creamos metodo para ver el SubMenu
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVender = new FormVender();
            formVender.MdiParent = this;
            formVender.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {//al darle click despliega el panel o la lista del botón.
            ShowSubMenu(panelAdmi);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {//Llamamos al formulario de login
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {//llamamos el formulario de inventario general
            openChildForm(new FormInventarios());
            /*var formInventarios = new FormInventarios();
            formInventarios.MdiParent = this;
            formInventarios.Show();*/
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {//llamamos al formulario de salida y devoluciones
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {//llamamos al formulario de Control de proveedores
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {//llamamos al formulario de Pedidos de proveedores
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {//llamamos al formulario de libro de compra y venta
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {//llamamos al formulario de cobro
            hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {//llamamos al formulario de ventas
            openChildForm(new FormVender());
            /*var formVender = new FormVender();
            formVender.MdiParent = this;
            formVender.Show();*/
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {//llamamos al formulario de producto
            openChildForm(new FormProductos());
            /*var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();*/

            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {//llamamos al formulario de Reporte de venta
            openChildForm(new FormReporteVenta());
            /*var formReporteVenta = new FormReporteVenta();
            formReporteVenta.MdiParent = this;
            formReporteVenta.Show();*/

            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {//llamamos al formulario de reporte de Clientes
            openChildForm(new FormReporteCliente());
            /*var formReporteCliente = new FormReporteCliente();
            formReporteCliente.MdiParent = this;
            formReporteCliente.Show();*/
            hideSubMenu();
        }

       /* private void button19_Click(object sender, EventArgs e)
        {//llamamos al formulario de Reporte de Productos
           
            var formFactura = new FormFactura();
            formFactura.ShowDialog();
            hideSubMenu();

        }*/

        private void btnInven_Click(object sender, EventArgs e)
        {//al darle click despliega el panel o la lista del botón.
            ShowSubMenu(panelInventarios);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {//al darle click despliega el panel o la lista del botón.
            ShowSubMenu(panelCompras);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelVenta);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
            hideSubMenu();
        }

       

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSeguridad_Click_1(object sender, EventArgs e)
        {//llamamos al formulario de Seguridad
            openChildForm(new FormSeguridad());
            /*var formSeguridad = new FormSeguridad();
            formSeguridad.MdiParent = this;
            formSeguridad.Show();*/
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {//Cierre de la sesion
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new FromFactura());
        }
    }
}
