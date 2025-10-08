namespace CRUD_Stock_Control.UI
{
    partial class Producto
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
            btnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCodigoproveedor = new TextBox();
            txtCodigoproducto = new TextBox();
            txtCantidad = new TextBox();
            txtNombreproducto = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            dataGridView1 = new DataGridView();
            btnListaCodigos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(349, 701);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(179, 60);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 20.25F);
            label4.Location = new Point(1003, 200);
            label4.Name = "label4";
            label4.Size = new Size(309, 47);
            label4.TabIndex = 23;
            label4.Text = "Codigo del proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 20.25F);
            label3.Location = new Point(1003, 46);
            label3.Name = "label3";
            label3.Size = new Size(146, 47);
            label3.TabIndex = 22;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 20.25F);
            label2.Location = new Point(349, 200);
            label2.Name = "label2";
            label2.Size = new Size(295, 47);
            label2.TabIndex = 21;
            label2.Text = "Codigo del producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 46);
            label1.Name = "label1";
            label1.Size = new Size(313, 47);
            label1.TabIndex = 20;
            label1.Text = "Nombre del producto";
            // 
            // txtCodigoproveedor
            // 
            txtCodigoproveedor.Font = new Font("Segoe UI", 15.75F);
            txtCodigoproveedor.Location = new Point(1003, 307);
            txtCodigoproveedor.Multiline = true;
            txtCodigoproveedor.Name = "txtCodigoproveedor";
            txtCodigoproveedor.Size = new Size(420, 40);
            txtCodigoproveedor.TabIndex = 17;
            // 
            // txtCodigoproducto
            // 
            txtCodigoproducto.Font = new Font("Segoe UI", 15.75F);
            txtCodigoproducto.Location = new Point(349, 307);
            txtCodigoproducto.Multiline = true;
            txtCodigoproducto.Name = "txtCodigoproducto";
            txtCodigoproducto.Size = new Size(420, 40);
            txtCodigoproducto.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 15.75F);
            txtCantidad.Location = new Point(1003, 114);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(420, 40);
            txtCantidad.TabIndex = 15;
            // 
            // txtNombreproducto
            // 
            txtNombreproducto.Font = new Font("Segoe UI", 15.75F);
            txtNombreproducto.Location = new Point(349, 114);
            txtNombreproducto.Multiline = true;
            txtNombreproducto.Name = "txtNombreproducto";
            txtNombreproducto.Size = new Size(420, 40);
            txtNombreproducto.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 20.25F);
            label5.Location = new Point(349, 439);
            label5.Name = "label5";
            label5.Size = new Size(104, 47);
            label5.TabIndex = 29;
            label5.Text = "Precio";
            label5.Click += label5_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(349, 514);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(420, 40);
            txtPrecio.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(999, 433);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(424, 240);
            dataGridView1.TabIndex = 30;
            // 
            // btnListaCodigos
            // 
            btnListaCodigos.BackColor = Color.FromArgb(192, 255, 255);
            btnListaCodigos.FlatStyle = FlatStyle.Popup;
            btnListaCodigos.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaCodigos.Location = new Point(558, 701);
            btnListaCodigos.Name = "btnListaCodigos";
            btnListaCodigos.Size = new Size(211, 60);
            btnListaCodigos.TabIndex = 31;
            btnListaCodigos.Text = "Lista de codigos";
            btnListaCodigos.UseVisualStyleBackColor = false;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 824);
            Controls.Add(btnListaCodigos);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigoproveedor);
            Controls.Add(txtCodigoproducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreproducto);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCodigoproveedor;
        private TextBox txtCodigoproducto;
        private TextBox txtCantidad;
        private TextBox txtNombreproducto;
        private Label label5;
        private TextBox txtPrecio;
        private DataGridView dataGridView1;
        private Button btnListaCodigos;
    }
}