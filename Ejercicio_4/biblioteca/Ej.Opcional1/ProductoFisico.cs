using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Ej.Opcional1
{
    public class ProductoFisico: Producto
    {
        public double Peso { get; set; }

        public override double CalcularImpuesto()
        {
            return  Precio * 0.10;
        }
        public override double CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
