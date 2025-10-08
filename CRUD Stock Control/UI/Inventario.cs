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

        // 👉 Método reutilizable para abrir formularios dentro del panel
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Elimina cualquier control previo dentro del panel
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            // Configura el formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agrega el formulario al panel
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        // 🔘 Botón para cerrar el formulario principal
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        // 🔘 Botón Proveedor
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Proveedor());
        }

        // 🔘 Botón Producto
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Producto());
        }

        // 🔘 Botón Stock
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Stock());
        }

        // 🔘 Botón Proveedores
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Proveedores());
        }

        // 🔘 Botón Salidas
        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new btnSalidas());
        }

        // 🔘 Botón Cuenta
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

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
