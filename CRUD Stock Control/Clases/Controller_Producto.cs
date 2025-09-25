using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using CRUD_Stock_Control.Clases;

namespace CRUD_Stock_Control.Controladores
{
    internal class Controller_Producto
    {
        Conexion cn = new Conexion();

        public void GuardarProducto(string nombre, string codigoProducto, int cantidad, string codigoProveedor, decimal precio)
        {
            try
            {
                using (MySqlConnection conexion = cn.establecerConexion()) 
                {
                   
                    string querySelect = "SELECT id_producto, cantidad FROM producto " +
                                         "WHERE nombre_producto = @nombre AND codigo_producto = @codigoProducto AND codigo_proveedor = @codigoProveedor";

                    using (MySqlCommand cmdSelect = new MySqlCommand(querySelect, conexion))
                    {
                        cmdSelect.Parameters.AddWithValue("@nombre", nombre);
                        cmdSelect.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                        cmdSelect.Parameters.AddWithValue("@codigoProveedor", codigoProveedor);

                        using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                int idProducto = reader.GetInt32("id_producto");
                                int cantidadActual = reader.GetInt32("cantidad");
                                int nuevaCantidad = cantidadActual + cantidad;

                                reader.Close();

                                string queryUpdate = "UPDATE producto SET cantidad = @cantidad, precio = @precio WHERE id_producto = @id";
                                using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conexion))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                                    cmdUpdate.Parameters.AddWithValue("@precio", precio);
                                    cmdUpdate.Parameters.AddWithValue("@id", idProducto);

                                    cmdUpdate.ExecuteNonQuery();
                                }
                                return;
                            }
                        }
                    }

                    
                    string queryInsert = "INSERT INTO producto (nombre_producto, codigo_producto, cantidad, codigo_proveedor, precio) " +
                                         "VALUES (@nombre, @codigoProducto, @cantidad, @codigoProveedor, @precio)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conexion))
                    {
                        cmdInsert.Parameters.AddWithValue("@nombre", nombre);
                        cmdInsert.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                        cmdInsert.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdInsert.Parameters.AddWithValue("@codigoProveedor", codigoProveedor);
                        cmdInsert.Parameters.AddWithValue("@precio", precio);

                        cmdInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Producto guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.Message);
            }
        }

    }
}
