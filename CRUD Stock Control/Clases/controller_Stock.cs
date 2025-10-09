using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Stock_Control.Clases
{
    internal class controller_Stock
    {
        private Conexion conexionBD = new Conexion();

        // 🔍 Buscar producto por código
        public void BuscarPorCodigo(TextBox txtCodigo, DataGridView tabla)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor ingrese un código de producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MySqlConnection conex = conexionBD.establecerConexion();
            if (conex == null) return;

            try
            {
                string consulta = "SELECT * FROM producto WHERE codigo_producto = @codigo";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    tabla.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese código.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabla.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conex.Close();
            }
        }

        // 📋 Cargar todos los productos
        public void CargarTodo(DataGridView tabla)
        {
            MySqlConnection conex = conexionBD.establecerConexion();
            if (conex == null) return;

            try
            {
                string consulta = "SELECT * FROM producto";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conex.Close();
            }
        }
    }
}
