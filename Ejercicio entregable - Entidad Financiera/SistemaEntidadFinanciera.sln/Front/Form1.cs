using Back;

namespace Front
{
    public partial class Form1 : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public Form1()
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
    }
}