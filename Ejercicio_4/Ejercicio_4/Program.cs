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
            List<Producto> lista_producto = new List<Producto>();
            ProductoDigital productoDigital1 = new ProductoDigital("FIFA_23",150000,10000);
            ProductoFisico productoFisico1 = new ProductoFisico("Play_4",75000,5);
            lista_producto.Add(productoDigital1);
            list
  
            foreach (Producto productos in lista_producto)
            {
                Console.WriteLine($"El  nombre de este  producto es:{productos.Nombre}");
                Console.WriteLine($"El  precio del producto es: {productos.Precio}");
                Console.WriteLine($"El  impuesto del producto es: { productos.CalcularImpuesto()}");
                Console.WriteLine($"El  precio final del producto es: {productos.CalcularTotal()}");

            }
        }
    }
}      
