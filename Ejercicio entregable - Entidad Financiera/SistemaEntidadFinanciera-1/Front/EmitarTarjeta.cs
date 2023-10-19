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
    public partial class EmitarTarjeta : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();

        public EmitarTarjeta()
        {
            InitializeComponent();
            comboBox1.Items.Add("Activa");
            comboBox1.Items.Add("Pausada");
            comboBox1.Items.Add("Bloqueada");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TarjetaCredito nuevatarjeta = new TarjetaCredito();
            Cliente? seleccionado = (Cliente)listBox1.SelectedItem;
            if (listBox1.Select != null)
            {
                if (textBox2.Text == "" ||  textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Falta completar datos.");
                }
                else
                {
                   
                  nuevatarjeta.Propietario = seleccionado;
                  nuevatarjeta.LimiteCredito = double.Parse(textBox2.Text);
                  nuevatarjeta.MontoDeuda = double.Parse(textBox3.Text);
                  nuevatarjeta.Estado = comboBox1.SelectedItem.ToString();
                  nuevatarjeta.SaldoDisponible = double.Parse(textBox4.Text);
                  nuevatarjeta.NumeroTarjeta = principal.GenerarNumeroTarjeta();
                 principal.EmitirTarjetaCredito(nuevatarjeta);
                 MessageBox.Show("Felicidades se creado la tarjeta correctamente.");
                  textBox4.Clear();
                  textBox2.Clear();
                   textBox3.Clear();
                    
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

        private void EmitarTarjeta_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TarjetadeCredito crear = new TarjetadeCredito();
            crear.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MenuPrincial crear = new MenuPrincial();
            crear.Show();
            this.Hide();
        }
    }
}
