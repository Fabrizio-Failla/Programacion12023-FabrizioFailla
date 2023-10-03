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
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            button5 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(596, 194);
            dataGridView1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(658, 50);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 22;
            button2.Text = "Pausar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(359, 238);
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
            label4.Location = new Point(307, 5);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 20;
            label4.Text = "Menu Tarjeta de Credito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 17);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 18;
            label2.Text = "Seleccionar tarjeta \r\nque desees pausar";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 250);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 238);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 24;
            label3.Text = "Seleccionar Tarjeta que \r\nquieras ver su resumen";
            // 
            // button3
            // 
            button3.Location = new Point(3, 264);
            button3.Name = "button3";
            button3.Size = new Size(63, 23);
            button3.TabIndex = 25;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(655, 142);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 27;
            button4.Text = "Activar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 109);
            label5.Name = "label5";
            label5.Size = new Size(109, 30);
            label5.TabIndex = 26;
            label5.Text = "Seleccionar tarjeta \r\nque deseees activar";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button5
            // 
            button5.Location = new Point(658, 226);
            button5.Name = "button5";
            button5.Size = new Size(94, 39);
            button5.TabIndex = 29;
            button5.Text = "Bloquear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(655, 193);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 28;
            label6.Text = "Seleccionar tarjeta \r\nque deseees activar";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 289);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private Label label5;
        private Button button5;
        private Label label6;
    }
}