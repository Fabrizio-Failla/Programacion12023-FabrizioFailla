using Microsoft.EntityFrameworkCore;

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
            return context.TarjetadeCreditos.ToList();
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
            var tarjetaEncontrada = context.TarjetadeCreditos.Find(tarjetaCredito.Id);
            if (tarjetaEncontrada != null)
            {
                context.TarjetadeCreditos.Remove(tarjetaEncontrada);
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

        /*public bool ObtenerClientePorDNI(int DNI)
        {
            var clienteEncontrado = context.Clientes.Find(DNI);
            return clienteEncontrado != null;

        }*/
        public string GenerarNumeroTarjeta()
        {
            Random random = new Random();
            string numeroTarjeta = "";

            for (int i = 0; i < 16; i++)
            {
                int digito = random.Next(0, 10);
                numeroTarjeta += digito.ToString();
            }

            return numeroTarjeta;
        }

        public void EmitirTarjetaCredito(TarjetaCredito tarjeta)
        {
            try
            {
                context.TarjetadeCreditos.Add(tarjeta);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                // Aquí puedes acceder a detalles más específicos sobre el error.
                Console.WriteLine("Error al guardar la tarjeta de crédito: " + innerException.Message);
            }
        }
        public void PausarTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetadeCreditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Pausada";
                context.SaveChanges();
            }
        }
        public void ActivarTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetadeCreditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Activa";
                context.SaveChanges();
            }
        }
        public void BloquearTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetadeCreditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Bloqueado";
                context.SaveChanges();
            }
        }
        public string RealizarDeposito(string NumeroCuenta, double monto)
        {
            CuentaBancaria? cuenta = context.CuentaBancarias.FirstOrDefault(c => c.NumeroCuenta == NumeroCuenta);
            if (cuenta.NumeroCuenta == NumeroCuenta)
            {
                cuenta.Saldo += monto;
                context.SaveChanges();
                return "El dinero se a depositado correctamente";
            }
            else
            {
                return "No se a encontrado la cuenta para poder realizar el deposito";
            }
        }

        public string RealizarExtraccion(string NumeroCuenta, double monto)
        {
            CuentaBancaria? cuenta = context.CuentaBancarias.FirstOrDefault(c => c.NumeroCuenta == NumeroCuenta);
            if (cuenta.NumeroCuenta == NumeroCuenta)
            {
                if (cuenta.Saldo >= monto)
                {
                    cuenta.Saldo -= monto;
                    context.SaveChanges();
                    return "Se a retirado el dinero con exito";
                }
                else
                {
                    return "El dinero que desas extraer es superior de tu saldo";
                }

            }
            else
            {
                return "Cuenta no encontrada, ingrese nuevamente la cuenta";
            }
        }
        public string RealizarTransferencia(string cuentaOrigenNumero, string cuentaDestinoNumero, double monto)
        {
            CuentaBancaria? cuentaOrigen = context.CuentaBancarias.FirstOrDefault(c => c.NumeroCuenta == cuentaOrigenNumero);
            CuentaBancaria? cuentaDestino = context.CuentaBancarias.FirstOrDefault(c => c.NumeroCuenta == cuentaDestinoNumero);

            if (cuentaOrigen != null && cuentaDestino != null)
            {
                if (cuentaOrigen.Saldo > monto)
                {
                    cuentaOrigen.Saldo -= monto;
                    cuentaDestino.Saldo += monto;
                    context.SaveChanges();
                    return "La transferencia se ha realizado con éxito";
                }
                else
                {
                    return "El dinero que deseas transferir es inferior al saldo de tu cuenta";
                }

            }
            else
            {
                return "No se ha encontrado una de las cuentas";
            }

        }
        public string PagarTarjetaCredito(int tarjetaId, double monto)
        {
            var tarjeta = context.TarjetadeCreditos.Find(tarjetaId);
            if (tarjeta != null && tarjeta.Estado == "Activa")
            {
                if (monto <= tarjeta.MontoDeuda)
                {
                    tarjeta.MontoDeuda -= monto;
                    context.SaveChanges();
                    return "Se a pagado la deuda correctamente";
                }
                return "No tienes deudas";

            }
            else
            {
                return "La cuenta no se encuentra activa";
            }


        }

        public string GenerarResumenTarjeta(int tarjetaID)
        {
            var resumen = context.TarjetadeCreditos.Find(tarjetaID);
            if (resumen != null)
            {
                return $"Resumen de Tarjeta de Crédito.Número de Tarjeta:{resumen.NumeroTarjeta}, Saldo Disponible:{resumen.SaldoDisponible}. Limite de Crédito:{resumen.LimiteCredito}.Estado {resumen.Estado}.";
            }
            else { return "selecciona algo"; }

        }
        public string GenerarResumenCuenta(string NumeroCuenta)
        {
            CuentaBancaria? resumen = context.CuentaBancarias.FirstOrDefault(c => c.NumeroCuenta == NumeroCuenta);
            if (resumen != null)
            {
                return $"Tu saldo actual es de ${resumen.Saldo}. Tu cuenta es de tipo {resumen.Tipo}.";
            }
            else { return "Ingresa tu numero de cuenta"; }

        }
    }

}
