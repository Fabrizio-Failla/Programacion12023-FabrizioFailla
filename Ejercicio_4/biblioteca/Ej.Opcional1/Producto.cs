using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set;}
        public abstract double CalcularImpuesto();
        public abstract double CalcularTotal();
    }
}
