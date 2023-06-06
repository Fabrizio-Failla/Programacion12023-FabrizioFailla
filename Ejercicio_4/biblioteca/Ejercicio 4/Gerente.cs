using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Gerente : Empleado
    {
        public double bono { get; set; }
        public override double CalcularSalario()
        {
            return salarioBase + bono;
        }
    }
}