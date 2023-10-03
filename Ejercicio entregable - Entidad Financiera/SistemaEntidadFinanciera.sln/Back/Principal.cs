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
        public List<CuentaBancaria> DevolverListaCuentaBancaria()
        {
            return context.CuentaBancarias.ToList();
        }
        public List<TarjetaCredito> DevolverListaTarjetaCredito()
        {
            return context.TarjetaCreditos.ToList();
        }

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void EliminarCLiente(Cliente cliente)
        {
            var clienteEncontrado = context.Clientes.Find(cliente.Id);
            if (clienteEncontrado != null)
            {
                context.Clientes.Remove(clienteEncontrado);
                context.SaveChanges();
            }
        }
        public void Eliminartarjetas(TarjetaCredito tarjetaCredito)
        {
            var tarjetaEncontrada = context.TarjetaCreditos.Find(tarjetaCredito.Id);
            if (tarjetaEncontrada != null)
            {
                context.TarjetaCreditos.Remove(tarjetaEncontrada);
                context.SaveChanges();
            }
        }

        public void EliminarCuentaBancaria(CuentaBancaria cuentaBancaria)
        {
            var cuentaEncontrada = context.CuentaBancarias.Find(cuentaBancaria.Id);
            if (cuentaEncontrada != null)
            {
                context.CuentaBancarias.Remove(cuentaEncontrada);
                context.SaveChanges();
            }
        }
        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            context.CuentaBancarias.Add(cuenta);
            context.SaveChanges();
        }

        public bool ObtenerClientePorDNI(int DNI)
        {
            var clienteEncontrado = context.Clientes.Find(DNI);
            return clienteEncontrado != null;

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
        public void ActivarTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetaCreditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Activa";
                context.SaveChanges();
            }
        }
        public void BloquearTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetaCreditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Bloqueado";
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
            }
        }

        public string RealizarExtraccion(int cuentaID, double monto)
        {
            var cuenta = context.CuentaBancarias.Find(cuentaID);
            if (cuenta.Saldo >= monto)
            {
                cuenta.Saldo -= monto;
                context.SaveChanges();
                return "Se a retirado el dinero con exito";
            }
            else
            {
                return "No se a encontrado la cuenta";
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
            }
            
        }
        /*public void PagarTarjetaCredito(int tarjetaId, double monto)
        {
            var tarjeta = context.TarjetaCreditos.Find(tarjetaId);
            if (tarjeta != null && tarjeta.Estado == "Activa")
            {
                if (monto <= tarjeta.MontoDeuda)
                {
                    tarjeta.MontoDeuda -= monto;
                    context.SaveChanges();
                }
            }
        }
        */
        public string GenerarResumenTarjeta(int tarjetaID)
        {
            var resumen = context.TarjetaCreditos.Find(tarjetaID);
            if (resumen != null)
            {
                return $"Resumen de Tarjeta de Crédito.Número de Tarjeta:{resumen.NumeroTarjeta}, Saldo Disponible:{resumen.SaldoDisponible}. Limite de Crédito:{resumen.LimiteCredito}.Estado {resumen.Estado}.";
            }
            else { return "selecciona algo"; }

        }

    }
}