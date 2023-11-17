namespace TestingTDP
{
    partial class Form6
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            label3 = new Label();
            Cantidadtxt = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Tipotxt = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Precio = new TextBox();
            iDd = new TextBox();
            Nombretxt = new TextBox();
            ll = new Label();
            dataGridView2 = new DataGridView();
            p1 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 430);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 25;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 372);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 24;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(57, 390);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(Tipotxt);
            groupBox1.Location = new Point(19, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 22;
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
            // Tipotxt
            // 
            Tipotxt.Location = new Point(89, 71);
            Tipotxt.Name = "Tipotxt";
            Tipotxt.Size = new Size(100, 23);
            Tipotxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 328);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 21;
            label4.Text = "Precio :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 175);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 20;
            label2.Text = "IdDistribuidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 122);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 19;
            label1.Text = "Nombre :";
            // 
            // Precio
            // 
            Precio.Location = new Point(57, 346);
            Precio.Name = "Precio";
            Precio.Size = new Size(100, 23);
            Precio.TabIndex = 18;
            // 
            // iDd
            // 
            iDd.Location = new Point(57, 193);
            iDd.Name = "iDd";
            iDd.Size = new Size(100, 23);
            iDd.TabIndex = 17;
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(57, 140);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 16;
            Nombretxt.TextChanged += Nombretxt_TextChanged;
            // 
            // ll
            // 
            ll.AutoSize = true;
            ll.Location = new Point(15, 16);
            ll.Name = "ll";
            ll.Size = new Size(13, 15);
            ll.TabIndex = 26;
            ll.Text = "ll";
            ll.Visible = false;
            ll.Click += ll_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.SteelBlue;
            dataGridView2.ImeMode = ImeMode.Off;
            dataGridView2.Location = new Point(225, 88);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(279, 453);
            dataGridView2.StandardTab = true;
            dataGridView2.TabIndex = 27;
            dataGridView2.UseWaitCursor = true;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_2;
            dataGridView2.MouseClick += dataGridView2_MouseClick;
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(panel1);
            p1.Controls.Add(dataGridView2);
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
            p1.Location = new Point(-1, 0);
            p1.Name = "p1";
            p1.Size = new Size(453, 518);
            p1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 97);
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
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 496);
            ControlBox = false;
            Controls.Add(p1);
            Controls.Add(ll);
            Name = "Form6";
            Text = "Modificar Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton1;
        public Button button1;
        public Label label3;
        public TextBox Cantidadtxt;
        public GroupBox groupBox1;
        public Label label4;
        public Label label2;
        public Label label1;
        public TextBox Precio;
        public TextBox iDd;
        public TextBox Nombretxt;
        public RadioButton radioButton3;
        public RadioButton radioButton2;
        public TextBox Tipotxt;
        public Label ll;
        internal DataGridView dataGridView2;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}