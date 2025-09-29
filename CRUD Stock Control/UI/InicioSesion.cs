using CRUD_Stock_Control.Clases;
using CRUD_Stock_Control.UI;
using Microsoft.Win32;

namespace CRUD_Stock_Control
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            Controller_iniciosesion_registro registro = new Controller_iniciosesion_registro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingresa usuario y contraseña.");
                return;
            }

            var controlador = new Controller_iniciosesion_registro();
            var datos = controlador.IniciarSesion(usuario, contraseña);

            if (datos.Count > 0)
            {
                // Guardamos en la tabla inicioSesion
                controlador.RegistrarInicioSesion(usuario, contraseña);

                // ✅ Guardamos el usuario en la sesión global
                SesionActual.Usuario = datos["Usuario"];  // 🔴 AQUÍ ERA EL CAMBIO

                MessageBox.Show("✅ Bienvenido " + datos["Nombre"]);

                Inventario ventanaInventario = new Inventario();
                ventanaInventario.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos.");
            }
        }


        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !cbMostrar.Checked;
        }

        private void btnRegistrame_Click(object sender, EventArgs e)
        {

            Resgistro ventanaRegistro = new Resgistro();
            ventanaRegistro.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


