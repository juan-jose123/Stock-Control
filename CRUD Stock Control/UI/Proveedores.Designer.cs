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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
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
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 11;
            label2.Text = "Suministra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 10;
            label1.Text = "Codigo Proveedor";
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Location = new Point(17, 64);
            txtCodigoProveedor.Margin = new Padding(3, 4, 3, 4);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(259, 27);
            txtCodigoProveedor.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 238);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(175, 238);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 34);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 163);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 14;
            label3.Click += label3_Click;
            // 
            // dgvproveedores
            // 
            dgvproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproveedores.Location = new Point(349, 29);
            dgvproveedores.Margin = new Padding(3, 4, 3, 4);
            dgvproveedores.Name = "dgvproveedores";
            dgvproveedores.RowHeadersWidth = 51;
            dgvproveedores.Size = new Size(463, 243);
            dgvproveedores.TabIndex = 15;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 309);
            Controls.Add(dgvproveedores);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigoProveedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Proveedores";
            Text = "Proveedores";
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