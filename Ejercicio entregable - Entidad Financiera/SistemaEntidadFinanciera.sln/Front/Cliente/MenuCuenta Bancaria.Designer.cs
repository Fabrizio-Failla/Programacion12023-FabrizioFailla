namespace Front
{
    partial class MenuCuenta_Bancaria
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 120);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Realizar un deposito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 116);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Realizar un Retiro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 150);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 154);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Monto";
            // 
            // button1
            // 
            button1.Location = new Point(103, 180);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 6;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(359, 176);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 7;
            button2.Text = "Retirar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(610, 179);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 11;
            button3.Text = "Transferir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 153);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(593, 116);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 9;
            label6.Text = "Realizar una transferencia";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(584, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 46);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 13;
            label7.Text = "Numero de Cuenta";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 43);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(102, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(312, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 64);
            listBox1.TabIndex = 33;
            // 
            // MenuCuenta_Bancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 253);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MenuCuenta_Bancaria";
            Text = "MenuCuenta_Bancaria";
            Load += MenuCuenta_Bancaria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private ListBox listBox1;
    }
}