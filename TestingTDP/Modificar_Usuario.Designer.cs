namespace TestingTDP
{
    partial class Modificar_Usuario
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
            p1 = new Panel();
            groupBox1 = new GroupBox();
            Cargo = new RadioButton();
            Carg = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            Correo = new TextBox();
            Nombre = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            p1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(groupBox1);
            p1.Controls.Add(label1);
            p1.Controls.Add(label2);
            p1.Controls.Add(Correo);
            p1.Controls.Add(Nombre);
            p1.Controls.Add(button2);
            p1.Controls.Add(panel1);
            p1.Controls.Add(button3);
            p1.Location = new Point(-1, -6);
            p1.Name = "p1";
            p1.Size = new Size(339, 433);
            p1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cargo);
            groupBox1.Controls.Add(Carg);
            groupBox1.Location = new Point(48, 238);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 93);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargo";
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Location = new Point(14, 58);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(75, 19);
            Cargo.TabIndex = 1;
            Cargo.TabStop = true;
            Cargo.Text = "Panadero";
            Cargo.UseVisualStyleBackColor = true;
            Cargo.CheckedChanged += Cargo_CheckedChanged;
            // 
            // Carg
            // 
            Carg.AutoSize = true;
            Carg.Location = new Point(14, 33);
            Carg.Name = "Carg";
            Carg.Size = new Size(48, 19);
            Carg.TabIndex = 0;
            Carg.TabStop = true;
            Carg.Text = "Caja";
            Carg.UseVisualStyleBackColor = true;
            Carg.CheckedChanged += Carg_CheckedChanged;
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
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre:";
            // 
            // Correo
            // 
            Correo.Location = new Point(62, 149);
            Correo.Name = "Correo";
            Correo.Size = new Size(149, 23);
            Correo.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(63, 200);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(149, 23);
            Nombre.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(90, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cambiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // Modificar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 405);
            ControlBox = false;
            Controls.Add(p1);
            Name = "Modificar_Usuario";
            Text = "Modificar_Usuario";
            p1.ResumeLayout(false);
            p1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p1;
        private Label label1;
        private Label label2;
        private TextBox Corre;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private GroupBox groupBox1;
        private RadioButton Cargo;
        private RadioButton Carg;
        public TextBox Correo;
        public TextBox Nombre;
    }
}