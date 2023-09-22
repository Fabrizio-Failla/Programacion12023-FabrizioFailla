using Back;

namespace Front
{
    public partial class Form1 : Form
    {
        Principal principal = new Principal();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevocliente = new Cliente();
            nuevocliente.Id = int.Parse(textBox1.Text);
            nuevocliente.Nombre = textBox2.Text;
            nuevocliente.Apellido = textBox3.Text;
            nuevocliente.Dni = int.Parse(textBox4.Text);
            principal.AgregarCliente(nuevocliente);

            MessageBox.Show("Se a creado la cuenta exitosamente");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}