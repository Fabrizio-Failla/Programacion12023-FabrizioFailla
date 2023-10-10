using Solucion;
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

namespace SistemaFinanciero2
{
    public partial class MenuPrincipal : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaClientes CrearCliente = new AltaClientes();
            CrearCliente.Show();
            this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
