namespace CRUD_Stock_Control
{
    partial class Resgistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resgistro));
            panel1 = new Panel();
            cbMostrar = new CheckBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCodigoEmpleado = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCelular = new TextBox();
            label5 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 40);
            panel1.TabIndex = 0;
            // 
            // cbMostrar
            // 
            cbMostrar.AutoSize = true;
            cbMostrar.Location = new Point(285, 149);
            cbMostrar.Name = "cbMostrar";
            cbMostrar.Size = new Size(67, 19);
            cbMostrar.TabIndex = 13;
            cbMostrar.Text = "Mostrar";
            cbMostrar.UseVisualStyleBackColor = true;
            cbMostrar.CheckedChanged += cbMostrar_CheckedChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(121, 147);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(158, 23);
            txtContraseña.TabIndex = 12;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(121, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 147);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Contraseña";
            // 
            // txtCodigoEmpleado
            // 
            txtCodigoEmpleado.Location = new Point(150, 187);
            txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            txtCodigoEmpleado.Size = new Size(129, 23);
            txtCodigoEmpleado.TabIndex = 17;
            txtCodigoEmpleado.TextChanged += txtCodigoEmpleado_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(121, 113);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 15;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 187);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 14;
            label4.Text = "Codigo del empleado";
            label4.Click += label4_Click;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(121, 227);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(158, 23);
            txtCelular.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 227);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 19;
            label5.Text = "Celular";
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(143, 305);
            button2.Name = "button2";
            button2.Size = new Size(121, 43);
            button2.TabIndex = 21;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 83);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Resgistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 378);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(txtCelular);
            Controls.Add(label5);
            Controls.Add(txtCodigoEmpleado);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cbMostrar);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Resgistro";
            Text = "Resgistro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox cbMostrar;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private TextBox txtCodigoEmpleado;
        private TextBox txtUsuario;
        private Label label3;
        private Label label4;
        private TextBox txtCelular;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox1;
    }
}