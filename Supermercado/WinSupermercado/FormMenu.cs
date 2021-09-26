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

        private void hideSubMenu()
        {

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
    }
}
