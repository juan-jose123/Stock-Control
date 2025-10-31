using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CRUD_Stock_Control.Clases
{
    internal class Controller_iniciosesion_registro
    {
        
        public bool RegistrarUsuario(string nombre, string usuario, string contraseña, int codigoEmpleado, string celular)
        {
            bool registrado = false;

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.establecerConexion();

            try
            {
                
                string verificarQuery = "SELECT COUNT(*) FROM registro WHERE Usuario = @usuario";
                using (MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, conn))
                {
                    verificarCmd.Parameters.AddWithValue("@usuario", usuario);
                    int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        Console.WriteLine("❌ El nombre de usuario ya está registrado.");
                        return false;
                    }
                }

                
                string query = "INSERT INTO registro (Nombre, Usuario, Contraseña, codigoEmpleado, Celular) " +
                               "VALUES (@nombre, @usuario, @contraseña, @codigoEmpleado, @celular)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@codigoEmpleado", codigoEmpleado);
                    cmd.Parameters.AddWithValue("@celular", celular);

                    cmd.ExecuteNonQuery();
                    registrado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return registrado;
        }


        public Dictionary<string, string> IniciarSesion(string usuario, string contraseña)
        {
            Dictionary<string, string> datosUsuario = new Dictionary<string, string>();
            string query = "SELECT * FROM registro WHERE Usuario = @usuario AND Contraseña = @contraseña";

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.establecerConexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            datosUsuario["id"] = reader["id_inicios"].ToString();
                            datosUsuario["Nombre"] = reader["Nombre"].ToString();
                            datosUsuario["Usuario"] = reader["Usuario"].ToString();
                            datosUsuario["Celular"] = reader["Celular"].ToString();
                            datosUsuario["codigoEmpleado"] = reader["codigoEmpleado"].ToString();
                            datosUsuario["Rol"] = reader["Rol"].ToString(); // 👈 nuevo
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar sesión: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return datosUsuario;
        }



        public bool RegistrarInicioSesion(string usuario, string contraseña)
        {
            bool guardado = false;
            string query = "INSERT INTO inicioSesion (Usuario, Contraseña) VALUES (@usuario, @contraseña)";

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.establecerConexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    cmd.ExecuteNonQuery();
                    guardado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar inicio de sesión: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return guardado;
        }
        

    }
}