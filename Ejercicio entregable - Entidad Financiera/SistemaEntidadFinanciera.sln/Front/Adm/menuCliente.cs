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
    public partial class menuCliente : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
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
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente itemSeleccionado = (Cliente)listBox1.SelectedItem;
            listBox1.DataSource = null;
            principal.EliminarCLiente(itemSeleccionado);
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
            _ = MessageBox.Show("El cliente se a eliminado con éxito");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuPrincipalDeAdm menuPrincipal = new MenuPrincipalDeAdm();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente itemSeleccionado = (Cliente)listBox1.SelectedItem;
            Cliente nuevoCliente=new Cliente();
            nuevoCliente.Nombre=textBox1.Text;
            nuevoCliente.Apellido=textBox2.Text;
            nuevoCliente.Dni=int.Parse(textBox3.Text);
            principal.ModificarCliente(nuevoCliente);
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
            _ = MessageBox.Show("El cliente se a modificado con éxito");

        }
    }

}
