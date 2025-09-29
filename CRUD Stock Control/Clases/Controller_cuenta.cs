using CRUD_Stock_Control.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_Stock_Control.Controladores
{
    internal class Controller_cuenta
    {
        public DataTable ObtenerCuentaUsuario()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM registro WHERE Usuario = @usuario";

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.establecerConexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", SesionActual.Usuario);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return tabla;
        }
        public bool VerificarContraseña(string usuario, string contraseña)
        {
            string query = "SELECT COUNT(*) FROM registro WHERE Usuario = @usuario AND Contraseña = @contraseña";

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.establecerConexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar contraseña: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }



    }
}