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
            btnCerrarSesion = new Button();
            btnVer = new FontAwesome.Sharp.IconButton();
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
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(192, 255, 255);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(351, 190);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(130, 38);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += txtCerrarSesion_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(192, 255, 255);
            btnVer.FlatStyle = FlatStyle.Popup;
            btnVer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVer.IconColor = Color.Black;
            btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVer.IconSize = 35;
            btnVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnVer.Location = new Point(27, 189);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(70, 36);
            btnVer.TabIndex = 2;
            btnVer.Text = "ver";
            btnVer.TextAlign = ContentAlignment.MiddleRight;
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += iconButton1_Click;
            // 
            // Cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 275);
            Controls.Add(btnVer);
            Controls.Add(btnCerrarSesion);
            Controls.Add(dgvCuenta);
            Name = "Cuenta";
            Text = "Cuenta";
            Load += Cuenta_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCuenta;
        private Button btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnVer;
    }
}