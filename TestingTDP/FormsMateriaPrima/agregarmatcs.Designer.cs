namespace TestingTDP
{
    partial class agregarmatcs
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
            Tipotxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            iDd = new TextBox();
            Nombretxt = new TextBox();
            label4 = new Label();
            MateriaPrima = new DataGridView();
            p1 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).BeginInit();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(79, 362);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 25;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 289);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 24;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(72, 307);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 23;
            // 
            // Tipotxt
            // 
            Tipotxt.Location = new Point(78, 249);
            Tipotxt.Name = "Tipotxt";
            Tipotxt.Size = new Size(100, 23);
            Tipotxt.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 173);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 20;
            label2.Text = "IdDistribuidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 120);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 19;
            label1.Text = "Nombre :";
            // 
            // iDd
            // 
            iDd.Location = new Point(72, 191);
            iDd.Name = "iDd";
            iDd.Size = new Size(100, 23);
            iDd.TabIndex = 17;
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(72, 138);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 229);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 26;
            label4.Text = "Tipo:";
            // 
            // MateriaPrima
            // 
            MateriaPrima.AllowUserToAddRows = false;
            MateriaPrima.AllowUserToDeleteRows = false;
            MateriaPrima.AllowUserToOrderColumns = true;
            MateriaPrima.AllowUserToResizeColumns = false;
            MateriaPrima.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            MateriaPrima.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MateriaPrima.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MateriaPrima.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MateriaPrima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MateriaPrima.BackgroundColor = SystemColors.ActiveCaption;
            MateriaPrima.BorderStyle = BorderStyle.None;
            MateriaPrima.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MateriaPrima.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.ColumnHeadersHeight = 35;
            MateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MateriaPrima.EnableHeadersVisualStyles = false;
            MateriaPrima.GridColor = Color.SteelBlue;
            MateriaPrima.ImeMode = ImeMode.Off;
            MateriaPrima.Location = new Point(205, 91);
            MateriaPrima.MultiSelect = false;
            MateriaPrima.Name = "MateriaPrima";
            MateriaPrima.ReadOnly = true;
            MateriaPrima.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.RowHeadersVisible = false;
            MateriaPrima.RowTemplate.Height = 25;
            MateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MateriaPrima.Size = new Size(95, 482);
            MateriaPrima.StandardTab = true;
            MateriaPrima.TabIndex = 27;
            MateriaPrima.UseWaitCursor = true;
            MateriaPrima.CellContentClick += MateriaPrima_CellContentClick;
            MateriaPrima.MouseClick += MateriaPrima_MouseClick;
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(panel1);
            p1.Controls.Add(MateriaPrima);
            p1.Controls.Add(button4);
            p1.Controls.Add(label4);
            p1.Controls.Add(label1);
            p1.Controls.Add(button1);
            p1.Controls.Add(Nombretxt);
            p1.Controls.Add(label3);
            p1.Controls.Add(iDd);
            p1.Controls.Add(Cantidadtxt);
            p1.Controls.Add(label2);
            p1.Controls.Add(Tipotxt);
            p1.Location = new Point(-1, -5);
            p1.Name = "p1";
            p1.Size = new Size(333, 434);
            p1.TabIndex = 28;
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
            // agregarmatcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 424);
            ControlBox = false;
            Controls.Add(p1);
            Name = "agregarmatcs";
            Text = "Agregar Materia Prima";
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).EndInit();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        public Label label3;
        public TextBox Cantidadtxt;
        private TextBox Tipotxt;
        public Label label2;
        public Label label1;
        public TextBox iDd;
        public TextBox Nombretxt;
        private Label label4;
        internal DataGridView MateriaPrima;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}