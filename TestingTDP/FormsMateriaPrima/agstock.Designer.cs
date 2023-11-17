namespace TestingTDP
{
    partial class agstock
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
            button1 = new Button();
            txtCant = new TextBox();
            comboBox1 = new ComboBox();
            p1 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 228);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 16;
            label2.Text = "Cantidad:";
            // 
            // button1
            // 
            button1.Location = new Point(106, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 14;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(41, 246);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(222, 23);
            txtCant.TabIndex = 13;
            txtCant.TextChanged += txtCant_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 23);
            comboBox1.TabIndex = 18;
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(label1);
            p1.Controls.Add(panel1);
            p1.Controls.Add(comboBox1);
            p1.Controls.Add(label2);
            p1.Controls.Add(button4);
            p1.Controls.Add(button1);
            p1.Controls.Add(txtCant);
            p1.Location = new Point(0, -6);
            p1.Name = "p1";
            p1.Size = new Size(314, 476);
            p1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 19;
            label1.Text = "Materia Prima:";
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
            pictureBox1.Location = new Point(3, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(3, 81);
            button4.Name = "button4";
            button4.Size = new Size(26, 23);
            button4.TabIndex = 10;
            button4.Text = "←";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // agstock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 456);
            ControlBox = false;
            Controls.Add(p1);
            Name = "agstock";
            Text = "Agregar Stock Materia Prima";
            Load += agstock_Load;
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button button1;
        private TextBox txtCant;
        private ComboBox comboBox1;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
        private Label label1;
    }
}