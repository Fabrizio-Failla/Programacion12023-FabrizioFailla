using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class CuentaBancaria
    {
        public int Id { get; set; }
        public int NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public string Tipo { get; set; }//corriento o ahorro
        public string info_list_box
        {
            get { return $"Numero de cuenta {NumeroCuenta}.Tiene ${Saldo}.Estado de cuenta {Tipo}."; }
        }
    }
}
