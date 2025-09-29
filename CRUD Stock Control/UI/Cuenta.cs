using CRUD_Stock_Control.Clases;
using CRUD_Stock_Control.Controladores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Stock_Control.UI
{
    public partial class Cuenta : Form
    {
        public Cuenta()
        {
            InitializeComponent();
        }

        private void dgvCuenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Cuenta_Load(object sender, EventArgs e)
        {
            string usuario = SesionActual.Usuario;

            using (var con = new MySqlConnection("server=127.0.0.1;port=3306;user id=root;password=3212;database=crud;"))
            {
                con.Open();
                string query = "SELECT Nombre, Usuario, Contraseña, codigoEmpleado, Celular FROM registro WHERE Usuario = @usuario";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCuenta.DataSource = dt;
                dgvCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void txtCerrarSesion_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(form is InicioSesion))
                {
                    form.Hide();
                }
            }


            InicioSesion login = new InicioSesion();
            login.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string contraseñaIngresada = Microsoft.VisualBasic.Interaction.InputBox(
        "Para ver los datos de la cuenta, ingresa tu contraseña:",
        "Verificación de seguridad",
        ""
    );

            if (string.IsNullOrEmpty(contraseñaIngresada))
            {
                MessageBox.Show("Debes ingresar tu contraseña para continuar.");
                return;
            }

            
            Controller_cuenta controller = new Controller_cuenta();
            bool esValida = controller.VerificarContraseña(SesionActual.Usuario, contraseñaIngresada);

            if (!esValida)
            {
                MessageBox.Show("❌ Contraseña incorrecta.");
                return;
            }

            
            dgvCuenta.DataSource = controller.ObtenerCuentaUsuario();
            dgvCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}

