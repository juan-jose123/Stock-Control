namespace CRUD_Stock_Control.UI
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            txtNombre = new TextBox();
            txtCelular = new TextBox();
            txtIdentificacion = new TextBox();
            txtDistribuye = new TextBox();
            txtDireccion = new TextBox();
            txtNota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(12, 185);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(227, 23);
            txtCelular.TabIndex = 1;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(12, 117);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(227, 23);
            txtIdentificacion.TabIndex = 2;
            // 
            // txtDistribuye
            // 
            txtDistribuye.Location = new Point(12, 248);
            txtDistribuye.Name = "txtDistribuye";
            txtDistribuye.Size = new Size(227, 23);
            txtDistribuye.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 312);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(227, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(12, 381);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(227, 23);
            txtNota.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 89);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 7;
            label2.Text = "Numero de identificacion";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 155);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 221);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Distribuye";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 283);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 352);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 11;
            label6.Text = "Nota";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 424);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(139, 424);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 40);
            btnGuardar.TabIndex = 13;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 476);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNota);
            Controls.Add(txtDireccion);
            Controls.Add(txtDistribuye);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtCelular);
            Controls.Add(txtNombre);
            Name = "Proveedor";
            Text = "Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCelular;
        private TextBox txtIdentificacion;
        private TextBox txtDistribuye;
        private TextBox txtDireccion;
        private TextBox txtNota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button btnGuardar;
    }
}