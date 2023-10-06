namespace Front
{
    partial class CrearCuentasBancarias
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(153, 140);
            button1.Name = "button1";
            button1.Size = new Size(89, 50);
            button1.TabIndex = 31;
            button1.Text = "Crear Cuenta Bancaria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 21);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 27;
            label5.Text = "Cuenta Bancaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 114);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 55);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 25;
            label3.Text = "Numero de Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 55);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 82);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 81);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 36;
            label7.Text = "Saldo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 111);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 37;
            label8.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(21, 243);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 40;
            button5.Text = "Volver";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // CrearCuentasBancarias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 274);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearCuentasBancarias";
            Load += CrearCuentasBancarias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Button button5;
    }
}