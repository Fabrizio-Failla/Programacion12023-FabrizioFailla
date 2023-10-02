using Back;
using Microsoft.Data.SqlClient;
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
    public partial class MenuTarjetaCredito : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        private void ActualizarGridVie()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaTarjetaCredito();
        }

        public MenuTarjetaCredito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int seleccion = dataGridView1.CurrentCellAddress.Y;
                MessageBox.Show(principal.GenerarResumenTarjeta((int)dataGridView1[0, seleccion].Value));
                ActualizarGridVie();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int seleccion = dataGridView1.CurrentCellAddress.Y;
                principal.PausarTarjetaCredito((int)dataGridView1[0, seleccion].Value);
                ActualizarGridVie();
            }
            else
            { MessageBox.Show("seleccionar una casilla"); }



        }

        private void MenuTarjetaCredito_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.DevolverListaTarjetaCredito();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincial crear = new MenuPrincial();
            crear.Show();
            this.Hide();
        }
    }
}
