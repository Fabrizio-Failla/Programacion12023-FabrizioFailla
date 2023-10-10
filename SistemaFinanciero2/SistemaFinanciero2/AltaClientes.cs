using Solucion;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaFinanciero2
{
    public partial class AltaClientes : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public AltaClientes()
        {
            InitializeComponent();
            comboBox1.Items.Add("Ahorro");
            comboBox1.Items.Add("Corriente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dniIngresado = int.Parse(textBox3.Text);
            Cliente? clienteExistente = context.Clientes.SingleOrDefault(c => c.Dni == dniIngresado);
            if (clienteExistente != null)
            {
                MessageBox.Show("Ese DNI ya tiene una cuenta bancaria.");

            }
            else
            {
                Cliente nuevocliente = new Cliente();
                nuevocliente.Nombre = textBox1.Text;
                nuevocliente.Apellido = textBox2.Text;
                nuevocliente.Dni = int.Parse(textBox3.Text);
                principal.AgregarCliente(nuevocliente);
                context.SaveChanges();
                CuentaBancaria nuevaCuenta = new CuentaBancaria();
                nuevaCuenta.Tipo = comboBox1.SelectedItem.ToString();
                nuevaCuenta.Saldo = double.Parse(textBox5.Text);
                nuevaCuenta.IdCliente = nuevocliente;
                nuevaCuenta.NumeroCuenta = $"123232{nuevocliente.Dni}";
                principal.CrearCuentaBancaria(nuevaCuenta);
                context.SaveChanges();
                MessageBox.Show($"Felicades {nuevocliente.Nombre} tu numero de cuenta es {nuevaCuenta.NumeroCuenta}.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();

            }    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = comboBox1.SelectedItem.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
