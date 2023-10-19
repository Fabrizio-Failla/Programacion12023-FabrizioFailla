namespace Front
{
    partial class InicioSesionAdm
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
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 33);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 19;
            label3.Text = "Iniciar Sesion como administrador";
            // 
            // button1
            // 
            button1.Location = new Point(135, 122);
            button1.Name = "button1";
            button1.Size = new Size(84, 38);
            button1.TabIndex = 18;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 23);
            textBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 64);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 15;
            label2.Text = "Dni";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 96);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 14;
            label1.Text = "Apellido";
            // 
            // button2
            // 
            button2.Location = new Point(233, 228);
            button2.Name = "button2";
            button2.Size = new Size(84, 38);
            button2.TabIndex = 20;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InicioSesionAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 278);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioSesionAdm";
            Text = "InicioSesionAdm";
            Load += InicioSesionAdm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}