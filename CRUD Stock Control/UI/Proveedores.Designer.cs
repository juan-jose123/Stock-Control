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
            txtIdentificacion = new TextBox();
            txtNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 84);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 11;
            label2.Text = "Suministra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 10;
            label1.Text = "Codigo Proveedor";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(15, 112);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(227, 23);
            txtIdentificacion.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(17, 169);
            button1.Name = "button1";
            button1.Size = new Size(93, 40);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(149, 169);
            button2.Name = "button2";
            button2.Size = new Size(93, 40);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 232);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Name = "Proveedores";
            Text = "Proveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private Button button1;
        private Button button2;
    }
}