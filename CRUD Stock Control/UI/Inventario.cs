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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelProducto_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            using (Proveedor frm = new Proveedor())
            {
               
                frm.ShowDialog(this);
            }
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Producto frm = new Producto())
            {

                frm.ShowDialog(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stock frm = new Stock())
            {

                frm.ShowDialog(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Proveedores frm = new Proveedores())
            {

                frm.ShowDialog(this);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Salidas frm = new Salidas())
            {

                frm.ShowDialog(this);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Cuenta frm = new Cuenta())
            {

                frm.ShowDialog(this);
            }
        }

        private void panelInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
