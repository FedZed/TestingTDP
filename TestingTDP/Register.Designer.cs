namespace TestingTDP
{
    partial class Register
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
            button1 = new Button();
            Corre = new TextBox();
            Codi = new TextBox();
            Ncontraseña = new TextBox();
            Cotra2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            p1 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(235, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Solicitar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Corre
            // 
            Corre.Location = new Point(62, 149);
            Corre.Name = "Corre";
            Corre.Size = new Size(149, 23);
            Corre.TabIndex = 1;
            // 
            // Codi
            // 
            Codi.Location = new Point(63, 200);
            Codi.Name = "Codi";
            Codi.Size = new Size(149, 23);
            Codi.TabIndex = 2;
            // 
            // Ncontraseña
            // 
            Ncontraseña.Location = new Point(65, 305);
            Ncontraseña.Name = "Ncontraseña";
            Ncontraseña.Size = new Size(149, 23);
            Ncontraseña.TabIndex = 3;
            // 
            // Cotra2
            // 
            Cotra2.Location = new Point(67, 253);
            Cotra2.Name = "Cotra2";
            Cotra2.Size = new Size(149, 23);
            Cotra2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(98, 360);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cambiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(44, 131);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(47, 182);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(44, 235);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Cotraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(47, 285);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 9;
            label4.Text = "Repetir Cotraseña:";
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(label1);
            p1.Controls.Add(label2);
            p1.Controls.Add(label3);
            p1.Controls.Add(Corre);
            p1.Controls.Add(Codi);
            p1.Controls.Add(button2);
            p1.Controls.Add(Ncontraseña);
            p1.Controls.Add(label4);
            p1.Controls.Add(Cotra2);
            p1.Controls.Add(panel1);
            p1.Controls.Add(button1);
            p1.Controls.Add(button3);
            p1.Location = new Point(-4, -15);
            p1.Name = "p1";
            p1.Size = new Size(339, 434);
            p1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 97);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox1.Image = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox1.Location = new Point(3, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(9, 85);
            button3.Name = "button3";
            button3.Size = new Size(26, 23);
            button3.TabIndex = 10;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 417);
            ControlBox = false;
            Controls.Add(p1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            Text = "Cambio contraseña";
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox Corre;
        private TextBox Codi;
        private TextBox Ncontraseña;
        private TextBox Cotra2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
    }
}