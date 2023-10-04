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
    public partial class CrearCuentasBancarias : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public CrearCuentasBancarias()
        {
            InitializeComponent();
            comboBox1.Items.Add("Ahorro");
            comboBox1.Items.Add("Corriente");

        }

        private void CrearCuentasBancarias_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string estadoSeleccionado = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CuentaBancaria cuentabancaria = new CuentaBancaria();
            cuentabancaria.NumeroCuenta = int.Parse(textBox1.Text);
            cuentabancaria.Saldo = double.Parse(textBox2.Text);
            cuentabancaria.Tipo = comboBox1.SelectedItem.ToString();

            principal.CrearCuentaBancaria(cuentabancaria);

            MessageBox.Show("Se a creado la cuenta exitosamente");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCuentaBancaria();
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CuentaBancaria itemSeleccionado = (CuentaBancaria)listBox1.SelectedItem;
            listBox1.DataSource = null;
            principal.EliminarCuentaBancaria(itemSeleccionado);
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCuentaBancaria();
            _ = MessageBox.Show("La cuenta se a eliminado con éxito");
        }

        private void button2_Click(object sender, EventArgs e)
        {


            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuPrincipalDeAdm crear = new MenuPrincipalDeAdm();
            crear.Show();
            this.Hide();
        }
    }
}
