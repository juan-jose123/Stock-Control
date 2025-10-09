using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace CRUD_Stock_Control.Clases
{
    internal class controller_Salidas
    {
        private Conexion conexionBD = new Conexion();

        // ✅ Método para guardar una salida y actualizar el stock
        public void GuardarSalida(DateTimePicker fechaSalida, TextBox codigoProducto, TextBox nombreProducto,
                                  TextBox cantidadSalida, TextBox motivo, TextBox precioUnitario, TextBox responsable)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(codigoProducto.Text) ||
                string.IsNullOrWhiteSpace(nombreProducto.Text) ||
                string.IsNullOrWhiteSpace(cantidadSalida.Text) ||
                string.IsNullOrWhiteSpace(precioUnitario.Text) ||
                string.IsNullOrWhiteSpace(responsable.Text))
            {
                MessageBox.Show("⚠️ Todos los campos obligatorios deben estar llenos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conex = conexionBD.establecerConexion();
            if (conex == null) return;

            try
            {
                // 🔹 Verificar si el producto existe
                string verificarProducto = "SELECT cantidad FROM producto WHERE codigo_producto = @codigo";
                MySqlCommand cmdVerificar = new MySqlCommand(verificarProducto, conex);
                cmdVerificar.Parameters.AddWithValue("@codigo", codigoProducto.Text.Trim());

                object result = cmdVerificar.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("❌ El producto con ese código no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int cantidadActual = Convert.ToInt32(result);
                int cantidadSalidaInt = Convert.ToInt32(cantidadSalida.Text.Trim());

                // 🔹 Validar si hay suficiente stock
                if (cantidadSalidaInt > cantidadActual)
                {
                    MessageBox.Show("⚠️ No hay suficiente stock disponible. Stock actual: " + cantidadActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Insertar la salida
                string consulta = @"INSERT INTO Salidas (fecha_salida, codigo_producto, nombre_producto, 
                                    cantidad_salida, motivo, precio_unitario, responsable)
                                    VALUES (@fecha, @codigo, @nombre, @cantidad, @motivo, @precio, @responsable)";

                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@fecha", fechaSalida.Value.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@codigo", codigoProducto.Text.Trim());
                comando.Parameters.AddWithValue("@nombre", nombreProducto.Text.Trim());
                comando.Parameters.AddWithValue("@cantidad", cantidadSalidaInt);
                comando.Parameters.AddWithValue("@motivo", motivo.Text.Trim());
                comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(precioUnitario.Text.Trim()));
                comando.Parameters.AddWithValue("@responsable", responsable.Text.Trim());

                comando.ExecuteNonQuery();

                // 🔹 Actualizar stock en producto
                string actualizarStock = "UPDATE producto SET cantidad = cantidad - @cantidad WHERE codigo_producto = @codigo";
                MySqlCommand cmdActualizar = new MySqlCommand(actualizarStock, conex);
                cmdActualizar.Parameters.AddWithValue("@cantidad", cantidadSalidaInt);
                cmdActualizar.Parameters.AddWithValue("@codigo", codigoProducto.Text.Trim());
                cmdActualizar.ExecuteNonQuery();

                MessageBox.Show("✅ Salida registrada y stock actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conex.Close();
            }
        }

        // ✅ Método para exportar todas las salidas a Excel
        public void ExportarSalidasAExcel()
        {
            MySqlConnection conex = conexionBD.establecerConexion();
            if (conex == null) return;

            try
            {
                string consulta = "SELECT * FROM Salidas";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("⚠️ No hay datos en la tabla de Salidas para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet hoja = excelApp.ActiveSheet;
                hoja.Name = "Salidas";

                // Encabezados
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    hoja.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                }

                // Datos
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        hoja.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }

                // Estilo básico
                Excel.Range headerRange = hoja.Range["A1", hoja.Cells[1, dt.Columns.Count]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                hoja.Columns.AutoFit();

                // Guardar archivo
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                saveFile.FileName = "Reporte_Salidas_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    hoja.SaveAs(saveFile.FileName);
                    excelApp.Quit();
                    MessageBox.Show("✅ Archivo Excel generado correctamente:\n" + saveFile.FileName, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    excelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conex.Close();
            }
        }
    }
}
