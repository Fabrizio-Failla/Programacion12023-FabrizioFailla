//1- Se ingresa el código de producto (son 10 productos, codificados del 1 al 10),luego el
//precio y la cantidad que del mismo.La carga finaliza cuando se ingresa un código = 0
//; al terminar indicar el código de producto que mayor cantidad tiene.

for (int codigo = 1; codigo <= 10; codigo++)
{
    Console.WriteLine("Ingrese nombre del producto:");
    string? producto = Console.ReadLine();
    Console.WriteLine("Ingrese precio:");
    double precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad:");
    double cantidad = double.Parse(Console.ReadLine());

    while (codigo != 0)
    {
        Console.WriteLine("El producto con mayo cantidad es el codigo" + producto);
    }
}
