namespace Front
{
    partial class TarjetadeCredito
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
            button5 = new Button();
            button4 = new Button();
            label5 = new Label();
            button2 = new Button();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(630, 202);
            dataGridView1.TabIndex = 44;
            // 
            // button5
            // 
            button5.Location = new Point(773, 130);
            button5.Name = "button5";
            button5.Size = new Size(72, 30);
            button5.TabIndex = 43;
            button5.Text = "Bloquear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(773, 94);
            button4.Name = "button4";
            button4.Size = new Size(72, 30);
            button4.TabIndex = 41;
            button4.Text = "Activar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(711, 130);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 40;
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(773, 58);
            button2.Name = "button2";
            button2.Size = new Size(72, 30);
            button2.TabIndex = 38;
            button2.Text = "Pausar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 4);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 36;
            label4.Text = "Menu Tarjeta de Credito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(663, 87);
            label2.Name = "label2";
            label2.Size = new Size(103, 45);
            label2.TabIndex = 35;
            label2.Text = "Seleccionar tarjeta\r\na la cual quieras \r\ncambiar su estado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(803, 216);
            button1.Name = "button1";
            button1.Size = new Size(72, 30);
            button1.TabIndex = 45;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // TarjetadeCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 258);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "TarjetadeCredito";
            Text = "TarjetadeCredito";
            Load += TarjetadeCredito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Label label5;
        private Button button2;
        private Label label4;
        private Label label2;
        private Button button1;
    }
}