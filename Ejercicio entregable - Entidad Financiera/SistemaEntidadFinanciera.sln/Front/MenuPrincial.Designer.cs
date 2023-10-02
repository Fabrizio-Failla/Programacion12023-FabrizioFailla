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
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(132, 192);
            button3.Name = "button3";
            button3.Size = new Size(224, 41);
            button3.TabIndex = 5;
            button3.Text = "Menu Tarjetas de Credito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(132, 97);
            button2.Name = "button2";
            button2.Size = new Size(224, 73);
            button2.TabIndex = 4;
            button2.Text = "Administrar Cuentas \r\nClientes\r\nCuentas bancarias\r\ntarjetas de credito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(132, 33);
            button1.Name = "button1";
            button1.Size = new Size(224, 41);
            button1.TabIndex = 3;
            button1.Text = "Menu Cuenta Corriente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // MenuPrincial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 245);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincial";
            Text = "MenuPrincial";
            Load += MenuPrincial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
    }
}