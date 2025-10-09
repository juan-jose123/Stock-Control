namespace CRUD_Stock_Control.UI
{
    partial class Stock
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
            btnBuscar = new Button();
            tablaProductos = new DataGridView();
            btnCargartodo = new Button();
            txtCodigoProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F);
            label1.Location = new Point(169, 78);
            label1.Name = "label1";
            label1.Size = new Size(295, 47);
            label1.TabIndex = 0;
            label1.Text = "Codigo del producto";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(192, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe Script", 15.75F);
            btnBuscar.Location = new Point(169, 659);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(179, 60);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tablaProductos
            // 
            tablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(692, 91);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.Size = new Size(1087, 628);
            tablaProductos.TabIndex = 2;
            // 
            // btnCargartodo
            // 
            btnCargartodo.BackColor = Color.FromArgb(192, 255, 255);
            btnCargartodo.FlatStyle = FlatStyle.Popup;
            btnCargartodo.Font = new Font("Segoe Script", 15.75F);
            btnCargartodo.Location = new Point(434, 659);
            btnCargartodo.Name = "btnCargartodo";
            btnCargartodo.Size = new Size(179, 60);
            btnCargartodo.TabIndex = 3;
            btnCargartodo.Text = "Cargar todo";
            btnCargartodo.UseVisualStyleBackColor = false;
            btnCargartodo.Click += btnCargartodo_Click;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Font = new Font("Segoe Print", 20.25F);
            txtCodigoProducto.Location = new Point(169, 152);
            txtCodigoProducto.Multiline = true;
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(420, 40);
            txtCodigoProducto.TabIndex = 4;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 824);
            Controls.Add(txtCodigoProducto);
            Controls.Add(btnCargartodo);
            Controls.Add(tablaProductos);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "Stock";
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private DataGridView tablaProductos;
        private Button btnCargartodo;
        private TextBox txtCodigoProducto;
    }
}