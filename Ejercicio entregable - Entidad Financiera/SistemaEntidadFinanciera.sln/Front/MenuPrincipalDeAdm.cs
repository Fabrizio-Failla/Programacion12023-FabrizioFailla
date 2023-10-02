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
    public partial class MenuPrincipalDeAdm : Form
    {
        public MenuPrincipalDeAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuCliente crear = new menuCliente();
            crear.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearCuentasBancarias crear = new CrearCuentasBancarias();
            crear.Show();
            this.Hide();
        }
    }
}
