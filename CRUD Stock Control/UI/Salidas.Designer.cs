namespace CRUD_Stock_Control.UI
{
    partial class btnSalidas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCodigoProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtCantidadSalida = new TextBox();
            txtMotivo = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtResponsable = new TextBox();
            btnGuardar = new Button();
            btnTabla = new Button();
            FechaSalida = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F);
            label1.Location = new Point(453, 57);
            label1.Name = "label1";
            label1.Size = new Size(263, 47);
            label1.TabIndex = 0;
            label1.Text = "Fecha de la salida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 20.25F);
            label2.Location = new Point(453, 157);
            label2.Name = "label2";
            label2.Size = new Size(295, 47);
            label2.TabIndex = 1;
            label2.Text = "Código del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 20.25F);
            label3.Location = new Point(453, 308);
            label3.Name = "label3";
            label3.Size = new Size(313, 47);
            label3.TabIndex = 2;
            label3.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 20.25F);
            label4.Location = new Point(453, 489);
            label4.Name = "label4";
            label4.Size = new Size(234, 47);
            label4.TabIndex = 3;
            label4.Text = "Cantidad salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 20.25F);
            label5.Location = new Point(1013, 308);
            label5.Name = "label5";
            label5.Size = new Size(223, 47);
            label5.TabIndex = 4;
            label5.Text = "Precio unitario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 20.25F);
            label6.Location = new Point(1013, 157);
            label6.Name = "label6";
            label6.Size = new Size(112, 47);
            label6.TabIndex = 5;
            label6.Text = "Motivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 20.25F);
            label7.Location = new Point(1013, 502);
            label7.Name = "label7";
            label7.Size = new Size(180, 47);
            label7.TabIndex = 6;
            label7.Text = "Responsable";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Font = new Font("Segoe UI", 15.75F);
            txtCodigoProducto.Location = new Point(453, 230);
            txtCodigoProducto.Multiline = true;
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(420, 40);
            txtCodigoProducto.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 15.75F);
            txtNombreProducto.Location = new Point(453, 404);
            txtNombreProducto.Multiline = true;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(420, 40);
            txtNombreProducto.TabIndex = 10;
            // 
            // txtCantidadSalida
            // 
            txtCantidadSalida.Font = new Font("Segoe UI", 15.75F);
            txtCantidadSalida.Location = new Point(453, 575);
            txtCantidadSalida.Multiline = true;
            txtCantidadSalida.Name = "txtCantidadSalida";
            txtCantidadSalida.Size = new Size(420, 40);
            txtCantidadSalida.TabIndex = 11;
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 15.75F);
            txtMotivo.Location = new Point(1013, 230);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(420, 40);
            txtMotivo.TabIndex = 12;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 15.75F);
            txtPrecioUnitario.Location = new Point(1013, 404);
            txtPrecioUnitario.Multiline = true;
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(420, 40);
            txtPrecioUnitario.TabIndex = 13;
            txtPrecioUnitario.TextChanged += textBox6_TextChanged;
            // 
            // txtResponsable
            // 
            txtResponsable.Font = new Font("Segoe UI", 15.75F);
            txtResponsable.Location = new Point(1013, 575);
            txtResponsable.Multiline = true;
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(420, 40);
            txtResponsable.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe Script", 15.75F);
            btnGuardar.Location = new Point(694, 676);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(179, 60);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnTabla
            // 
            btnTabla.BackColor = Color.FromArgb(192, 255, 255);
            btnTabla.FlatStyle = FlatStyle.Popup;
            btnTabla.Font = new Font("Segoe Script", 15.75F);
            btnTabla.Location = new Point(1014, 676);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(179, 60);
            btnTabla.TabIndex = 17;
            btnTabla.Text = "Salidas";
            btnTabla.UseVisualStyleBackColor = false;
            btnTabla.Click += btnTabla_Click;
            // 
            // FechaSalida
            // 
            FechaSalida.CustomFormat = "yyyy-MM-dd";
            FechaSalida.Font = new Font("Segoe Print", 20.25F);
            FechaSalida.Format = DateTimePickerFormat.Custom;
            FechaSalida.Location = new Point(737, 57);
            FechaSalida.Name = "FechaSalida";
            FechaSalida.Size = new Size(281, 55);
            FechaSalida.TabIndex = 18;
            // 
            // btnSalidas
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1887, 824);
            Controls.Add(FechaSalida);
            Controls.Add(btnTabla);
            Controls.Add(btnGuardar);
            Controls.Add(txtResponsable);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtMotivo);
            Controls.Add(txtCantidadSalida);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btnSalidas";
            Text = "Salidas";
            Load += btnSalidas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCodigoProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCantidadSalida;
        private TextBox txtMotivo;
        private TextBox txtPrecioUnitario;
        private TextBox txtResponsable;
        private Button btnGuardar;
        private Button btnTabla;
        private DateTimePicker FechaSalida;
    }
}