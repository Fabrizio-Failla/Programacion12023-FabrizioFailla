namespace Front
{
    partial class EmitarTarjeta
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
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(99, 23);
            textBox4.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 164);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 53;
            label6.Text = "Saldo Disponible";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(99, 23);
            textBox3.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 193);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 51;
            label5.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 131);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 50;
            label2.Text = "Monto adeudado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 102);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 48;
            label7.Text = "Limite de Credito";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 47;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 254);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 46;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 23);
            textBox2.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 23);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 43;
            label3.Text = "Emitir tarjetas";
            // 
            // button1
            // 
            button1.Location = new Point(111, 219);
            button1.Name = "button1";
            button1.Size = new Size(99, 26);
            button1.TabIndex = 42;
            button1.Text = "Emitir tarjeta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(329, 190);
            button3.Name = "button3";
            button3.Size = new Size(172, 38);
            button3.TabIndex = 56;
            button3.Text = "Aministrar Tarjetas de Credito\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 53);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 57;
            label1.Text = "Seleccionar Cliente al que \r\ndeseas emitirle una tarjeta";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(246, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(349, 169);
            listBox1.TabIndex = 58;
            // 
            // EmitarTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 346);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "EmitarTarjeta";
            Text = "EmitarTarjeta";
            Load += EmitarTarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private Label label2;
        private Label label7;
        private ComboBox comboBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button3;
        private Label label1;
        private ListBox listBox1;
    }
}