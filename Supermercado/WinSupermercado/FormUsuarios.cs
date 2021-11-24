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
using static BL.Supermercado.SeguridadBL;

namespace WinSupermercado
{
    public partial class FormUsuarios : Form
    {
        SeguridadBL _usuarios;

        public FormUsuarios()
        {
            InitializeComponent();

            _usuarios = new SeguridadBL();
            listaUsuariosBindingSource.DataSource = _usuarios.ObtenerUsuarios();

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
           
            var resultado = _usuarios.EliminarUsuario(id);

            if (resultado == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Usuarios");
            }
        }
        
        

        private void listaUsuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaUsuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            listaUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                usuario.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                usuario.Foto = null;
            }
            var resultado = _usuarios.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuarios guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            _usuarios.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();
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
            _usuarios.CancelarCambios();
            DeshabilitarHabilitarBotones(true);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            if (usuario != null)
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
                MessageBox.Show("Cree un usuario antes de asignale una imagen.,");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (contrasenaTextBox.PasswordChar == '*')
            {
                contrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                contrasenaTextBox.PasswordChar = '*';
            }
            }else
            {
                contrasenaTextBox.PasswordChar = '*';
            }//fin del ciclo if-else
}
    }
}
