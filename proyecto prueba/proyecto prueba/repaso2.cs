﻿//Retomando el ejercicio 1 ; al finalizar la carga de productos, se ingresan las ventas
//que hubo por cada código, puede haber más de 1 venta por cada articulo. El ingreso finaliza
//al colocar un código en 0.  Informar al final los que tienen una cantidad (o sea la cantidad
//inicial , restando las ventas que tuvo) menor o igual a 0
int codigo = 1;
double valorMaximo = 0;
int codigoMaximo = 0;
double valortotal;
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
        if(valortotal <= 0)
        { 
           codigoMaximo = codigo;
        }
    }
}
Console.WriteLine("El producto cuyas cantidades restantes fueron menores o igual a 0 fueron el codigo: "+codigoMaximo);
/*
//EJERCICIO
//1 DE REPASO2
//-----------------------------------------------------------------------------------------
//1- Se ingresa el código de producto (son 10 productos, codificados del 1 al 10),luego el
//precio y la cantidad que del mismo.La carga finaliza cuando se ingresa un código = 0
//; al terminar indicar el código de producto que mayor cantidad tiene.
int codigo = 1;
double valorMaximo = 0;
int codigoMaximo = 0;
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
        if (cantidad > valorMaximo)
        {
            valorMaximo = cantidad;
            codigoMaximo= codigo;
        }

    }
}
Console.WriteLine("El producto con mayor cantidad de unidades ("+valorMaximo+") es el de codigo: " + codigoMaximo);
*/