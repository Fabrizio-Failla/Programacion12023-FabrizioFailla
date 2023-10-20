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
        
       
        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            context.CuentaBancarias.Add(cuenta);
            context.SaveChanges();

        }

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
           
                context.TarjetadeCreditos.Add(tarjeta);
                context.SaveChanges();
            
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
        public string PagarTarjetaCredito(string tarjeta, double monto)
        {
            TarjetaCredito? numerotarjeta = context.TarjetadeCreditos.FirstOrDefault(c => c.NumeroTarjeta== tarjeta);
            if (numerotarjeta != null && numerotarjeta.Estado == "Activa")
            {
                if (monto <= numerotarjeta.MontoDeuda)
                {
                    numerotarjeta.MontoDeuda -= monto;
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

        public string GenerarResumenTarjeta(string NumeroTarjeta)
        {
            TarjetaCredito? resumen = context.TarjetadeCreditos.FirstOrDefault(c => c.NumeroTarjeta== NumeroTarjeta);
            if (resumen != null)
            {
                return $"Numero de Tarjeta:{resumen.NumeroTarjeta}, Saldo Disponible:${resumen.SaldoDisponible}.Monto adeudado {resumen.MontoDeuda}. Limite de Crédito:{resumen.LimiteCredito}.Estado {resumen.Estado}.";
            }
            else { return "Tarjeta no encontrada"; }

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
