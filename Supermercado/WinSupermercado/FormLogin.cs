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
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad; 
        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//botón de cerrar
            //cierra el sistema
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {//botón de entrar
            //variable para el  usuario y contraseña
            string Usuario;
            string Contra;

            Usuario = textBox1.Text;
            Contra = textBox2.Text;

            var resultado = _seguridad.Autorizar(Usuario, Contra);
            //inicio del ciclo if-else
            if (resultado == true)
            {
                this.Close();
                MessageBox.Show("Bienvenidos a Super Market P.O.S");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta!");
            }//fin del ciclo if-else


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//validacion del checkbox- que hace visible la contraseña
         //inicio del ciclo if-else
            if (checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
                else
                {
                    textBox2.PasswordChar = '*';
                }
            }else
            {
                textBox2.PasswordChar = '*';
            }//fin del ciclo if-else
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a Super Market P.O.S");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
