namespace Front
{
    partial class MenuTarjetaCredito
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(573, 194);
            dataGridView1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(641, 62);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 22;
            button2.Text = "Pausar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(641, 175);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 21;
            button1.Text = "Generar resumen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 9);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 20;
            label4.Text = "Menu Tarjeta de Credito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 29);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 18;
            label2.Text = "Seleccionar tarjeta \r\nque desees pausar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 251);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(621, 142);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 24;
            label3.Text = "Seleccionar Tarjeta que \r\nquieras ver su resumen";
            // 
            // MenuTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuTarjetaCredito";
            Text = "MenuTarjetaCredito";
            Load += MenuTarjetaCredito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}