namespace TestingTDP
{
    partial class Mat
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MateriaPrima = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            Cantidadtxt = new TextBox();
            label1 = new Label();
            Nombretxt = new TextBox();
            Preciotxt = new TextBox();
            label4 = new Label();
            Cant = new TextBox();
            label2 = new Label();
            Pancho = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            label5 = new Label();
            button2 = new Button();
            Cantidaduti = new TextBox();
            MTT = new DataGridView();
            textNombre = new TextBox();
            Lvl = new Label();
            label6 = new Label();
            p1 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).BeginInit();
            Pancho.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MTT).BeginInit();
            p1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            MateriaPrima.Location = new Point(236, 130);
            MateriaPrima.MultiSelect = false;
            MateriaPrima.Name = "MateriaPrima";
            MateriaPrima.ReadOnly = true;
            MateriaPrima.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.RowHeadersVisible = false;
            MateriaPrima.RowTemplate.Height = 25;
            MateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MateriaPrima.Size = new Size(120, 329);
            MateriaPrima.StandardTab = true;
            MateriaPrima.TabIndex = 37;
            MateriaPrima.UseWaitCursor = true;
            MateriaPrima.MouseClick += MateriaPrima_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(71, 419);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 35;
            button1.Text = "Nuevo Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 271);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 34;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(71, 289);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 33;
            Cantidadtxt.KeyPress += Cantidadtxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 155);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre :";
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(71, 173);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 29;
            // 
            // Preciotxt
            // 
            Preciotxt.Location = new Point(71, 229);
            Preciotxt.Name = "Preciotxt";
            Preciotxt.Size = new Size(100, 23);
            Preciotxt.TabIndex = 28;
            Preciotxt.TextChanged += Preciotxt_TextChanged;
            Preciotxt.KeyPress += Preciotxt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 211);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 36;
            label4.Text = "Precio:";
            // 
            // Cant
            // 
            Cant.Location = new Point(71, 344);
            Cant.Name = "Cant";
            Cant.Size = new Size(100, 23);
            Cant.TabIndex = 30;
            Cant.TextChanged += Cant_TextChanged;
            Cant.KeyPress += Cant_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 326);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 32;
            label2.Text = "Materia primas utilizadas:";
            // 
            // Pancho
            // 
            Pancho.Controls.Add(panel2);
            Pancho.Controls.Add(Lvl);
            Pancho.Controls.Add(label6);
            Pancho.Location = new Point(-1, -1);
            Pancho.Name = "Pancho";
            Pancho.Size = new Size(414, 515);
            Pancho.TabIndex = 38;
            Pancho.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Cantidaduti);
            panel2.Controls.Add(MTT);
            panel2.Controls.Add(textNombre);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 518);
            panel2.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-3, 256);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 44;
            label8.Text = "Cantidad utilizada";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(-7, -12);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 97);
            panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox2.Image = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox2.Location = new Point(3, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(3, 81);
            button3.Name = "button3";
            button3.Size = new Size(26, 23);
            button3.TabIndex = 10;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 203);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 41;
            label5.Text = "Nombre";
            // 
            // button2
            // 
            button2.Location = new Point(47, 333);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cantidaduti
            // 
            Cantidaduti.Location = new Point(31, 274);
            Cantidaduti.Name = "Cantidaduti";
            Cantidaduti.Size = new Size(100, 23);
            Cantidaduti.TabIndex = 40;
            Cantidaduti.KeyPress += textBox2_KeyPress;
            // 
            // MTT
            // 
            MTT.AllowUserToAddRows = false;
            MTT.AllowUserToDeleteRows = false;
            MTT.AllowUserToOrderColumns = true;
            MTT.AllowUserToResizeColumns = false;
            MTT.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            MTT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            MTT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MTT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MTT.BackgroundColor = SystemColors.ActiveCaption;
            MTT.BorderStyle = BorderStyle.None;
            MTT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MTT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MTT.ColumnHeadersHeight = 35;
            MTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MTT.EnableHeadersVisualStyles = false;
            MTT.GridColor = Color.SteelBlue;
            MTT.ImeMode = ImeMode.Off;
            MTT.Location = new Point(168, 121);
            MTT.MultiSelect = false;
            MTT.Name = "MTT";
            MTT.ReadOnly = true;
            MTT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MTT.RowHeadersVisible = false;
            MTT.RowTemplate.Height = 25;
            MTT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MTT.Size = new Size(169, 338);
            MTT.StandardTab = true;
            MTT.TabIndex = 38;
            MTT.UseWaitCursor = true;
            MTT.CellClick += dataGridView1_CellClick;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(31, 222);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 39;
            // 
            // Lvl
            // 
            Lvl.AutoSize = true;
            Lvl.Location = new Point(81, 9);
            Lvl.Name = "Lvl";
            Lvl.Size = new Size(0, 15);
            Lvl.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 9);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 42;
            label6.Text = "MateriaPrima";
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Controls.Add(panel1);
            p1.Controls.Add(button4);
            p1.Controls.Add(MateriaPrima);
            p1.Controls.Add(label1);
            p1.Controls.Add(label4);
            p1.Controls.Add(Nombretxt);
            p1.Controls.Add(button1);
            p1.Controls.Add(Cant);
            p1.Controls.Add(label3);
            p1.Controls.Add(label2);
            p1.Controls.Add(Cantidadtxt);
            p1.Controls.Add(Preciotxt);
            p1.Location = new Point(-1, -1);
            p1.Name = "p1";
            p1.Size = new Size(411, 518);
            p1.TabIndex = 39;
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
            // Mat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 505);
            ControlBox = false;
            Controls.Add(Pancho);
            Controls.Add(p1);
            Name = "Mat";
            Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).EndInit();
            Pancho.ResumeLayout(false);
            Pancho.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MTT).EndInit();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView MateriaPrima;
        public Button button1;
        public Label label3;
        public TextBox Cantidadtxt;
        public Label label1;
        public TextBox Nombretxt;
        private TextBox Preciotxt;
        private Label label4;
        public TextBox Cant;
        public Label label2;
        private Panel Pancho;
        internal DataGridView MTT;
        private Button button2;
        private Label label8;
        private Label Lvl;
        private Label label6;
        private Label label5;
        private TextBox Cantidaduti;
        private TextBox textNombre;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button button3;
        private Panel p1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}