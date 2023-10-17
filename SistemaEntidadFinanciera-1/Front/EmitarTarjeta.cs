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
    public partial class EmitarTarjeta : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        private void ActualizarGridVie()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaTarjetaCredito();
        }
        public EmitarTarjeta()
        {
            InitializeComponent();
            comboBox1.Items.Add("Activa");
            comboBox1.Items.Add("Pausada");
            comboBox1.Items.Add("Bloqueada");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string numerodecuenta = textBox1.Text;
            CuentaBancaria? cuentaEncontrada = context.CuentaBancarias.FirstOrDefault(c => c.NumeroCuenta == numerodecuenta);


            if (cuentaEncontrada == null)
            {
                MessageBox.Show("No se ha encontrado el número de cuenta en la base de datos del banco.");
            }
            else
            {
                if (comboBox1.SelectedItem != null)
                {
                    TarjetaCredito nuevatarjeta = new TarjetaCredito();
                    nuevatarjeta.Estado = comboBox1.SelectedItem.ToString();
                    nuevatarjeta.Propietario = cuentaEncontrada;
                    nuevatarjeta.LimiteCredito = double.Parse(textBox2.Text);
                    nuevatarjeta.MontoDeuda = double.Parse(textBox3.Text);
                    nuevatarjeta.SaldoDisponible = double.Parse(textBox4.Text);
                    nuevatarjeta.NumeroTarjeta = principal.GenerarNumeroTarjeta();
                    principal.EmitirTarjetaCredito(nuevatarjeta);
                    ActualizarGridVie();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un estado.");
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = comboBox1.SelectedItem.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
