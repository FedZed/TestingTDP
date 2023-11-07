namespace TestingTDP
{
    partial class agstock
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
            label2 = new Label();
            button1 = new Button();
            txtCant = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 26);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 16;
            label2.Text = "Cantidad";
            // 
            // button1
            // 
            button1.Location = new Point(206, 104);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 14;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(330, 44);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(100, 23);
            txtCant.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 23);
            comboBox1.TabIndex = 18;
            // 
            // agstock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 164);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtCant);
            Name = "agstock";
            Text = "agstock";
            Load += agstock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private TextBox txtCant;
        private ComboBox comboBox1;
    }
}