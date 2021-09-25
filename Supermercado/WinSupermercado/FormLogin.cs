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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contra;

            Usuario = textBox1.Text;
            Contra = textBox2.Text;

            if (Usuario =="admin" && Contra == "123")
            {
                this.Close;  
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta!");
            }
        }
    }
}
