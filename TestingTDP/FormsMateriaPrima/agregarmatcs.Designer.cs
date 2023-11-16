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
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 284);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 25;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 211);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 24;
            label3.Text = "Cantidad :";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(73, 229);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(100, 23);
            Cantidadtxt.TabIndex = 23;
            // 
            // Tipotxt
            // 
            Tipotxt.Location = new Point(79, 171);
            Tipotxt.Name = "Tipotxt";
            Tipotxt.Size = new Size(100, 23);
            Tipotxt.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 20;
            label2.Text = "IdDistribuidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 19;
            label1.Text = "Nombre :";
            // 
            // iDd
            // 
            iDd.Location = new Point(73, 113);
            iDd.Name = "iDd";
            iDd.Size = new Size(100, 23);
            iDd.TabIndex = 17;
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(73, 60);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(100, 23);
            Nombretxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 151);
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
            MateriaPrima.BackgroundColor = SystemColors.Control;
            MateriaPrima.BorderStyle = BorderStyle.None;
            MateriaPrima.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MateriaPrima.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.ColumnHeadersHeight = 35;
            MateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MateriaPrima.EnableHeadersVisualStyles = false;
            MateriaPrima.GridColor = Color.SteelBlue;
            MateriaPrima.ImeMode = ImeMode.Off;
            MateriaPrima.Location = new Point(244, 12);
            MateriaPrima.MultiSelect = false;
            MateriaPrima.Name = "MateriaPrima";
            MateriaPrima.ReadOnly = true;
            MateriaPrima.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MateriaPrima.RowHeadersVisible = false;
            MateriaPrima.RowTemplate.Height = 25;
            MateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MateriaPrima.Size = new Size(94, 329);
            MateriaPrima.StandardTab = true;
            MateriaPrima.TabIndex = 27;
            MateriaPrima.UseWaitCursor = true;
            MateriaPrima.CellContentClick += MateriaPrima_CellContentClick;
            MateriaPrima.MouseClick += MateriaPrima_MouseClick;
            // 
            // agregarmatcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 368);
            Controls.Add(MateriaPrima);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Cantidadtxt);
            Controls.Add(Tipotxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iDd);
            Controls.Add(Nombretxt);
            Name = "agregarmatcs";
            Text = "agregarmatcs";
            ((System.ComponentModel.ISupportInitialize)MateriaPrima).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}