namespace CRUD_Stock_Control.UI
{
    partial class FormAdmin
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
            btnIniciosdesesion = new Button();
            btnSalidas = new Button();
            btnUsuarios = new Button();
            btnProducto = new Button();
            btnProveedores = new Button();
            dgvAdm = new DataGridView();
            btnEliminar = new Button();
            btnGuardarcambios = new Button();
            btnCerrarsesion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdm).BeginInit();
            SuspendLayout();
            // 
            // btnIniciosdesesion
            // 
            btnIniciosdesesion.BackColor = Color.FromArgb(192, 255, 255);
            btnIniciosdesesion.FlatStyle = FlatStyle.Popup;
            btnIniciosdesesion.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciosdesesion.Location = new Point(1548, 71);
            btnIniciosdesesion.Name = "btnIniciosdesesion";
            btnIniciosdesesion.Size = new Size(220, 50);
            btnIniciosdesesion.TabIndex = 10;
            btnIniciosdesesion.Text = "Inicios de sesion";
            btnIniciosdesesion.UseMnemonic = false;
            btnIniciosdesesion.UseVisualStyleBackColor = false;
            btnIniciosdesesion.Click += btnIniciosdesesion_Click_1;
            // 
            // btnSalidas
            // 
            btnSalidas.BackColor = Color.FromArgb(192, 255, 255);
            btnSalidas.FlatStyle = FlatStyle.Popup;
            btnSalidas.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalidas.Location = new Point(820, 71);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(220, 50);
            btnSalidas.TabIndex = 9;
            btnSalidas.Text = "salidas";
            btnSalidas.UseVisualStyleBackColor = false;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(192, 255, 255);
            btnUsuarios.FlatStyle = FlatStyle.Popup;
            btnUsuarios.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(1188, 71);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(220, 50);
            btnUsuarios.TabIndex = 8;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(192, 255, 255);
            btnProducto.FlatStyle = FlatStyle.Popup;
            btnProducto.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducto.Location = new Point(469, 71);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(220, 50);
            btnProducto.TabIndex = 7;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += button3_Click_1;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(192, 255, 255);
            btnProveedores.FlatStyle = FlatStyle.Popup;
            btnProveedores.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedores.Location = new Point(107, 71);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(220, 50);
            btnProveedores.TabIndex = 6;
            btnProveedores.Text = "Proovedores";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click_1;
            // 
            // dgvAdm
            // 
            dgvAdm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdm.Location = new Point(107, 152);
            dgvAdm.Name = "dgvAdm";
            dgvAdm.Size = new Size(1661, 644);
            dgvAdm.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 255, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe Print", 14.25F);
            btnEliminar.Location = new Point(636, 902);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(220, 50);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnGuardarcambios
            // 
            btnGuardarcambios.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardarcambios.FlatStyle = FlatStyle.Popup;
            btnGuardarcambios.Font = new Font("Segoe Print", 14.25F);
            btnGuardarcambios.Location = new Point(862, 902);
            btnGuardarcambios.Name = "btnGuardarcambios";
            btnGuardarcambios.Size = new Size(220, 50);
            btnGuardarcambios.TabIndex = 14;
            btnGuardarcambios.Text = "Guardar cambios";
            btnGuardarcambios.UseVisualStyleBackColor = false;
            btnGuardarcambios.Click += btnGuardarcambios_Click_1;
            // 
            // btnCerrarsesion
            // 
            btnCerrarsesion.BackColor = Color.FromArgb(192, 255, 255);
            btnCerrarsesion.FlatStyle = FlatStyle.Popup;
            btnCerrarsesion.Font = new Font("Segoe Print", 14.25F);
            btnCerrarsesion.Location = new Point(1088, 902);
            btnCerrarsesion.Name = "btnCerrarsesion";
            btnCerrarsesion.Size = new Size(220, 50);
            btnCerrarsesion.TabIndex = 13;
            btnCerrarsesion.Text = "Cerrar sesion";
            btnCerrarsesion.UseVisualStyleBackColor = false;
            btnCerrarsesion.Click += btnModificar_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1888, 1002);
            Controls.Add(btnGuardarcambios);
            Controls.Add(btnCerrarsesion);
            Controls.Add(btnEliminar);
            Controls.Add(dgvAdm);
            Controls.Add(btnIniciosdesesion);
            Controls.Add(btnSalidas);
            Controls.Add(btnUsuarios);
            Controls.Add(btnProducto);
            Controls.Add(btnProveedores);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciosdesesion;
        private Button btnSalidas;
        private Button btnUsuarios;
        private Button btnProducto;
        private Button btnProveedores;
        private DataGridView dgvAdm;
        private Button btnEliminar;
        private Button btnGuardarcambios;
        private Button btnCerrarsesion;
    }
}