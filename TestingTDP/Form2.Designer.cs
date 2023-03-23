namespace TestingTDP
{
    partial class Form2
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
            panel2 = new Panel();
            p3 = new Panel();
            panel1 = new Panel();
            c2 = new Button();
            C1 = new Button();
            p4 = new Panel();
            button5 = new Button();
            button4 = new Button();
            Named = new TextBox();
            button2 = new Button();
            button1 = new Button();
            dt1 = new DataGridView();
            Id_producto = new TextBox();
            Nombre = new TextBox();
            Precio = new TextBox();
            button3 = new Button();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Cantidad = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            p4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(0, -35);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 87);
            panel2.TabIndex = 8;
            // 
            // p3
            // 
            p3.BackColor = Color.AliceBlue;
            p3.Location = new Point(120, 54);
            p3.Name = "p3";
            p3.Size = new Size(769, 451);
            p3.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(c2);
            panel1.Controls.Add(C1);
            panel1.Location = new Point(0, -35);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 543);
            panel1.TabIndex = 7;
            // 
            // c2
            // 
            c2.FlatStyle = FlatStyle.Popup;
            c2.Location = new Point(0, 127);
            c2.Name = "c2";
            c2.Size = new Size(115, 28);
            c2.TabIndex = 1;
            c2.Text = "button1";
            c2.UseVisualStyleBackColor = true;
            c2.Click += c2_Click;
            // 
            // C1
            // 
            C1.FlatStyle = FlatStyle.Popup;
            C1.Location = new Point(0, 93);
            C1.Name = "C1";
            C1.Size = new Size(115, 28);
            C1.TabIndex = 0;
            C1.Text = "button1";
            C1.UseVisualStyleBackColor = true;
            C1.Click += C1_Click;
            // 
            // p4
            // 
            p4.BackColor = Color.Lavender;
            p4.Controls.Add(button5);
            p4.Controls.Add(button4);
            p4.Controls.Add(Named);
            p4.Controls.Add(button2);
            p4.Controls.Add(button1);
            p4.Controls.Add(dt1);
            p4.Location = new Point(120, 52);
            p4.Name = "p4";
            p4.Size = new Size(769, 454);
            p4.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(249, 107);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(168, 107);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Named
            // 
            Named.Location = new Point(62, 107);
            Named.Name = "Named";
            Named.Size = new Size(100, 23);
            Named.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(296, 409);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(77, 409);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dt1
            // 
            dt1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt1.Location = new Point(22, 179);
            dt1.Name = "dt1";
            dt1.RowTemplate.Height = 25;
            dt1.Size = new Size(472, 224);
            dt1.TabIndex = 0;
            dt1.CellContentClick += dt1_CellContentClick;
            // 
            // Id_producto
            // 
            Id_producto.Location = new Point(57, 74);
            Id_producto.Name = "Id_producto";
            Id_producto.Size = new Size(100, 23);
            Id_producto.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(57, 29);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(100, 23);
            Nombre.TabIndex = 3;
            // 
            // Precio
            // 
            Precio.Location = new Point(56, 179);
            Precio.Name = "Precio";
            Precio.Size = new Size(100, 23);
            Precio.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(71, 283);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Cantidad);
            panel3.Controls.Add(Nombre);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(Id_producto);
            panel3.Controls.Add(Precio);
            panel3.ForeColor = SystemColors.ControlLight;
            panel3.Location = new Point(663, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 456);
            panel3.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Location = new Point(39, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 30);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(49, 16);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 19);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "Otro";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Comestible";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(85, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Bebida";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 209);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 161);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 110);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 56);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 10;
            label2.Text = "Id_Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // Cantidad
            // 
            Cantidad.Location = new Point(56, 224);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(100, 23);
            Cantidad.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 17);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 17;
            label6.Text = "                            ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-3, 139);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 18;
            label7.Text = "                            ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 499);
            Controls.Add(panel3);
            Controls.Add(p3);
            Controls.Add(p4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            p4.ResumeLayout(false);
            p4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel p3;
        private Panel panel1;
        private Button c2;
        private Button C1;
        private Panel p4;
        private DataGridView dt1;
        private Button button1;
        private Button button2;
        private TextBox Id_producto;
        private TextBox Nombre;
        private TextBox Precio;
        private Button button3;
        private Panel panel3;
        private TextBox Cantidad;
        private Button button4;
        private TextBox Named;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Button button5;
        private CheckBox checkBox3;
        private Label label7;
        private Label label6;
    }
}