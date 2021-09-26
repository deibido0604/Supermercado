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

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            MessageBox.Show("Bienvenidos a Super Market P.O.S");
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClietes = new FormClientes();
            formClietes.MdiParent = this;
            formClietes.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdmi);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVender());
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelInventarios);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
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

        private void button5_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
