namespace Front
{
    partial class TarjetadecreditoClientes
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
            label8 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            button6 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 160);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 37;
            label8.Text = "Monto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 139);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 36;
            label7.Text = "Pago de deuda";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 35;
            // 
            // button6
            // 
            button6.Location = new Point(324, 186);
            button6.Name = "button6";
            button6.Size = new Size(74, 28);
            button6.TabIndex = 34;
            button6.Text = "Pagar ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(70, 143);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 38;
            button1.Text = "Generar resumen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 59);
            label1.Name = "label1";
            label1.Size = new Size(302, 15);
            label1.TabIndex = 40;
            label1.Text = "Escriba su numero de tarjeta para poder realizar tramites";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 14);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 41;
            label2.Text = "Menu de tarjeta de credito";
            // 
            // button2
            // 
            button2.Location = new Point(375, 315);
            button2.Name = "button2";
            button2.Size = new Size(74, 28);
            button2.TabIndex = 42;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TarjetadecreditoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 355);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Name = "TarjetadecreditoClientes";
            Text = "TarjetadecreditoClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private TextBox textBox1;
        private Button button6;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}