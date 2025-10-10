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
    public partial class btnSalidas : Form
    {
        controller_Salidas controlador = new controller_Salidas();
        public btnSalidas()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSalidas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlador.GuardarSalida(FechaSalida, txtCodigoProducto, txtNombreProducto,
                                       txtCantidadSalida, txtMotivo, txtPrecioUnitario, txtResponsable);
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            controlador.ExportarSalidasAExcel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
