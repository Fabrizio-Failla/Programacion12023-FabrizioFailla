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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Complete el campo monto nuevamente.");
                }
                else
                {
                    int seleccion = dataGridView1.CurrentCellAddress.Y;
                    //int cuentaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    string mensaje = principal.PagarTarjetaCredito((int)dataGridView1[0, seleccion].Value, double.Parse(textBox1.Text));
                    MessageBox.Show(mensaje);
                    ActualizarGridVie();
                    textBox1.Clear();

                }
            }
        }

        private void tarjetaCreditoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CrearTarjetaCredito crear = new CrearTarjetaCredito();
            crear.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int seleccion = dataGridView1.CurrentCellAddress.Y;
                int idTarjeta = (int)dataGridView1[0, seleccion].Value;             
                Back.TarjetaCredito tarjeta = new Back.TarjetaCredito { Id = idTarjeta };
                principal.Eliminartarjetas(tarjeta);
                ActualizarGridVie();
            }
            else
            {
                MessageBox.Show("Selecciona una casilla");
            }
        }
    }
}
