using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class MenuCuenta_Bancaria : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public MenuCuenta_Bancaria()
        {
            InitializeComponent();
        }

        private void MenuCuenta_Bancaria_Load(object sender, EventArgs e)
        {

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
            int cuentaID = int.Parse(textBox4.Text);
            double monto = double.Parse(textBox1.Text);
            CuentaBancaria cuenta = context.CuentaBancarias.Find(cuentaID);
            if (cuenta != null)
            {
                principal.RealizarDeposito(cuentaID, monto);
                textBox1.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("No se encontró la cuenta");
                textBox1.Clear();
                textBox4.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cuentaID = int.Parse(textBox4.Text);
            double monto = double.Parse(textBox2.Text);
            CuentaBancaria cuenta = context.CuentaBancarias.Find(cuentaID);
            if (cuenta != null)
            {
                string mensaje = principal.RealizarExtraccion(cuentaID, monto);
                MessageBox.Show(mensaje);
                textBox1.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("El monto a retirar es superir al saldo");
                textBox1.Clear();
                textBox4.Clear();
            }

        }
    }
}
