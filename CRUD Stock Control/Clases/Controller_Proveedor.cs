using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using CRUD_Stock_Control.Clases;

namespace CRUD_Stock_Control.Controladores
{
    internal class Controller_Proveedor
    {
        Conexion cn = new Conexion();

        public void GuardarProveedor(string codigo, string nombre, string celular, string distribuye, string direccion, string nota)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(codigo) ||
                    string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(celular) ||
                    string.IsNullOrWhiteSpace(distribuye) ||
                    string.IsNullOrWhiteSpace(direccion) ||
                    string.IsNullOrWhiteSpace(nota))
                {
                    MessageBox.Show("⚠️ Todos los campos son obligatorios. Por favor complete la información.",
                        "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                MySqlConnection conexion = cn.establecerConexion();

                string sql = "INSERT INTO proveedor (codigo_proveedor, nombre_proveedor, celular, distribuye, direccion, nota) " +
                             "VALUES (@codigo, @nombre, @celular, @distribuye, @direccion, @nota)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@distribuye", distribuye);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@nota", nota);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("✅ Proveedor guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se pudo guardar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                cn.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
