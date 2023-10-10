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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front
{
    public partial class menuCliente : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        private void ActualizarGridVie()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaClientes();
        }
        public menuCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Cliente nuevocliente = new Cliente();
            nuevocliente.Nombre = textBox1.Text;
            nuevocliente.Apellido = textBox2.Text;
            nuevocliente.Dni = int.Parse(textBox3.Text);
            principal.AgregarCliente(nuevocliente);
            MessageBox.Show("Se a creado la cuenta exitosamente");
            principal.DevolverListaClientes();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuPrincial menuPrincipal = new MenuPrincial();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void menuCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = principal.DevolverListaClientes();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int seleccion = dataGridView1.CurrentCellAddress.Y;
                int idCliente = (int)dataGridView1[0, seleccion].Value;
                // Ahora, necesitas crear una instancia de CuentaBancaria con el ID
                Back.Cliente cliente = new Back.Cliente { Id = idCliente };
                principal.EliminarCLiente(cliente);
                ActualizarGridVie();
            }
            else
            {
                MessageBox.Show("Selecciona una casilla");
            }
        }
    }

}
