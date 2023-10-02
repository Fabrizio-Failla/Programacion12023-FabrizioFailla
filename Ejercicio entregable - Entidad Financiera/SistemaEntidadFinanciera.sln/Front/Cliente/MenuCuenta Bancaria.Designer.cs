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
            dataGridView1 = new DataGridView();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            button4 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(640, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(640, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(644, 27);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Realizar un deposito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(657, 135);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Realizar un Retiro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 155);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 49);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Monto";
            // 
            // button1
            // 
            button1.Location = new Point(661, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 6;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(657, 181);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 7;
            button2.Text = "Retirar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(147, 346);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 11;
            button3.Text = "Transferir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 320);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Monto";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 238);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 9;
            label6.Text = "Realizar una transferencia";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(573, 204);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 290);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 16;
            label7.Text = "Cuenta Destino(ID)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 286);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 23);
            textBox4.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 260);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 17;
            label8.Text = "Cuenta Origen(ID)";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(116, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 23);
            textBox5.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new Point(686, 347);
            button4.Name = "button4";
            button4.Size = new Size(86, 38);
            button4.TabIndex = 19;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 9);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 20;
            label9.Text = "Cuenta Bancaria";
            // 
            // MenuCuenta_Bancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 397);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Button button4;
        private Label label9;
    }
}