using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_Stock_Control.Clases
{
    internal class Controller_proveedores
    {
        Conexion cn = new Conexion();

        // 🔹 Método para obtener todos los proveedores excepto el id_proveedor
        public DataTable ObtenerProveedores()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conexion = cn.establecerConexion())
                {
                    string sql = "SELECT codigo_proveedor, nombre_proveedor, celular, distribuye, direccion, nota FROM proveedor";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al obtener los proveedores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

        // 🔹 Método para buscar qué suministra un proveedor según su código
        public string BuscarSuministroPorCodigo(string codigoProveedor)
        {
            string suministro = "";

            try
            {
                using (MySqlConnection conexion = cn.establecerConexion())
                {
                    string sql = "SELECT distribuye FROM proveedor WHERE codigo_proveedor = @codigo";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigoProveedor);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            suministro = result.ToString();
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al buscar proveedor: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return suministro;
        }
    }
}
