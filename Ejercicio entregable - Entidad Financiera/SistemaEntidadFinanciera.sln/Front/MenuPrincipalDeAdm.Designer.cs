﻿namespace Front
{
    partial class MenuPrincipalDeAdm
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
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(63, 55);
            button1.Name = "button1";
            button1.Size = new Size(224, 41);
            button1.TabIndex = 0;
            button1.Text = "Administrar Cuentas de Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(63, 115);
            button2.Name = "button2";
            button2.Size = new Size(224, 41);
            button2.TabIndex = 1;
            button2.Text = "Administrar Cuentas Bancarias";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(63, 174);
            button3.Name = "button3";
            button3.Size = new Size(224, 41);
            button3.TabIndex = 2;
            button3.Text = "Administrar Tarjetas de Credito";
            button3.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalDeAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 246);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincipalDeAdm";
            Text = "MenuPrincipalDeAdm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}