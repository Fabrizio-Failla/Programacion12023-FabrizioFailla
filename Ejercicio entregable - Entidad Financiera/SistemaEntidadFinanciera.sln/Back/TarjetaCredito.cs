using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class TarjetaCredito
    {
        public int Id { get; set; }
        public int NumeroTarjeta { get; set; }
        public double LimiteCredito { get; set; }
        public double SaldoDisponible { get; set; }
        public string Estado { get; set; }
    }
}
