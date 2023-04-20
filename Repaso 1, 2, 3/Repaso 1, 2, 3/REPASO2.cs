//EJERCICIO 1 DE REPASO2
//-----------------------------------------------------------------------------------------

//1- Se ingresa el código de producto (son 10 productos, codificados del 1 al 10),luego el
//precio y la cantidad que del mismo.La carga finaliza cuando se ingresa un código = 0
//; al terminar indicar el código de producto que mayor cantidad tiene.
int codigo = 1;
double valorMaximo = 0;
while (codigo != 0 && codigo <= 10)   
{
    Console.WriteLine("Ingrese nombre del producto:");
    string? producto = Console.ReadLine();
    if (codigo != 0 && codigo <= 10)
    {
        Console.WriteLine("Ingrese nombre del producto:");
        string? producto = Console.ReadLine();
        Console.WriteLine("Ingrese precio:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidad:");
        double cantidad = double.Parse(Console.ReadLine());
        if (cantidad > valorMaximo)
        {
            valorMaximo = cantidad;
        }

    }
}
Console.WriteLine("El producto con mayo cantidad es el codigo" + valorMaximo);