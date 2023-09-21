using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            context.CuentaBancarias.Add(cuenta);
        }

        public void EmitirTarjetaCredito(TarjetaCredito tarjeta)
        {
            context.TarjetaCreditos.Add(tarjeta);
        }



    }
}
