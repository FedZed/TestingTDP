namespace TestingTDP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Pb1 = new PictureBox();
            pictureBox2 = new PictureBox();
            p1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            p1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(189, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(179, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.CornflowerBlue;
            textBox2.ForeColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(179, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 134);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 187);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 441);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 87);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Pb1
            // 
            Pb1.Image = (Image)resources.GetObject("Pb1.Image");
            Pb1.Location = new Point(288, 210);
            Pb1.Name = "Pb1";
            Pb1.Size = new Size(17, 17);
            Pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb1.TabIndex = 7;
            Pb1.TabStop = false;
            Pb1.Click += Pb1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(288, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // p1
            // 
            p1.BackColor = Color.CornflowerBlue;
            p1.Controls.Add(panel2);
            p1.Controls.Add(panel1);
            p1.Controls.Add(pictureBox2);
            p1.Controls.Add(button1);
            p1.Controls.Add(Pb1);
            p1.Controls.Add(textBox1);
            p1.Controls.Add(textBox2);
            p1.Controls.Add(label1);
            p1.Controls.Add(label2);
            p1.Location = new Point(-8, -5);
            p1.Name = "p1";
            p1.Size = new Size(567, 340);
            p1.TabIndex = 9;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightCyan;
            ClientSize = new Size(394, 332);
            Controls.Add(p1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox Pb1;
        private PictureBox pictureBox2;
        private Panel p1;
    }
}