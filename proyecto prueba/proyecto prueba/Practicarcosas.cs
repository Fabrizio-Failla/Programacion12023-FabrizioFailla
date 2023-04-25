/*using System.Timers;

List <int> cantidadDeProductos=new List <int>();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingresar numeros ");
    cantidadDeProductos.Add(int.Parse(Console.ReadLine()));  
}
Console.WriteLine(cantidadDeProductos.Average());
//PEDIR 5 NUMEROS GUARDARLOS EN  UNA LISTITA DE INT Y AL FINAL MOSTRAR EL PROMEDIO
//cantidadDeProductos.Add agrgar elementos
//cantidadDeProductos.Capacity = 10;// es la cantidad de capacidad que queres
//cantidadDeProductos[1]*/
/*List<int> codig = new List<int>();
List<string> nombres = new List<string>();
int codigos = 1;
while (codigos != 0 && codigos <= 10)
{
    Console.WriteLine("Ingrese código del producto (1 al 10, 0 para finalizar):");
    codigos = int.Parse(Console.ReadLine());
    codig.Add(codigos);
    if (codigos != 0 && codigos <= 10)
    {
        Console.WriteLine("Ingrese nombre del producto:");
        string? producto = Console.ReadLine();
        Console.WriteLine("Ingrese precio:");
        int precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidad:");
        int cantidad = int.Parse(Console.ReadLine());
        nombres.Add(producto);
        codig.Add(precio);
        codig.Add(cantidad);   
    }  
}
int valorMaximo = codig.Max();
Console.WriteLine("El codigo del producto con mayor cantidad es: "+valorMaximo);
*/
/*
//Retomando el ejercicio 1 ; al finalizar la carga de productos, se ingresan las ventas
//que hubo por cada código, puede haber más de 1 venta por cada articulo. El ingreso finaliza
//al colocar un código en 0.  Informar al final los que tienen una cantidad (o sea la cantidad
//inicial , restando las ventas que tuvo) menor o igual a 0
int codigo = 1;
double valorMaximo = 0;
int codigoMaximo = 0;
double valortotal;
List<int> codigos = new List<int>();

while (codigo != 0 && codigo <= 10)
{
    Console.WriteLine("Ingrese código del producto (1 al 10, 0 para finalizar):");
    codigo = int.Parse(Console.ReadLine());

    if (codigo != 0 && codigo <= 10)
    {
        Console.WriteLine("Ingrese nombre del producto:");
        string? producto = Console.ReadLine();
        Console.WriteLine("Ingrese precio:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidad:");
        double cantidad = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese ventas que tuvo:");
        double ventas = double.Parse(Console.ReadLine());
        valortotal = cantidad - ventas;

        if (valortotal <= 0)
        {
            codigos.Add(codigo);
        }
    }
}

if (codigos.Count > 0)
{
    Console.WriteLine("Los productos que tienen ventas menores a 10 son:");
    foreach (int codigoProducto in codigos)
    {
        Console.WriteLine("Codigo "+codigoProducto);
    }
}
*/