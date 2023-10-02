using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class MenuCuenta_Bancaria : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        private void ActualizarGridVie()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaCuentaBancaria();
        }
        public MenuCuenta_Bancaria()
        {
            InitializeComponent();
        }

        private void MenuCuenta_Bancaria_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Complete el campo monto nuevamente.");
            }
            else
            {
                int cuentaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                principal.RealizarDeposito(cuentaId, double.Parse(textBox1.Text));
                ActualizarGridVie();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Complete el campo monto nuevamente.");
            }
            else
            {
                int cuentaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                principal.RealizarExtraccion(cuentaId, double.Parse(textBox2.Text));
                ActualizarGridVie();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Complete el campo monto nuevamente.");
            }
            else
            {
                int cuentaOrigenId = Convert.ToInt32(textBox3.Text);
                int cuentaDestinoId = Convert.ToInt32(textBox4.Text);
                double monto = double.Parse(textBox5.Text);

                principal.RealizarTransferencia(cuentaOrigenId, cuentaDestinoId, monto);
                ActualizarGridVie();
            }
        }
    }
}
