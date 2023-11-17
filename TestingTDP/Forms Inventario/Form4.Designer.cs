namespace TestingTDP
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            Nombretxt = new TextBox();
            iDd = new TextBox();
            Precio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            Tipotxt = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            Cantidadtxt = new TextBox();
            button1 = new Button();
            p1 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            groupBox1.SuspendLayout();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(81, 119);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 0;
            // 
            // iDd
            // 
            iDd.Location = new Point(81, 172);
            iDd.Name = "iDd";
            iDd.Size = new Size(100, 23);
            iDd.TabIndex = 1;
            iDd.TextChanged += iDd_TextChanged;
            iDd.KeyPress += iDd_KeyPress;
            // 
            // Precio
            // 
            Precio.Location = new Point(81, 325);
            Precio.Name = "Precio";
            Precio.Size = new Size(100, 23);
            Precio.TabIndex = 3;
            Precio.TextChanged += Precio_TextChanged;
            Precio.KeyPress += Precio_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 101);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 154);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 5;
            label2.Text = "IdDistribuidor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 307);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio :";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Tipotxt
            // 
            Tipotxt.Location = new Point(89, 71);
            Tipotxt.Name = "Tipotxt";
            Tipotxt.Size = new Size(100, 23);
            Tipotxt.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(Tipotxt);
            groupBox1.Location = new Point(43, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(5, 75);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 19);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Otro :";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(5, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bebible";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(5, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Comestible";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 351);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 14;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(81, 369);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 13;
            Cantidadtxt.TextChanged += Cantidadtxt_TextChanged;
            Cantidadtxt.KeyPress += Cantidadtxt_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(81, 409);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 15;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(panel1);
            p1.Controls.Add(button4);
            p1.Controls.Add(label1);
            p1.Controls.Add(button1);
            p1.Controls.Add(Nombretxt);
            p1.Controls.Add(label3);
            p1.Controls.Add(iDd);
            p1.Controls.Add(Cantidadtxt);
            p1.Controls.Add(Precio);
            p1.Controls.Add(groupBox1);
            p1.Controls.Add(label2);
            p1.Controls.Add(label4);
            p1.Location = new Point(0, -4);
            p1.Name = "p1";
            p1.Size = new Size(314, 476);
            p1.TabIndex = 29;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 448);
            ControlBox = false;
            Controls.Add(p1);
            Name = "Form4";
            Text = "Nuevo Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Nombretxt;
        private TextBox iDd;
        private TextBox Precio;
        private Label label1;
        private Label label2;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox Tipotxt;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox Cantidadtxt;
        private Button button1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}