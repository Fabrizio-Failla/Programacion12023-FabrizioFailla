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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front
{
    public partial class TarjetadecreditoClientes : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public TarjetadecreditoClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Complete el campo monto nuevamente.");
            }
            else
            {
                string mensaje = principal.GenerarResumenTarjeta(textBox1.Text);
                MessageBox.Show(mensaje);


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Complete el campo monto nuevamente.");
            }
            else
            {

                string mensaje = principal.PagarTarjetaCredito(textBox1.Text, double.Parse(textBox2.Text));
                MessageBox.Show(mensaje);
                textBox2.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCuentaBancaria menu = new MenuCuentaBancaria();
            menu.Show();
            this.Hide();
        }
    }
}
