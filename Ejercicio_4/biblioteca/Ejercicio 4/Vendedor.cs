using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Vendedor : Empleado
    {
        public double comision { get; set; }

        public override double CalcularSalario()
        {
            return salarioBase + comision;
        }
    }
}
