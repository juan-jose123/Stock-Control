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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 30);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(765, 3);
            button1.Name = "button1";
            button1.Size = new Size(52, 25);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 140);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(139, 140);
            button3.Name = "button3";
            button3.Size = new Size(133, 46);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(417, 140);
            button4.Name = "button4";
            button4.Size = new Size(133, 46);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(278, 140);
            button5.Name = "button5";
            button5.Size = new Size(133, 46);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(556, 140);
            button6.Name = "button6";
            button6.Size = new Size(133, 46);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(695, 140);
            button7.Name = "button7";
            button7.Size = new Size(133, 46);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 33);
            label1.Name = "label1";
            label1.Size = new Size(439, 86);
            label1.TabIndex = 7;
            label1.Text = "Stock Control";
            label1.Click += label1_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 202);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
    }
}