namespace TestingTDP
{
    partial class ModificarMat
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
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            Cantidadtxt = new TextBox();
            Tipotxt = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Precio = new TextBox();
            iDd = new TextBox();
            Nombretxt = new TextBox();
            label5 = new Label();
            p1 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            dataGridView2.Location = new Point(209, 91);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(390, 409);
            dataGridView2.StandardTab = true;
            dataGridView2.TabIndex = 38;
            dataGridView2.UseWaitCursor = true;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(68, 386);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 37;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 308);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 36;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(68, 326);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 35;
            // 
            // Tipotxt
            // 
            Tipotxt.Location = new Point(68, 224);
            Tipotxt.Name = "Tipotxt";
            Tipotxt.Size = new Size(100, 23);
            Tipotxt.TabIndex = 10;
            Tipotxt.TextChanged += Tipotxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 264);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 33;
            label4.Text = "Precio :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 146);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 32;
            label2.Text = "IdDistribuidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 93);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre :";
            // 
            // Precio
            // 
            Precio.Location = new Point(68, 282);
            Precio.Name = "Precio";
            Precio.Size = new Size(100, 23);
            Precio.TabIndex = 30;
            // 
            // iDd
            // 
            iDd.Location = new Point(68, 164);
            iDd.Name = "iDd";
            iDd.Size = new Size(100, 23);
            iDd.TabIndex = 29;
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(68, 111);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 206);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 39;
            label5.Text = "Tipo:";
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(label5);
            p1.Controls.Add(panel1);
            p1.Controls.Add(button1);
            p1.Controls.Add(dataGridView2);
            p1.Controls.Add(label3);
            p1.Controls.Add(button4);
            p1.Controls.Add(Tipotxt);
            p1.Controls.Add(label1);
            p1.Controls.Add(Cantidadtxt);
            p1.Controls.Add(Nombretxt);
            p1.Controls.Add(label4);
            p1.Controls.Add(iDd);
            p1.Controls.Add(label2);
            p1.Controls.Add(Precio);
            p1.Location = new Point(-5, -1);
            p1.Name = "p1";
            p1.Size = new Size(654, 471);
            p1.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 97);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox1.Image = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox1.Location = new Point(17, 15);
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
            button4.Location = new Point(9, 85);
            button4.Name = "button4";
            button4.Size = new Size(26, 23);
            button4.TabIndex = 10;
            button4.Text = "←";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ModificarMat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 442);
            ControlBox = false;
            Controls.Add(p1);
            Name = "ModificarMat";
            Text = "Modificar Materia Prima";
            Load += ModificarMat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dataGridView2;
        public Button button1;
        public Label label3;
        public TextBox Cantidadtxt;
        public TextBox Tipotxt;
        public Label label4;
        public Label label2;
        public Label label1;
        public TextBox Precio;
        public TextBox iDd;
        public TextBox Nombretxt;
        public Label label5;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}