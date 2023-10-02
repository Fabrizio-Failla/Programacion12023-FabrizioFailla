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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(166, 92);
            button2.Name = "button2";
            button2.Size = new Size(139, 40);
            button2.TabIndex = 38;
            button2.Text = "Crear Cuentas ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 92);
            button1.Name = "button1";
            button1.Size = new Size(126, 40);
            button1.TabIndex = 37;
            button1.Text = "Administrar Cuenta Corrientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 39;
            // 
            // button3
            // 
            button3.Location = new Point(331, 92);
            button3.Name = "button3";
            button3.Size = new Size(126, 40);
            button3.TabIndex = 40;
            button3.Text = "Administrar Tarjetas de Credito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MenuPrincial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 219);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincial";
            Text = "MenuPrincial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
    }
}