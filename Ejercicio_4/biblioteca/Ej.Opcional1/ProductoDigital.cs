using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Ej.Opcional1
{
    public class ProductoDigital : Producto
    {
        public double Tamano { get; set; }
        public override double CalcularImpuesto()
        {
            return Precio * 0.05;

        }

        public override double CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
