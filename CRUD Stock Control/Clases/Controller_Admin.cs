using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Stock_Control.Clases
{
    internal class Controller_Admin
    {
        private Conexion conexionBD = new Conexion();

        
        public void GuardarCambios(DataGridView dgv, string nombreTabla)
        {
            try
            {
                if (dgv.DataSource == null)
                {
                    MessageBox.Show("⚠️ No hay datos para guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conex = conexionBD.establecerConexion())
                {
                    if (conex == null) return;

                    string query = $"SELECT * FROM {nombreTabla}";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conex);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(da);

                    
                    DataTable dt = (DataTable)dgv.DataSource;

                    foreach (DataColumn col in dt.Columns)
                    {
                        if (!string.IsNullOrEmpty(col.ColumnName))
                        {
                            col.ColumnMapping = MappingType.Element;
                        }
                    }

                    da.UpdateCommand = builder.GetUpdateCommand();
                    da.InsertCommand = builder.GetInsertCommand();
                    da.DeleteCommand = builder.GetDeleteCommand();

                    da.Update(dt);
                    MessageBox.Show("✅ Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void EliminarFila(DataGridView dgv, string nombreTabla, string columnaId)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("⚠️ Seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow fila = dgv.SelectedRows[0];

                if (!fila.Cells.Contains(fila.Cells[columnaId]))
                {
                    MessageBox.Show($"❌ La columna '{columnaId}' no existe en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = Convert.ToInt32(fila.Cells[columnaId].Value);

                DialogResult confirm = MessageBox.Show(
                    $"¿Desea eliminar el registro con ID {id}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes) return;

                using (MySqlConnection conex = conexionBD.establecerConexion())
                {
                    if (conex == null) return;

                    string query = $"DELETE FROM {nombreTabla} WHERE {columnaId} = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conex);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    dgv.Rows.Remove(fila);
                    MessageBox.Show("🗑️ Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CerrarSesion(Form formularioActual)
        {
            DialogResult result = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                formularioActual.Hide();
                MessageBox.Show("👋 Sesión cerrada correctamente.", "Cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
