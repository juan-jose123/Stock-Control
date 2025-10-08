namespace CRUD_Stock_Control.UI
{
    partial class Proveedores
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
            label2 = new Label();
            label1 = new Label();
            txtCodigoProveedor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            dgvproveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvproveedores).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 20.25F);
            label2.Location = new Point(389, 179);
            label2.Name = "label2";
            label2.Size = new Size(169, 47);
            label2.TabIndex = 11;
            label2.Text = "Suministra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F);
            label1.Location = new Point(389, 43);
            label1.Name = "label1";
            label1.Size = new Size(260, 47);
            label1.TabIndex = 10;
            label1.Text = "Codigo Proveedor";
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Font = new Font("Segoe UI", 15.75F);
            txtCodigoProveedor.Location = new Point(399, 107);
            txtCodigoProveedor.Multiline = true;
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(420, 40);
            txtCodigoProveedor.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(389, 756);
            button1.Name = "button1";
            button1.Size = new Size(113, 35);
            button1.TabIndex = 12;
            button1.Text = "Tabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(673, 756);
            button2.Name = "button2";
            button2.Size = new Size(117, 35);
            button2.TabIndex = 13;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(399, 226);
            label3.Name = "label3";
            label3.Size = new Size(0, 44);
            label3.TabIndex = 14;
            label3.Click += label3_Click;
            // 
            // dgvproveedores
            // 
            dgvproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproveedores.Location = new Point(930, 12);
            dgvproveedores.Name = "dgvproveedores";
            dgvproveedores.RowHeadersWidth = 51;
            dgvproveedores.Size = new Size(686, 785);
            dgvproveedores.TabIndex = 15;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 824);
            Controls.Add(dgvproveedores);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigoProveedor);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvproveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtCodigoProveedor;
        private Button button1;
        private Button button2;
        private Label label3;
        private DataGridView dgvproveedores;
    }
}