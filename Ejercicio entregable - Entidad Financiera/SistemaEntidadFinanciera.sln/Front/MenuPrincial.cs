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
    public partial class MenuPrincial : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public MenuPrincial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreIngresado = textBox1.Text;
            string apellidoIngresado = textBox2.Text;
            int DniIngresado = int.Parse(textBox3.Text);

            Cliente clienteEncontrado = context.Clientes.FirstOrDefault(c =>
                c.Nombre == nombreIngresado &&
                c.Apellido == apellidoIngresado &&
                c.Dni == DniIngresado);

            if (clienteEncontrado != null)
            {
                MenuCuenta_Bancaria cuentaBancaria = new MenuCuenta_Bancaria();
                cuentaBancaria.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, intente nuevamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipalDeAdm crear = new MenuPrincipalDeAdm();
            crear.Show();
            this.Hide();
        }
    }
}
