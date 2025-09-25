using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CRUD_Stock_Control.Clases
{
    internal class Conexion
    {
        
        static string servidor = "127.0.0.1";
        static string bd = "crud";
        static string usuario = "root";
        static string password = "3212";
        static string puerto = "3306";

        string cadenaConexion =
            "server=" + servidor + ";" +
            "port=" + puerto + ";" +
            "user id=" + usuario + ";" +
            "password=" + password + ";" +
            "database=" + bd + ";";

        
        public MySqlConnection establecerConexion()
        {
            try
            {
                MySqlConnection conex = new MySqlConnection(cadenaConexion);
                conex.Open();
                return conex;
            }
            catch (Exception e)
            {
                MessageBox.Show("❌ Error de conexión: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void cerrarConexion()
        {
            
        }

    }
}
