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
            label8 = new Label();
            Lvl = new Label();
            label6 = new Label();
            label5 = new Label();
            Cantidaduti = new TextBox();
            textNombre = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).BeginInit();
            Pancho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            MateriaPrima.BackgroundColor = SystemColors.Control;
            MateriaPrima.BorderStyle = BorderStyle.None;
            MateriaPrima.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MateriaPrima.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.ColumnHeadersHeight = 35;
            MateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MateriaPrima.EnableHeadersVisualStyles = false;
            MateriaPrima.GridColor = Color.SteelBlue;
            MateriaPrima.ImeMode = ImeMode.Off;
            MateriaPrima.Location = new Point(172, 48);
            MateriaPrima.MultiSelect = false;
            MateriaPrima.Name = "MateriaPrima";
            MateriaPrima.ReadOnly = true;
            MateriaPrima.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.RowHeadersVisible = false;
            MateriaPrima.RowTemplate.Height = 25;
            MateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MateriaPrima.Size = new Size(171, 329);
            MateriaPrima.StandardTab = true;
            MateriaPrima.TabIndex = 37;
            MateriaPrima.UseWaitCursor = true;
            MateriaPrima.MouseClick += MateriaPrima_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(66, 337);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 35;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 189);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 34;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(66, 207);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 33;
            Cantidadtxt.KeyPress += Cantidadtxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 73);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre :";
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(66, 91);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 29;
            // 
            // Preciotxt
            // 
            Preciotxt.Location = new Point(66, 147);
            Preciotxt.Name = "Preciotxt";
            Preciotxt.Size = new Size(100, 23);
            Preciotxt.TabIndex = 28;
            Preciotxt.TextChanged += Preciotxt_TextChanged;
            Preciotxt.KeyPress += Preciotxt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 129);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 36;
            label4.Text = "Precio:";
            // 
            // Cant
            // 
            Cant.Location = new Point(66, 262);
            Cant.Name = "Cant";
            Cant.Size = new Size(100, 23);
            Cant.TabIndex = 30;
            Cant.TextChanged += Cant_TextChanged;
            Cant.KeyPress += Cant_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 244);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 32;
            label2.Text = "Materia primas utilizadas:";
            // 
            // Pancho
            // 
            Pancho.Controls.Add(label8);
            Pancho.Controls.Add(Lvl);
            Pancho.Controls.Add(label6);
            Pancho.Controls.Add(label5);
            Pancho.Controls.Add(Cantidaduti);
            Pancho.Controls.Add(textNombre);
            Pancho.Controls.Add(dataGridView1);
            Pancho.Controls.Add(button2);
            Pancho.Location = new Point(1, -2);
            Pancho.Name = "Pancho";
            Pancho.Size = new Size(390, 451);
            Pancho.TabIndex = 38;
            Pancho.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 181);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 44;
            label8.Text = "Cantidad utilizada";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 128);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 41;
            label5.Text = "Nombre";
            // 
            // Cantidaduti
            // 
            Cantidaduti.Location = new Point(37, 199);
            Cantidaduti.Name = "Cantidaduti";
            Cantidaduti.Size = new Size(100, 23);
            Cantidaduti.TabIndex = 40;
            Cantidaduti.KeyPress += textBox2_KeyPress;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(37, 147);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.ImeMode = ImeMode.Off;
            dataGridView1.Location = new Point(174, 46);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(203, 338);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 38;
            dataGridView1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(53, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Mat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(Pancho);
            Controls.Add(MateriaPrima);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Cantidadtxt);
            Controls.Add(Preciotxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cant);
            Controls.Add(Nombretxt);
            Name = "Mat";
            Text = "Mat";
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).EndInit();
            Pancho.ResumeLayout(false);
            Pancho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        internal DataGridView dataGridView1;
        private Button button2;
        private Label label8;
        private Label Lvl;
        private Label label6;
        private Label label5;
        private TextBox Cantidaduti;
        private TextBox textNombre;
    }
}