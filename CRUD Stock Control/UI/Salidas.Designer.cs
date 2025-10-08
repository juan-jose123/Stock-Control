namespace CRUD_Stock_Control.UI
{
    partial class btnSalidas
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnGuardar = new Button();
            btnTabla = new Button();
            dtpFechaSalida = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F);
            label1.Location = new Point(453, 57);
            label1.Name = "label1";
            label1.Size = new Size(263, 47);
            label1.TabIndex = 0;
            label1.Text = "Fecha de la salida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 20.25F);
            label2.Location = new Point(453, 157);
            label2.Name = "label2";
            label2.Size = new Size(295, 47);
            label2.TabIndex = 1;
            label2.Text = "Código del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 20.25F);
            label3.Location = new Point(453, 308);
            label3.Name = "label3";
            label3.Size = new Size(313, 47);
            label3.TabIndex = 2;
            label3.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 20.25F);
            label4.Location = new Point(453, 489);
            label4.Name = "label4";
            label4.Size = new Size(234, 47);
            label4.TabIndex = 3;
            label4.Text = "Cantidad salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 20.25F);
            label5.Location = new Point(1013, 308);
            label5.Name = "label5";
            label5.Size = new Size(223, 47);
            label5.TabIndex = 4;
            label5.Text = "Precio unitario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 20.25F);
            label6.Location = new Point(1013, 157);
            label6.Name = "label6";
            label6.Size = new Size(112, 47);
            label6.TabIndex = 5;
            label6.Text = "Motivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 20.25F);
            label7.Location = new Point(1013, 502);
            label7.Name = "label7";
            label7.Size = new Size(180, 47);
            label7.TabIndex = 6;
            label7.Text = "Responsable";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F);
            textBox2.Location = new Point(453, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(420, 40);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F);
            textBox3.Location = new Point(453, 404);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(420, 40);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F);
            textBox4.Location = new Point(453, 575);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(420, 40);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 15.75F);
            textBox5.Location = new Point(1013, 230);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(420, 40);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 15.75F);
            textBox6.Location = new Point(1013, 404);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(420, 40);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 15.75F);
            textBox7.Location = new Point(1013, 575);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(420, 40);
            textBox7.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe Script", 15.75F);
            btnGuardar.Location = new Point(694, 676);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(179, 60);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnTabla
            // 
            btnTabla.BackColor = Color.FromArgb(192, 255, 255);
            btnTabla.FlatStyle = FlatStyle.Popup;
            btnTabla.Font = new Font("Segoe Script", 15.75F);
            btnTabla.Location = new Point(1014, 676);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(179, 60);
            btnTabla.TabIndex = 17;
            btnTabla.Text = "Salidas";
            btnTabla.UseVisualStyleBackColor = false;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.CustomFormat = "yyyy-MM-dd";
            dtpFechaSalida.Font = new Font("Segoe Print", 20.25F);
            dtpFechaSalida.Format = DateTimePickerFormat.Custom;
            dtpFechaSalida.Location = new Point(737, 57);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(281, 55);
            dtpFechaSalida.TabIndex = 18;
            // 
            // btnSalidas
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1887, 824);
            Controls.Add(dtpFechaSalida);
            Controls.Add(btnTabla);
            Controls.Add(btnGuardar);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btnSalidas";
            Text = "Salidas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnGuardar;
        private Button btnTabla;
        private DateTimePicker dtpFechaSalida;
    }
}