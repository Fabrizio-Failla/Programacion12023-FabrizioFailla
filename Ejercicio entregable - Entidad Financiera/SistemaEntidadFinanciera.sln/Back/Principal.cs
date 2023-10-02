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
        public void ModificarCliente(Cliente clienteModificado)
        {
            var clienteEncontrado = context.Clientes.Find(clienteModificado.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombre = clienteModificado.Nombre;
                clienteEncontrado.Apellido = clienteModificado.Apellido;
                clienteEncontrado.Dni = clienteModificado.Dni;
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

        public bool  ObtenerClientePorDNI(int DNI)
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
        public void PagarTarjetaCredito(CuentaBancaria cuenta, TarjetaCredito tarjetaID, double monto)
        {
            var tarjeta = context.TarjetaCreditos.Find(tarjetaID);
            if (cuenta.Saldo >= monto)
            {
                cuenta.Saldo -= monto;
                tarjeta.SaldoDisponible += monto;
                context.SaveChanges();
            }
        }
        public string GenerarResumenTarjeta(TarjetaCredito tarjeta)
        {return $"Resumen de Tarjeta de Crédito.Número de Tarjeta:{tarjeta.NumeroTarjeta}, Saldo Disponible:{tarjeta.SaldoDisponible}. Limite de Crédito:{tarjeta.LimiteCredito}.";}

    }

}