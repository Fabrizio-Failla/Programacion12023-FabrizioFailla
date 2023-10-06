namespace Front
{
    partial class CrearTarjetaCredito
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
            button5 = new Button();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(46, 254);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 41;
            button5.Text = "Volver";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 104);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 53;
            label8.Text = "Saldo disponible";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 74);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 52;
            label7.Text = "Limite de Credito";
            // 
            // button1
            // 
            button1.Location = new Point(150, 188);
            button1.Name = "button1";
            button1.Size = new Size(122, 43);
            button1.TabIndex = 49;
            button1.Text = "Crear Tarjeta de Credito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 12);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 46;
            label5.Text = "Tarjeta de Credito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 104);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 45);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 44;
            label3.Text = "Numero de Tarjeta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 45);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 72);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 133);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 56;
            label6.Text = "Estado";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 57;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 58;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(84, 162);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 59;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(150, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 23);
            textBox4.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 159);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 61;
            label9.Text = "Monto deuda";
            label9.Click += label9_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(84, 159);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 60;
            // 
            // CrearTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 286);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label6);
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
            Controls.Add(button5);
            Name = "CrearTarjetaCredito";
            Text = "CrearTarjetaCredito";
            Load += CrearTarjetaCredito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label8;
        private Label label7;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label10;
        private TextBox textBox4;
        private Label label9;
        private Label label11;
    }
}