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
            button2 = new Button();
            listBox1 = new ListBox();
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
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(415, 251);
            button2.Name = "button2";
            button2.Size = new Size(84, 28);
            button2.TabIndex = 33;
            button2.Text = "Mostrar clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(267, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 214);
            listBox1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(132, 150);
            button1.Name = "button1";
            button1.Size = new Size(89, 50);
            button1.TabIndex = 31;
            button1.Text = "Crear Cuenta Bancaria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 31);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 27;
            label5.Text = "Cuenta Bancaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 124);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 65);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 25;
            label3.Text = "Numero de Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 65);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 92);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 91);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 36;
            label7.Text = "Saldo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 121);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 37;
            label8.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(283, 251);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 39;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 271);
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
            ClientSize = new Size(679, 297);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(listBox1);
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

        private Button button2;
        private ListBox listBox1;
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
        private Button button3;
        private Button button5;
    }
}