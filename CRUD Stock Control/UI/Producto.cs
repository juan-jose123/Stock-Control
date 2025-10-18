using CRUD_Stock_Control.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Stock_Control.UI
{
    public partial class Producto : Form

    {
        Controller_Producto controller = new Controller_Producto();
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            UITheme.ApplyNeonStyle(btnGuardar);
            UITheme.ApplySuccessStyle(btnListaCodigos);
            
            UITheme.ApplyTooltip(btnGuardar, "Guarda el producto en la base de datos");
            UITheme.ApplyTooltip(btnListaCodigos, "Ver los codigos registrados en el sistema");

            
            



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Controller_Producto controller = new Controller_Producto();


                string nombre = txtNombreproducto.Text.Trim();
                string codigoProducto = txtCodigoproducto.Text.Trim();
                string codigoProveedor = txtCodigoproveedor.Text.Trim();
                decimal precio;
                int cantidad;


                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(codigoProducto) || string.IsNullOrEmpty(codigoProveedor))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }


                if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad))
                {
                    MessageBox.Show("Ingrese un número válido en la cantidad.");
                    return;
                }


                if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio))
                {
                    MessageBox.Show("Ingrese un número válido en el precio.");
                    return;
                }


                controller.GuardarProducto(nombre, codigoProducto, cantidad, codigoProveedor, precio);


                txtNombreproducto.Clear();
                txtCodigoproducto.Clear();
                txtCantidad.Clear();
                txtCodigoproveedor.Clear();
                txtPrecio.Clear();

                MessageBox.Show("Operación realizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnListaCodigos_Click(object sender, EventArgs e)
        {
            controller.MostrarCodigosEnTabla(dataGridViewCodigos);
        }
    }
}
