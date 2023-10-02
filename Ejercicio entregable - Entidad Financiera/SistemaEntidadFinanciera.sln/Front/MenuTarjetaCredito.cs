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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int cuentaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                principal.PausarTarjetaCredito(cuentaId);
                ActualizarGridVie();
            }
            else
            { MessageBox.Show("Seleccione una cuenta."); }


        }

        private void MenuTarjetaCredito_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.DevolverListaTarjetaCredito();
        }
    }
}
