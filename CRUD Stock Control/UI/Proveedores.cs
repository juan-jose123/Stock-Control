using CRUD_Stock_Control.Clases;
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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codigoProveedor = txtCodigoProveedor.Text.Trim();

            if (string.IsNullOrEmpty(codigoProveedor))
            {
                MessageBox.Show("Ingrese un código de proveedor.");
                return;
            }

            Controller_proveedores controller = new Controller_proveedores();
            string suministro = controller.BuscarSuministroPorCodigo(codigoProveedor);

            if (!string.IsNullOrEmpty(suministro))
            {
                label3.Text = suministro;
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.");
                label3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller_proveedores controller = new Controller_proveedores();
            dgvproveedores.DataSource = controller.ObtenerProveedores();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
