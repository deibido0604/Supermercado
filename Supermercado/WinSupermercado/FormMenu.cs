using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSupermercado;

namespace WinSupermercado
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

       /* private void btnUser_Click_1(object sender, EventArgs e)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form f in forms)
            {
                if(f.Name != "FormMenu")
                {
                    f.Close();
                }
            }

           // btnUser_Click_1();
        }*/

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

       /* private void btnUser_Click()
        {//Llamamos al formulario de login
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario: " + Utilidades.UsuarioActual.Nombre;

            if(Utilidades.UsuarioActual.EsAdmin == true)
            {
                //btnSeguridad.Visible = true;
            }else
            {
                //btnSeguridad.Visible = false;
                //button17.Visible = Utilidades.UsuarioActual.PuedeAccederProductos;
                //button15.Visible = Utilidades.UsuarioActual.PuedeAccederClientes;
                //button19.Visible = Utilidades.UsuarioActual.PuedeAccederFacturas;
                //button16.Visible = Utilidades.UsuarioActual.PuedeAccederReportes;
                //button1.Visible = Utilidades.UsuarioActual.PuedeAccederReportes;
            }

            hideSubMenu();
        }*/
        

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteProducto());

            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProductos());
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
            openChildForm(new FormReporteFacturas());
            /* var formReporteVenta = new FormReporteVenta();
             formReporteVenta.MdiParent = this;
             formReporteVenta.Show();*/

            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {//llamamos al formulario de reporte de Clientes
            openChildForm(new FormClientes());
            /*var formReporteCliente = new FormReporteCliente();
            formReporteCliente.MdiParent = this;
            formReporteCliente.Show();*/
            hideSubMenu();
        }

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
            openChildForm(new FormUsuarios());
            /*var formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();*/
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

           hideSubMenu();
          

            /*var formFactura = new FromFactura();
            formFactura.MdiParent = this;
            formFactura.Show();*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormReporteProducto());
          
            hideSubMenu();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form f in forms)
            {
                if (f.Name != "FormMenu")
                {
                    f.Close();
                }
            }

            Login();

            hideSubMenu();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario: " + Utilidades.UsuarioActual.Nombre;

            if (Utilidades.UsuarioActual.EsAdmin == true)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
                btnCompra.Visible = Utilidades.UsuarioActual.PuedeAccederProductos;
                button2.Visible = Utilidades.UsuarioActual.PuedeAccederClientes;
                btnVenta.Visible = Utilidades.UsuarioActual.PuedeAccederFacturas;
                btnInven.Visible = Utilidades.UsuarioActual.PuedeAccederReportes;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            openChildForm(new FormClientes());

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteFacturas());

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsuarios());

            hideSubMenu();
        }
    }
}
