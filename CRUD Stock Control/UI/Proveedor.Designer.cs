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
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(445, 135);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(420, 40);
            txtNombre.TabIndex = 0;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(445, 493);
            txtCelular.Multiline = true;
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(420, 40);
            txtCelular.TabIndex = 1;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(445, 307);
            txtIdentificacion.Multiline = true;
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(420, 40);
            txtIdentificacion.TabIndex = 2;
            // 
            // txtDistribuye
            // 
            txtDistribuye.Location = new Point(1009, 135);
            txtDistribuye.Multiline = true;
            txtDistribuye.Name = "txtDistribuye";
            txtDistribuye.Size = new Size(420, 40);
            txtDistribuye.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(1009, 307);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(420, 40);
            txtDireccion.TabIndex = 4;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(1009, 493);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(420, 40);
            txtNota.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F);
            label1.Location = new Point(445, 74);
            label1.Name = "label1";
            label1.Size = new Size(129, 47);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 20.25F);
            label2.Location = new Point(445, 243);
            label2.Name = "label2";
            label2.Size = new Size(365, 47);
            label2.TabIndex = 7;
            label2.Text = "Numero de identificacion";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 20.25F);
            label3.Location = new Point(445, 415);
            label3.Name = "label3";
            label3.Size = new Size(115, 47);
            label3.TabIndex = 8;
            label3.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 20.25F);
            label4.Location = new Point(1009, 74);
            label4.Name = "label4";
            label4.Size = new Size(157, 47);
            label4.TabIndex = 9;
            label4.Text = "Distribuye";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 20.25F);
            label5.Location = new Point(1009, 243);
            label5.Name = "label5";
            label5.Size = new Size(146, 47);
            label5.TabIndex = 10;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 20.25F);
            label6.Location = new Point(998, 415);
            label6.Name = "label6";
            label6.Size = new Size(86, 47);
            label6.TabIndex = 11;
            label6.Text = "Nota";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe Script", 15.75F);
            btnGuardar.Location = new Point(880, 699);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(179, 60);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 824);
            Controls.Add(btnGuardar);
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
        private Button btnGuardar;
    }
}