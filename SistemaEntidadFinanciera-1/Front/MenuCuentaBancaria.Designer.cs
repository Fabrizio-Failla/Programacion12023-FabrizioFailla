namespace Front
{
    partial class MenuCuentaBancaria
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
            label5 = new Label();
            button5 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 219);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 26;
            label5.Text = "Aun no tienes Tarjeta?";
            // 
            // button5
            // 
            button5.Location = new Point(345, 237);
            button5.Name = "button5";
            button5.Size = new Size(100, 34);
            button5.TabIndex = 25;
            button5.Text = "Obtener Tarjeta";
            button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 64);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 24;
            label4.Text = "Monto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 23;
            // 
            // button4
            // 
            button4.Location = new Point(498, 126);
            button4.Name = "button4";
            button4.Size = new Size(99, 43);
            button4.TabIndex = 22;
            button4.Text = "Realizar Transferencia";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 140);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 21;
            label3.Text = "Transferir a otra cuenta";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 11);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 19;
            label2.Text = "Bienvenido";
            // 
            // button3
            // 
            button3.Location = new Point(12, 125);
            button3.Name = "button3";
            button3.Size = new Size(136, 42);
            button3.TabIndex = 18;
            button3.Text = "Ver informacion de tu cuenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 68);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 17;
            label1.Text = "Numero de Cuenta";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(498, 42);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 15;
            button2.Text = "Retirar Dinero";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(498, 82);
            button1.Name = "button1";
            button1.Size = new Size(99, 34);
            button1.TabIndex = 14;
            button1.Text = "Ingresar Dinero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 219);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 28;
            label6.Text = "Ingresar tarjeta";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 27;
            // 
            // button6
            // 
            button6.Location = new Point(179, 269);
            button6.Name = "button6";
            button6.Size = new Size(85, 34);
            button6.TabIndex = 29;
            button6.Text = "Ingresar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // MenuCuentaBancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 315);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuCuentaBancaria";
            Text = "MenuCuentaBancaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button5;
        private Label label4;
        private TextBox textBox3;
        private Button button4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox textBox4;
        private Button button6;
    }
}