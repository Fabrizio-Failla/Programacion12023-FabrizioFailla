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

namespace SistemaFinanciero2
{
    public partial class CuentaDeClientes : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public CuentaDeClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void CuentaDeClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
