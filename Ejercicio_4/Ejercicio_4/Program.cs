using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca;
using biblioteca.Ej.Opcional1;
using biblioteca.Ejercicio5;

namespace Ejercicio_4
{
    internal static class Program
    {
      
        static void Main(string[] args)
        {
            /*
                                   List<Empleado> empleados = new List<Empleado>();
                                   Gerente gerente = new Gerente();
                                   gerente.nombre = "Juan";
                                   gerente.salarioBase = 5000;
                                   gerente.bono = 2000;
                                   empleados.Add(gerente);

                                   Vendedor vendedor = new Vendedor();
                                   vendedor.nombre = "Pedro";
                                   vendedor.salarioBase = 3000;
                                   vendedor.comision = 1000;
                                   empleados.Add(vendedor);
                                    foreach (Empleado empleado in empleados)
                                    {
                                        double salario = empleado.CalcularSalario();
                                        Console.WriteLine("El salario de " + empleado.nombre + " es: " + salario);
                                    } 
            */
            /*
                          //EJERCICIO 5
                        List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();
                        instrumentos.Add(new Guitarra());
                        instrumentos.Add(new Piano());
                        instrumentos.Add(new Bateria());

                        foreach (InstrumentoMusical instrumento in instrumentos)
                        {
                            instrumento.Tocar();
                        }
            */
            List<Producto> producto = new List<Producto>();
            ProductoDigital productoDigital1 = new ProductoDigital();
            productoDigital1.Nombre = "FIFA_23";
            productoDigital1.Precio = 15000;
            productoDigital1.Tamano = 100000;
            producto.Add(new ProductoDigital ());

            ProductoFisico productoFisico1 = new ProductoFisico();
            productoFisico1.Nombre = "Play_4";
            productoFisico1.Precio = 70000;
            productoFisico1.Peso = 5;
            producto.Add(new ProductoFisico());
            foreach (Producto Producto in producto)
            {
                double preciofinalDigital = productoDigital1.CalcularTotal();
                Console.WriteLine("El  producto " + productoDigital1.Nombre + " tiene un precio total de " + preciofinalDigital);
                double preciofinalFisico= productoFisico1 .CalcularTotal();
                Console.WriteLine("El  producto " + productoFisico1.Nombre + " tiene un precio total de " + preciofinalFisico);

            }
        }
    }
}      
