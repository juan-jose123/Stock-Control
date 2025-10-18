namespace CRUD_Stock_Control.UI
{
    partial class Inventario
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            panelContenedor = new Panel();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(119, 123);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 1;
            button2.Text = "Proovedor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(481, 124);
            button3.Name = "button3";
            button3.Size = new Size(220, 50);
            button3.TabIndex = 2;
            button3.Text = "Producto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1200, 124);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 3;
            button4.Text = "Inventario";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 255, 255);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(839, 123);
            button5.Name = "button5";
            button5.Size = new Size(220, 50);
            button5.TabIndex = 4;
            button5.Text = "Proovedores";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 255, 255);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(1560, 124);
            button6.Name = "button6";
            button6.Size = new Size(220, 50);
            button6.TabIndex = 5;
            button6.Text = "Salidas";
            button6.UseMnemonic = false;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 255, 255);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe Print", 14.25F);
            button7.Location = new Point(1800, 42);
            button7.Name = "button7";
            button7.Size = new Size(104, 47);
            button7.TabIndex = 6;
            button7.Text = "Cuenta";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(781, 30);
            label1.Name = "label1";
            label1.Size = new Size(439, 86);
            label1.TabIndex = 7;
            label1.Text = "Stock Control";
            label1.Click += label1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(1, 179);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1903, 863);
            panelContenedor.TabIndex = 8;
            panelContenedor.Paint += panel2_Paint;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button7);
            Controls.Add(panelContenedor);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 600);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Panel panelContenedor;
    }
}