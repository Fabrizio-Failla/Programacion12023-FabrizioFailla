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
    public partial class TarjetadeCredito : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        private void ActualizarGridVie()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaTarjetaCredito();
        }
        public TarjetadeCredito()
        {
            InitializeComponent();
        }

        private void TarjetadeCredito_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = principal.DevolverListaTarjetaCredito();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int seleccion = dataGridView1.CurrentCellAddress.Y;
                principal.ActivarTarjetaCredito((int)dataGridView1[0, seleccion].Value);
                ActualizarGridVie();
            }
            else
            { MessageBox.Show("seleccionar una casilla"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int seleccion = dataGridView1.CurrentCellAddress.Y;
                principal.BloquearTarjetaCredito((int)dataGridView1[0, seleccion].Value);
                ActualizarGridVie();
            }
            else
            { MessageBox.Show("seleccionar una casilla"); }
        }
    }
}
