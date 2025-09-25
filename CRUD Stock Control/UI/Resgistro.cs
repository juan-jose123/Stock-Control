using CRUD_Stock_Control.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Stock_Control
{
    public partial class Resgistro : Form
    {
        public Resgistro()
        {
            InitializeComponent();
            Controller_iniciosesion_registro registro = new Controller_iniciosesion_registro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !cbMostrar.Checked;
        }

        private void cbmostrarEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoEmpleado.UseSystemPasswordChar = !cbMostrar.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string celular = txtCelular.Text.Trim();
            int codigoEmpleado;

            if (!int.TryParse(txtCodigoEmpleado.Text.Trim(), out codigoEmpleado))
            {
                MessageBox.Show("Código de empleado inválido.");
                return;
            }

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }

            var controlador = new Controller_iniciosesion_registro();
            bool registrado = controlador.RegistrarUsuario(nombre, usuario, contraseña, codigoEmpleado, celular);

            if (registrado)
            {
                MessageBox.Show("✅ Registro exitoso.");
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Error al registrar. Verifica los datos o si el usuario ya existe.");
            }
            InicioSesion ventanaLogin = new InicioSesion();
            ventanaLogin.Show();
            this.Close();
        }

        private void txtCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtCodigoEmpleado.UseSystemPasswordChar = !cbMostrar.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoEmpleado.UseSystemPasswordChar = !cbMostrar.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

