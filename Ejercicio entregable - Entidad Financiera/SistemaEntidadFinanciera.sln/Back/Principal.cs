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
            context.SaveChanges();
        }

        public void EmitirTarjetaCredito(TarjetaCredito tarjeta)
        {
            context.TarjetaCreditos.Add(tarjeta);
            context.SaveChanges();
        }
        public void PausarTarjetaCredito(TarjetaCredito tarjeta)
        {

            tarjeta.Estado = "Pausada";
            context.SaveChanges();
            Console.WriteLine("Tarjeta de crédito pausada correctamente.");
        }
        public void RealizarDeposito(CuentaBancaria cuenta, double monto)
        {
            cuenta.Saldo += monto;
            context.SaveChanges();
            Console.WriteLine("Depósito realizado correctamente.");
        }
        public void RealizarExtraccion(CuentaBancaria cuenta, double monto)
        {

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
        public void RealizarTransferencia(CuentaBancaria origen, CuentaBancaria destino, double monto)
        {

            if (origen.Saldo >= monto)
            {
                origen.Saldo -= monto;
                destino.Saldo += monto;
                context.SaveChanges();
                Console.WriteLine("Transferencia realizada correctamente.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar la transferencia.");
            }
        }
        public void PagarTarjetaCredito(CuentaBancaria cuenta, TarjetaCredito tarjeta, double monto)
        {

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