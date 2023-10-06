namespace Front
{
    partial class MenuPrincial
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(118, 153);
            button3.Name = "button3";
            button3.Size = new Size(224, 41);
            button3.TabIndex = 5;
            button3.Text = "Transacción Tarjetas de Credito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(118, 59);
            button2.Name = "button2";
            button2.Size = new Size(224, 41);
            button2.TabIndex = 4;
            button2.Text = "Aministrar Cuentas Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(118, 106);
            button1.Name = "button1";
            button1.Size = new Size(224, 41);
            button1.TabIndex = 3;
            button1.Text = "Transacción de Cuenta Bancaria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 18);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido a la administracion del Banco ";
            label1.Click += label1_Click;
            // 
            // MenuPrincial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 230);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincial";
            Text = "MenuPrincial";
            Load += MenuPrincial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}