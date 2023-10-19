namespace Front
{
    partial class MenuAltaCuentaBancaria
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
            textBox5 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(236, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(124, 23);
            textBox5.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 217);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 34;
            label7.Text = "Saldo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 33;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 188);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 32;
            label5.Text = "Que tipo de cuenta";
            // 
            // button2
            // 
            button2.Location = new Point(511, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 31;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(236, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 94);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 27;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 61);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 26;
            label3.Text = "Crear Cuenta";
            // 
            // button1
            // 
            button1.Location = new Point(248, 243);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 25;
            button1.Text = "Crea tu Cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 157);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 24;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 127);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 23;
            label1.Text = "Apellido";
            // 
            // MenuAltaCuentaBancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 332);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuAltaCuentaBancaria";
            Text = "MenuAltaCuentaBancaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Label label7;
        private ComboBox comboBox1;
        private Label label5;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}