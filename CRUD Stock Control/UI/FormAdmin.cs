using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using CRUD_Stock_Control.Clases;

namespace CRUD_Stock_Control.UI
{
    public partial class FormAdmin : Form
    {
        Conexion cn = new Conexion();
        MySqlDataAdapter adaptador;
        DataTable tablaActual;
        string tablaActualName;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dgvAdm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdm.MultiSelect = false;
            dgvAdm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdm.DataSource = null;
            UITheme.ApplyNeonStyle(btnGuardarcambios);
            UITheme.ApplySuccessStyle(btnEliminar);
            UITheme.ApplyNeonStyle(btnCerrarsesion);

            UITheme.ApplyTooltip(btnGuardarcambios, "Guarda los cambios hechos en la base de datos");
            UITheme.ApplyTooltip(btnEliminar, "Eliminar datos seleccionados");
            UITheme.ApplyTooltip(btnCerrarsesion, "cerrar la sesion");

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
                    string tablaActualName = nombreTabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla: " + ex.Message);
            }
        }




        private void btnProveedores_Click(object sender, EventArgs e)
        {
            CargarTabla("proveedor");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CargarTabla("producto");
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            CargarTabla("salidas");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CargarTabla("registro");
        }

        private void btnIniciosdesesion_Click_1(object sender, EventArgs e)
        {
            CargarTabla("iniciosesion");
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            CargarTabla("proveedor");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvAdm.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
                return;
            }

            if (string.IsNullOrEmpty(tablaActualName))
            {
                MessageBox.Show("Selecciona una tabla antes de eliminar.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvAdm.CurrentRow.Cells[0].Value);

                using (MySqlConnection conexion = cn.establecerConexion())
                {
                    string consulta = $"DELETE FROM {tablaActualName} WHERE {dgvAdm.Columns[0].HeaderText} = @id";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                dgvAdm.Rows.RemoveAt(dgvAdm.CurrentRow.Index);
                MessageBox.Show("Registro eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion login = new InicioSesion();
            login.Show();
        }

        private void btnGuardarcambios_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                ;
                using (MySqlConnection con = cn.establecerConexion())
                {
                    if (con != null)
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM " + tablaActualName, con);
                        MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                        DataTable dtCambios = (DataTable)dgvAdm.DataSource;
                        da.UpdateCommand = cb.GetUpdateCommand();
                        da.DeleteCommand = cb.GetDeleteCommand();
                        da.InsertCommand = cb.GetInsertCommand();
                        da.Update(dtCambios);
                        MessageBox.Show("Cambios guardados correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo establecer la conexión.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
            
        }
    }
}
