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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(66, 57);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 0;
            // 
            // iDd
            // 
            iDd.Location = new Point(66, 110);
            iDd.Name = "iDd";
            iDd.Size = new Size(100, 23);
            iDd.TabIndex = 1;
            iDd.KeyPress += iDd_KeyPress;
            // 
            // Precio
            // 
            Precio.Location = new Point(66, 263);
            Precio.Name = "Precio";
            Precio.Size = new Size(100, 23);
            Precio.TabIndex = 3;
            Precio.TextChanged += Precio_TextChanged;
            Precio.KeyPress += Precio_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 39);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 5;
            label2.Text = "IdDistribuidor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 245);
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
            groupBox1.Location = new Point(28, 142);
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
            label3.Location = new Point(39, 289);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 14;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(66, 307);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 13;
            Cantidadtxt.KeyPress += Cantidadtxt_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(66, 347);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 389);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Cantidadtxt);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Precio);
            Controls.Add(iDd);
            Controls.Add(Nombretxt);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}