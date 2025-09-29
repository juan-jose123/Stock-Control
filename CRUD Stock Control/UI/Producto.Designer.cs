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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            btnGuardar = new Button();
            button1 = new Button();
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
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(161, 485);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 34);
            btnGuardar.TabIndex = 27;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(14, 485);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 289);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 23;
            label4.Text = "Codigo del proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 201);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 22;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 113);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 21;
            label2.Text = "Codigo del producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 21);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombre del producto";
            // 
            // txtCodigoproveedor
            // 
            txtCodigoproveedor.Location = new Point(16, 325);
            txtCodigoproveedor.Margin = new Padding(3, 4, 3, 4);
            txtCodigoproveedor.Name = "txtCodigoproveedor";
            txtCodigoproveedor.Size = new Size(259, 27);
            txtCodigoproveedor.TabIndex = 17;
            // 
            // txtCodigoproducto
            // 
            txtCodigoproducto.Location = new Point(16, 151);
            txtCodigoproducto.Margin = new Padding(3, 4, 3, 4);
            txtCodigoproducto.Name = "txtCodigoproducto";
            txtCodigoproducto.Size = new Size(259, 27);
            txtCodigoproducto.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(16, 241);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(259, 27);
            txtCantidad.TabIndex = 15;
            // 
            // txtNombreproducto
            // 
            txtNombreproducto.Location = new Point(16, 65);
            txtNombreproducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreproducto.Name = "txtNombreproducto";
            txtNombreproducto.Size = new Size(259, 27);
            txtNombreproducto.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 372);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 29;
            label5.Text = "Precio";
            label5.Click += label5_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(16, 408);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(259, 27);
            txtPrecio.TabIndex = 28;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 567);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigoproveedor);
            Controls.Add(txtCodigoproducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreproducto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button button1;
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
    }
}