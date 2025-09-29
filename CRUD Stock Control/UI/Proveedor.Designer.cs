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
            txtNombre.Location = new Point(14, 71);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(14, 247);
            txtCelular.Margin = new Padding(3, 4, 3, 4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(259, 27);
            txtCelular.TabIndex = 1;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(14, 156);
            txtIdentificacion.Margin = new Padding(3, 4, 3, 4);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(259, 27);
            txtIdentificacion.TabIndex = 2;
            // 
            // txtDistribuye
            // 
            txtDistribuye.Location = new Point(14, 331);
            txtDistribuye.Margin = new Padding(3, 4, 3, 4);
            txtDistribuye.Name = "txtDistribuye";
            txtDistribuye.Size = new Size(259, 27);
            txtDistribuye.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(14, 416);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(259, 27);
            txtDireccion.TabIndex = 4;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(14, 508);
            txtNota.Margin = new Padding(3, 4, 3, 4);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(259, 27);
            txtNota.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 119);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 7;
            label2.Text = "Numero de identificacion";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 207);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 8;
            label3.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 295);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Distribuye";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 377);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 469);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 11;
            label6.Text = "Nota";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(14, 565);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(159, 565);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 34);
            btnGuardar.TabIndex = 13;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 635);
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
            Margin = new Padding(3, 4, 3, 4);
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