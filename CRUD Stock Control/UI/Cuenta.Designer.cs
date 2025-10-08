namespace CRUD_Stock_Control.UI
{
    partial class Cuenta
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
            dgvCuenta = new DataGridView();
            txtCerrarSesion = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Location = new Point(27, 28);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.Size = new Size(454, 126);
            dgvCuenta.TabIndex = 0;
            dgvCuenta.CellContentClick += dgvCuenta_CellContentClick;
            // 
            // txtCerrarSesion
            // 
            txtCerrarSesion.BackColor = Color.FromArgb(0, 192, 192);
            txtCerrarSesion.FlatStyle = FlatStyle.Flat;
            txtCerrarSesion.Location = new Point(351, 190);
            txtCerrarSesion.Name = "txtCerrarSesion";
            txtCerrarSesion.Size = new Size(130, 38);
            txtCerrarSesion.TabIndex = 1;
            txtCerrarSesion.Text = "Cerrar Sesion";
            txtCerrarSesion.UseVisualStyleBackColor = false;
            txtCerrarSesion.Click += txtCerrarSesion_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 192, 192);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(27, 189);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(70, 36);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "ver";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 275);
            Controls.Add(iconButton1);
            Controls.Add(txtCerrarSesion);
            Controls.Add(dgvCuenta);
            Name = "Cuenta";
            Text = "Cuenta";
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCuenta;
        private Button txtCerrarSesion;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}