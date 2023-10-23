namespace TestingTDP
{
    partial class Admin
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
            panel1 = new Panel();
            button5 = new Button();
            button1 = new Button();
            Pancho = new Panel();
            Pancho1 = new Panel();
            Bts = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            BtInventario = new Button();
            pictureBox1 = new PictureBox();
            Pancho2 = new Panel();
            DtC = new Button();
            Borrar = new Button();
            Reintegrar = new Button();
            Busqueda2 = new TextBox();
            dataGridView2 = new DataGridView();
            DtE = new Button();
            Modificar = new Button();
            Eliminar = new Button();
            Agg = new Button();
            button7 = new Button();
            button6 = new Button();
            Busqueda = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            Pancho.SuspendLayout();
            Pancho1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Pancho2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 100);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseDownBackColor = Color.Red;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(981, 17);
            button5.Name = "button5";
            button5.Size = new Size(23, 23);
            button5.TabIndex = 1;
            button5.Text = "X";
            button5.TextAlign = ContentAlignment.BottomRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1897, 3);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pancho
            // 
            Pancho.BackColor = SystemColors.ActiveCaption;
            Pancho.Controls.Add(Pancho1);
            Pancho.Controls.Add(pictureBox1);
            Pancho.Location = new Point(-4, 92);
            Pancho.Name = "Pancho";
            Pancho.Size = new Size(1016, 521);
            Pancho.TabIndex = 1;
            // 
            // Pancho1
            // 
            Pancho1.BackColor = Color.SteelBlue;
            Pancho1.Controls.Add(Bts);
            Pancho1.Controls.Add(button4);
            Pancho1.Controls.Add(button3);
            Pancho1.Controls.Add(button2);
            Pancho1.Controls.Add(BtInventario);
            Pancho1.Location = new Point(0, 0);
            Pancho1.Name = "Pancho1";
            Pancho1.Size = new Size(208, 521);
            Pancho1.TabIndex = 1;
            // 
            // Bts
            // 
            Bts.Location = new Point(208, 173);
            Bts.Name = "Bts";
            Bts.Size = new Size(188, 199);
            Bts.TabIndex = 6;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(21, 228);
            button4.Name = "button4";
            button4.Size = new Size(165, 41);
            button4.TabIndex = 3;
            button4.Text = "Facturacion";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(18, 162);
            button3.Name = "button3";
            button3.Size = new Size(165, 41);
            button3.TabIndex = 2;
            button3.Text = "Distribuidores";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(18, 100);
            button2.Name = "button2";
            button2.Size = new Size(165, 41);
            button2.TabIndex = 1;
            button2.Text = "Materia Prima";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtInventario
            // 
            BtInventario.FlatStyle = FlatStyle.Popup;
            BtInventario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtInventario.ForeColor = Color.MintCream;
            BtInventario.Location = new Point(18, 35);
            BtInventario.Name = "BtInventario";
            BtInventario.Size = new Size(165, 41);
            BtInventario.TabIndex = 0;
            BtInventario.Text = "Inventario";
            BtInventario.UseVisualStyleBackColor = true;
            BtInventario.Click += BtInventario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox1.Image = Properties.Resources.logo_of_bakery_loaf_of_bread_kitchen_utensils_rolling_pin_vector_removebg_preview;
            pictureBox1.Location = new Point(334, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 473);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Pancho2
            // 
            Pancho2.BackColor = SystemColors.ActiveCaption;
            Pancho2.Controls.Add(DtC);
            Pancho2.Controls.Add(Borrar);
            Pancho2.Controls.Add(Reintegrar);
            Pancho2.Controls.Add(Busqueda2);
            Pancho2.Controls.Add(dataGridView2);
            Pancho2.Controls.Add(DtE);
            Pancho2.Controls.Add(Modificar);
            Pancho2.Controls.Add(Eliminar);
            Pancho2.Controls.Add(Agg);
            Pancho2.Controls.Add(button7);
            Pancho2.Controls.Add(button6);
            Pancho2.Controls.Add(Busqueda);
            Pancho2.Controls.Add(dataGridView1);
            Pancho2.Location = new Point(204, 93);
            Pancho2.Name = "Pancho2";
            Pancho2.Size = new Size(808, 521);
            Pancho2.TabIndex = 2;
            // 
            // DtC
            // 
            DtC.FlatStyle = FlatStyle.Popup;
            DtC.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtC.ForeColor = Color.MintCream;
            DtC.Location = new Point(690, 124);
            DtC.Name = "DtC";
            DtC.Size = new Size(115, 42);
            DtC.TabIndex = 14;
            DtC.Text = "Datos Comunes";
            DtC.UseVisualStyleBackColor = true;
            DtC.Click += DtC_Click;
            // 
            // Borrar
            // 
            Borrar.FlatStyle = FlatStyle.Popup;
            Borrar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Borrar.ForeColor = Color.MintCream;
            Borrar.Location = new Point(27, 124);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(115, 42);
            Borrar.TabIndex = 13;
            Borrar.Text = "Eliminar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Reintegrar
            // 
            Reintegrar.FlatStyle = FlatStyle.Popup;
            Reintegrar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Reintegrar.ForeColor = Color.MintCream;
            Reintegrar.Location = new Point(27, 64);
            Reintegrar.Name = "Reintegrar";
            Reintegrar.Size = new Size(115, 42);
            Reintegrar.TabIndex = 12;
            Reintegrar.Text = "Reintegrar";
            Reintegrar.UseVisualStyleBackColor = true;
            Reintegrar.Click += Reintegrar_Click;
            // 
            // Busqueda2
            // 
            Busqueda2.BackColor = SystemColors.MenuBar;
            Busqueda2.BorderStyle = BorderStyle.FixedSingle;
            Busqueda2.Location = new Point(203, 21);
            Busqueda2.Name = "Busqueda2";
            Busqueda2.Size = new Size(423, 23);
            Busqueda2.TabIndex = 11;
            Busqueda2.TextChanged += Busqueda2_TextChanged;
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
            dataGridView2.Location = new Point(209, 55);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(478, 417);
            dataGridView2.StandardTab = true;
            dataGridView2.TabIndex = 10;
            dataGridView2.UseWaitCursor = true;
            dataGridView2.CellClick += dataGridView1_CellContentClick;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DtE
            // 
            DtE.FlatStyle = FlatStyle.Popup;
            DtE.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtE.ForeColor = Color.MintCream;
            DtE.Location = new Point(690, 64);
            DtE.Name = "DtE";
            DtE.Size = new Size(115, 42);
            DtE.TabIndex = 9;
            DtE.Text = "Datos Eliminados";
            DtE.UseVisualStyleBackColor = true;
            DtE.Click += DtE_Click;
            // 
            // Modificar
            // 
            Modificar.FlatStyle = FlatStyle.Popup;
            Modificar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Modificar.ForeColor = Color.MintCream;
            Modificar.Location = new Point(27, 258);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(115, 42);
            Modificar.TabIndex = 8;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // Eliminar
            // 
            Eliminar.FlatStyle = FlatStyle.Popup;
            Eliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminar.ForeColor = Color.MintCream;
            Eliminar.Location = new Point(27, 392);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(115, 42);
            Eliminar.TabIndex = 7;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // Agg
            // 
            Agg.FlatStyle = FlatStyle.Popup;
            Agg.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Agg.ForeColor = Color.MintCream;
            Agg.Location = new Point(27, 190);
            Agg.Name = "Agg";
            Agg.Size = new Size(115, 42);
            Agg.TabIndex = 6;
            Agg.Text = "Agregar Stock";
            Agg.UseVisualStyleBackColor = true;
            Agg.Click += Agg_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.MintCream;
            button7.Location = new Point(27, 64);
            button7.Name = "button7";
            button7.Size = new Size(115, 42);
            button7.TabIndex = 5;
            button7.Text = "Actualizar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.MintCream;
            button6.Location = new Point(27, 124);
            button6.Name = "button6";
            button6.Size = new Size(115, 42);
            button6.TabIndex = 4;
            button6.Text = "Agregar Producto";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Busqueda
            // 
            Busqueda.BackColor = SystemColors.MenuBar;
            Busqueda.BorderStyle = BorderStyle.FixedSingle;
            Busqueda.Location = new Point(203, 21);
            Busqueda.Name = "Busqueda";
            Busqueda.Size = new Size(423, 23);
            Busqueda.TabIndex = 1;
            Busqueda.TextChanged += Busqueda_TextChanged;
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
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.ImeMode = ImeMode.Off;
            dataGridView1.Location = new Point(209, 55);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(478, 417);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 0;
            dataGridView1.UseWaitCursor = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Admin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1012, 614);
            ControlBox = false;
            Controls.Add(Pancho);
            Controls.Add(panel1);
            Controls.Add(Pancho2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Admin";
            Text = "Panel admin";
            panel1.ResumeLayout(false);
            Pancho.ResumeLayout(false);
            Pancho1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Pancho2.ResumeLayout(false);
            Pancho2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel Pancho;
        private Panel Pancho1;
        private Button BtInventario;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel Pancho2;
        private TextBox Busqueda;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel Bts;
        private Button Eliminar;
        private Button Agg;
        private Button Modificar;
        private Button DtE;
        internal DataGridView dataGridView2;
        private TextBox Busqueda2;
        private Button Reintegrar;
        private Button Borrar;
        private Button DtC;
        public DataGridView dataGridView1;
    }
}