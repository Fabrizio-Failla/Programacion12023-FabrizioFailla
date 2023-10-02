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

    public partial class CrearTarjetaCredito : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();

        public CrearTarjetaCredito()
        {
            InitializeComponent();
            comboBox1.Items.Add("Activa");
            comboBox1.Items.Add("Pausada");
            comboBox1.Items.Add("bloqueada");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuPrincipalDeAdm crear = new MenuPrincipalDeAdm();
            crear.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarjetaCredito tarjetaCredito = new TarjetaCredito();
            tarjetaCredito.NumeroTarjeta = int.Parse(textBox1.Text);
            tarjetaCredito.LimiteCredito = double.Parse(textBox2.Text);
            tarjetaCredito.SaldoDisponible = double.Parse(textBox3.Text);
            tarjetaCredito.Estado = comboBox1.SelectedItem.ToString();
            principal.EmitirTarjetaCredito(tarjetaCredito);

            MessageBox.Show("Se a emitido la tarjeta exitosamente");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaTarjetaCredito();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaTarjetaCredito();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TarjetaCredito itemSeleccionado = (TarjetaCredito)listBox1.SelectedItem;
            listBox1.DataSource = null;
            principal.Eliminartarjetas(itemSeleccionado);
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaTarjetaCredito();
            _ = MessageBox.Show("La tarjeta se a eliminado con éxito");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
