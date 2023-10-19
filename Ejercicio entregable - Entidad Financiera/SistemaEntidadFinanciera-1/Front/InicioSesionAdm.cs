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
    public partial class InicioSesionAdm : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public InicioSesionAdm()
        {
            InitializeComponent();
        }

        private void InicioSesionAdm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userIngresado = int.Parse(textBox1.Text);
            string Apellido = textBox2.Text;
            Administrador? admEncontrado = context.Administradores.FirstOrDefault(a => a.Dni == userIngresado);
            if (admEncontrado != null)
            {
                if (Apellido == admEncontrado.Apellido)
                {
                    EmitarTarjeta menuadm = new EmitarTarjeta();
                    menuadm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos, intente nuevamente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincial menuadm = new MenuPrincial();
            menuadm.Show();
            this.Hide();

        }
    }
}
