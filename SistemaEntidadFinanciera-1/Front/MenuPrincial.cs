using System;
using Back;
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

        private void MenuPrincial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreIngresado = textBox1.Text;
            string apellidoIngresado = textBox2.Text;
            Cliente? apellidoEncontrado = context.Clientes.FirstOrDefault(c => c.Apellido == apellidoIngresado);
            Cliente? nombreEncontrado = context.Clientes.FirstOrDefault(c => c.Nombre == nombreIngresado);

            if (nombreIngresado == nombreEncontrado.Nombre)
            {

                if (apellidoIngresado == apellidoEncontrado.Apellido)
                {
                    MenuCuentaBancaria catalogo = new MenuCuentaBancaria();
                    catalogo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos, intente nuevamente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAltaCuentaBancaria CrearCliente = new MenuAltaCuentaBancaria();
            CrearCliente.Show();
            this.Hide();
        }
    }
}
