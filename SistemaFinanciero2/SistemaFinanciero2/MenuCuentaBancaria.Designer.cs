namespace SistemaFinanciero2
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(437, 69);
            button1.Name = "button1";
            button1.Size = new Size(99, 34);
            button1.TabIndex = 0;
            button1.Text = "Ingresar Dinero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(436, 29);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 1;
            button2.Text = "Retirar Dinero";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 3;
            label1.Text = "Numero de Cuenta";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.Location = new Point(3, 81);
            button3.Name = "button3";
            button3.Size = new Size(136, 42);
            button3.TabIndex = 5;
            button3.Text = "Ver informacion de tu cuenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Bienvenido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 123);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 8;
            label3.Text = "Transferir a otra cuenta";
            // 
            // button4
            // 
            button4.Location = new Point(437, 109);
            button4.Name = "button4";
            button4.Size = new Size(99, 43);
            button4.TabIndex = 9;
            button4.Text = "Realizar Transferencia";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 39);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 11;
            label4.Text = "Monto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 10;
            // 
            // MenuCuentaBancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 261);
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

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button4;
        private Label label4;
        private TextBox textBox3;
    }
}