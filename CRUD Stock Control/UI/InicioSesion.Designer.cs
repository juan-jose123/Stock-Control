namespace CRUD_Stock_Control
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            panel1 = new Panel();
            button1 = new Button();
            btnIniciarSesion = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            cbMostrar = new CheckBox();
            label4 = new Label();
            btnRegistrame = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(330, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 25);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = Color.Silver;
            btnIniciarSesion.Image = (Image)resources.GetObject("btnIniciarSesion.Image");
            btnIniciarSesion.Location = new Point(50, 318);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(115, 39);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 254);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 188);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(149, 185);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(149, 254);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(158, 23);
            txtContraseña.TabIndex = 5;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 80);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(149, 86);
            label3.Name = "label3";
            label3.Size = new Size(225, 33);
            label3.TabIndex = 7;
            label3.Text = "Stock Control";
            label3.Click += label3_Click;
            // 
            // cbMostrar
            // 
            cbMostrar.AutoSize = true;
            cbMostrar.Location = new Point(313, 256);
            cbMostrar.Name = "cbMostrar";
            cbMostrar.Size = new Size(67, 19);
            cbMostrar.TabIndex = 8;
            cbMostrar.Text = "Mostrar";
            cbMostrar.UseVisualStyleBackColor = true;
            cbMostrar.CheckedChanged += cbMostrar_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 299);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 9;
            label4.Text = "¿No estas registrado?";
            // 
            // btnRegistrame
            // 
            btnRegistrame.FlatStyle = FlatStyle.Flat;
            btnRegistrame.ForeColor = Color.LightGray;
            btnRegistrame.Image = (Image)resources.GetObject("btnRegistrame.Image");
            btnRegistrame.Location = new Point(218, 318);
            btnRegistrame.Name = "btnRegistrame";
            btnRegistrame.Size = new Size(128, 40);
            btnRegistrame.TabIndex = 10;
            btnRegistrame.UseVisualStyleBackColor = true;
            btnRegistrame.Click += btnRegistrame_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(394, 378);
            Controls.Add(btnRegistrame);
            Controls.Add(label4);
            Controls.Add(cbMostrar);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioSesion";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnIniciarSesion;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private Label label3;
        private CheckBox cbMostrar;
        private Label label4;
        private Button btnRegistrame;
    }
}
