using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class MenuCuentaBancaria : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public MenuCuentaBancaria()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Complete el campo monto nuevamente.");
            }
            else
            {
                string mensaje = principal.GenerarResumenCuenta(textBox1.Text);
                MessageBox.Show(mensaje);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese la cuenta nuevamente.");
            }
            else
            {
                string mensaje = principal.RealizarExtraccion(textBox1.Text, double.Parse(textBox3.Text));
                MessageBox.Show(mensaje);
                textBox3.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese la cuenta nuevamente.");
            }
            else
            {
                string mensaje = principal.RealizarDeposito(textBox1.Text, double.Parse(textBox3.Text));
                MessageBox.Show(mensaje);
                textBox3.Clear();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese la cuenta nuevamente.");
            }
            else
            {
                string mensaje = principal.RealizarTransferencia(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text));
                MessageBox.Show(mensaje);
                textBox3.Clear();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox4.Text ==null)
            {
                MessageBox.Show("Ingrese Numero de tarjeta.");

            }
            else
            {
                string mensaje = principal.GenerarResumenCuenta(textBox4.Text);
                MessageBox.Show(mensaje);
                textBox4.Clear();
            }

        }
    }
}
