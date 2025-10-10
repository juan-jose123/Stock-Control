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
    public partial class Stock : Form
    {
        private controller_Stock controller = new controller_Stock();
        public Stock()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            controller.BuscarPorCodigo(txtCodigoProducto, tablaProductos);
        }

        private void btnCargartodo_Click(object sender, EventArgs e)
        {
            controller.CargarTodo(tablaProductos);
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
