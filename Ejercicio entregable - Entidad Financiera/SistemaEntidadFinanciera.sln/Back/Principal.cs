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
        public List<Cliente> DevolverListaClientes()
        {
            return context.Clientes.ToList();
        }

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            context.CuentaBancarias.Add(cuenta);
            context.SaveChanges();
        }

        public void EmitirTarjetaCredito(TarjetaCredito tarjeta)
        {
            context.TarjetaCreditos.Add(tarjeta);
            context.SaveChanges();
        }
        public void PausarTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetaCreditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Pausada";
                context.SaveChanges();
            }
        }
        public void RealizarDeposito(int cuentaID, double monto)
        {
            var cuenta = context.CuentaBancarias.Find(cuentaID);
            if (cuenta != null)
            {
                cuenta.Saldo += monto;
                context.SaveChanges();
                Console.WriteLine("Deposito realizada]o correctamente.");

            }
            else { Console.WriteLine("Su cuenta no se encontro."); }
        }

        public void RealizarExtraccion(CuentaBancaria cuentaID, double monto)
        {
            var cuenta = context.CuentaBancarias.Find(cuentaID);
            if (cuenta.Saldo >= monto)
            {
                cuenta.Saldo -= monto;
                context.SaveChanges();
                Console.WriteLine("Extracción realizada correctamente.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar la extracción.");
            }
        }
        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, double monto)
        {
            var cuentaOrigen = context.CuentaBancarias.Find(cuentaOrigenId);
            var cuentaDestino = context.CuentaBancarias.Find(cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null && (cuentaOrigen.Saldo >= monto))
            {
                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;
                context.SaveChanges();
                Console.WriteLine("Transferencia realizada correctamente.");
            }
            else { Console.WriteLine("Saldo insuficiente para realizar la transferencia."); }
        }
        public void PagarTarjetaCredito(CuentaBancaria cuenta, TarjetaCredito tarjetaID, double monto)
        {
            var tarjeta = context.TarjetaCreditos.Find(tarjetaID);
            if (cuenta.Saldo >= monto)
            {
                cuenta.Saldo -= monto;
                tarjeta.SaldoDisponible += monto;
                context.SaveChanges();
                Console.WriteLine("Pago de tarjeta de crédito realizado correctamente.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el pago.");
            }
        }
        public void GenerarResumenTarjeta(TarjetaCredito tarjeta)
        {
           
            Console.WriteLine("Resumen de Tarjeta de Crédito");
            Console.WriteLine("Número de Tarjeta: " + tarjeta.NumeroTarjeta);
            Console.WriteLine("Saldo Disponible: " + tarjeta.SaldoDisponible);
            Console.WriteLine("Limite de Crédito: " + tarjeta.LimiteCredito);
        }

    }

}