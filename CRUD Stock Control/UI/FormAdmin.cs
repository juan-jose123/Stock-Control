using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using CRUD_Stock_Control.Clases;


namespace CRUD_Stock_Control.UI
{
    public partial class FormAdmin : Form
    {
        Controller_Admin adminController = new Controller_Admin();
        Conexion cn = new Conexion();
        MySqlDataAdapter adaptador;
        DataTable tablaActual;
        string tablaActualName;

        
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblUsuario;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CrearBarraSuperior(); 

            UITheme.ApplyNeonStyle(btnProveedores);
            UITheme.ApplySuccessStyle(btnProducto);
            UITheme.ApplyNeonStyle(btnSalidas);
            UITheme.ApplySuccessStyle(btnUsuarios);
            UITheme.ApplyNeonStyle(btnIniciosdesesion);

            dgvAdm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdm.MultiSelect = false;
            dgvAdm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdm.DataSource = null;

            UITheme.ApplyNeonStyle(btnGuardarcambios);
            UITheme.ApplySuccessStyle(btnEliminar);
            UITheme.ApplyNeonStyle(btnCerrarsesion);

            UITheme.ApplyTooltip(btnGuardarcambios, "Guarda los cambios hechos en la base de datos");
            UITheme.ApplyTooltip(btnEliminar, "Eliminar datos seleccionados");
            UITheme.ApplyTooltip(btnCerrarsesion, "Cerrar sesión");
        }

        
        private void CrearBarraSuperior()
        {
            panelSuperior = new Panel();
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Height = 40;
            panelSuperior.BackColor = Color.FromArgb(20, 20, 20);

            lblTitulo = new Label();
            lblTitulo.Text = "🏭 INVENTARIO - STOCK CONTROL";
            lblTitulo.ForeColor = Color.FromArgb(0, 174, 239);
            lblTitulo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);

            lblUsuario = new Label();
            lblUsuario.Text = "👤 " + CRUD_Stock_Control.Clases.SesionActual.Usuario;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblUsuario.AutoSize = true;
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.Location = new Point(panelSuperior.Width - 150, 10);

            Button btnCerrar = new Button();
            btnCerrar.Text = "X";
            btnCerrar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.FromArgb(30, 30, 30);
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.Location = new Point(panelSuperior.Width - 45, 0);
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;

            btnCerrar.MouseEnter += (s, e) =>
            {
                btnCerrar.BackColor = Color.Red;
                btnCerrar.ForeColor = Color.Black;
            };
            btnCerrar.MouseLeave += (s, e) =>
            {
                btnCerrar.BackColor = Color.FromArgb(30, 30, 30);
                btnCerrar.ForeColor = Color.White;
            };
            btnCerrar.Click += (s, e) => { this.Close(); };

            panelSuperior.MouseDown += panelSuperior_MouseDown;
            lblTitulo.MouseDown += panelSuperior_MouseDown;
            lblUsuario.MouseDown += panelSuperior_MouseDown;

            panelSuperior.Resize += (s, e) =>
            {
                btnCerrar.Location = new Point(panelSuperior.Width - 45, 0);
                lblUsuario.Location = new Point(panelSuperior.Width - 150, 10);
            };

            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Controls.Add(lblUsuario);
            panelSuperior.Controls.Add(btnCerrar);
            this.Controls.Add(panelSuperior);
            panelSuperior.BringToFront();
        }

        
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void CargarTabla(string nombreTabla)
        {
            try
            {
                dgvAdm.DataSource = null;
                tablaActual = new DataTable();

                using (MySqlConnection conexion = cn.establecerConexion())
                {
                    string consulta = $"SELECT * FROM {nombreTabla}";
                    adaptador = new MySqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tablaActual);
                    dgvAdm.DataSource = tablaActual;
                    tablaActualName = nombreTabla; // ✅ guarda el nombre actual aquí
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla: " + ex.Message);
            }
        }


        private void btnProveedores_Click(object sender, EventArgs e) => CargarTabla("proveedor");
        private void button3_Click_1(object sender, EventArgs e) => CargarTabla("producto");
        private void btnSalidas_Click(object sender, EventArgs e) => CargarTabla("salidas");
        private void btnUsuarios_Click(object sender, EventArgs e) => CargarTabla("registro");
        private void btnIniciosdesesion_Click_1(object sender, EventArgs e) => CargarTabla("iniciosesion");
        private void btnProveedores_Click_1(object sender, EventArgs e) => CargarTabla("proveedor");

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tablaActualName))
            {
                MessageBox.Show("No hay una tabla cargada actualmente.");
                return;
            }

            
            string columnaID = "";
            switch (tablaActualName.ToLower())
            {
                case "producto":
                    columnaID = "id_producto";
                    break;
                case "proveedor":
                    columnaID = "id_proveedor";
                    break;
                case "salidas":
                    columnaID = "id_salida";
                    break;
                case "Usuarios":
                    columnaID = "id_inicios";
                    break;
                case "iniciosesion":
                    columnaID = "id_inicio";
                    break;
                default:
                    MessageBox.Show("No se reconoce la clave primaria de la tabla seleccionada.");
                    return;
            }

            adminController.EliminarFila(dgvAdm, tablaActualName, columnaID);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            adminController.CerrarSesion(this);
        }

        private void btnGuardarcambios_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tablaActualName))
            {
                MessageBox.Show("No hay una tabla cargada actualmente.");
                return;
            }

            adminController.GuardarCambios(dgvAdm, tablaActualName);
        }
    }
}