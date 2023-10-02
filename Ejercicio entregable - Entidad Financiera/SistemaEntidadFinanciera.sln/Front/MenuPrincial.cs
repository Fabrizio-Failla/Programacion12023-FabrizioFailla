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

            MenuCuenta_Bancaria cuentaBancaria = new MenuCuenta_Bancaria();
            cuentaBancaria.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipalDeAdm crear = new MenuPrincipalDeAdm();
            crear.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuTarjetaCredito crear = new MenuTarjetaCredito();
            crear.Show();
            this.Hide();
        }

        private void MenuPrincial_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MenuPrincipalDeAdm crear = new MenuPrincipalDeAdm();
            crear.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuCuenta_Bancaria cuentaBancaria = new MenuCuenta_Bancaria();
            cuentaBancaria.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MenuTarjetaCredito crear = new MenuTarjetaCredito();
            crear.Show();
            this.Hide();
        }
    }
}
