using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Stock_Control.UI
{
    public partial class Inventario : Form
    {
        
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblUsuario;

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CrearBarraSuperior(); 

            StyleNeonButton(button2);
            StyleNeonButton(button3);
            StyleNeonButton(button5);
            StyleNeonButton(button4);
            StyleNeonButton(button6);
            StyleNeonButton(button7);
        }

       
        private void CrearBarraSuperior()
        {
            panelSuperior = new Panel();
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Height = 40;
            panelSuperior.BackColor = Color.FromArgb(20, 20, 20);
            lblTitulo = new Label();
            lblTitulo.Text = "🏭 INVENTARIO - STOCK CONTROL";
            lblTitulo.ForeColor = Color.FromArgb(0, 174, 239);
            lblTitulo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);
            lblUsuario = new Label();
            lblUsuario.Text = "👤 " + CRUD_Stock_Control.Clases.SesionActual.Usuario;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblUsuario.AutoSize = true;
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.Location = new Point(panelSuperior.Width - 150, 10); 

            Button btnCerrar = new Button();
            btnCerrar.Text = "X";
            btnCerrar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.FromArgb(30, 30, 30);
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.Location = new Point(panelSuperior.Width - 45, 0);
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Visible = true;
            btnCerrar.Enabled = true;

            btnCerrar.MouseEnter += (s, e) =>
            {
                btnCerrar.BackColor = Color.Red;
                btnCerrar.ForeColor = Color.Black;
            };

            btnCerrar.MouseLeave += (s, e) =>
            {
                btnCerrar.BackColor = Color.FromArgb(30, 30, 30);
                btnCerrar.ForeColor = Color.White;
            };

            btnCerrar.Click += (s, e) => { this.Close(); };

            panelSuperior.MouseDown += panelSuperior_MouseDown;
            lblTitulo.MouseDown += panelSuperior_MouseDown;
            lblUsuario.MouseDown += panelSuperior_MouseDown;

            panelSuperior.Resize += (s, e) =>
            {
                btnCerrar.Location = new Point(panelSuperior.Width - 45, 0);
                lblUsuario.Location = new Point(panelSuperior.Width - 150, 10); 
            };
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Controls.Add(lblUsuario);
            panelSuperior.Controls.Add(btnCerrar);
            this.Controls.Add(panelSuperior);
            panelSuperior.BringToFront();
        }


       
        private void StyleNeonButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 239);
            btn.BackColor = Color.FromArgb(20, 20, 20);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(0, 174, 239);
                btn.ForeColor = Color.Black;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(20, 20, 20);
                btn.ForeColor = Color.White;
            };
        }

        
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();
        private void button2_Click(object sender, EventArgs e) => AbrirFormularioEnPanel(new Proveedor());
        private void button3_Click(object sender, EventArgs e) => AbrirFormularioEnPanel(new Producto());
        private void button4_Click(object sender, EventArgs e) => AbrirFormularioEnPanel(new Stock());
        private void button5_Click(object sender, EventArgs e) => AbrirFormularioEnPanel(new Proveedores());
        private void button6_Click(object sender, EventArgs e) => AbrirFormularioEnPanel(new btnSalidas());
        private void button7_Click(object sender, EventArgs e)
        {
            using (Cuenta frm = new Cuenta())
            {
                frm.ShowDialog(this);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}
