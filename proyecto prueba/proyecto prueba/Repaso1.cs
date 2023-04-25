/*
 //Este es un ejercicio donde hay un podio de 3 ganadores en una lista de 5 productos, es como un 5 BIS
int elUno = 0;
int elDos = 0;
int elTres = 0;
string elNombreUno = "";
string elNombreDos = "";
string elNombreTres = "";

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Porfa ingreseme el nombre del pibe ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Porfa ingreseme cuanto gastó ");
    int gasto = int.Parse(Console.ReadLine());


    if (gasto > elUno)
    {
        // Aca es porque llegó un nuevo grandote, uno mayor a todos, tiene que ir primero
        // Ojo que allá en el fondo aclaran también que podría ser el primero, así que ojo.

        // acá yo subo al primer flaco al palco del mas grande, pero ANTES!! ojo que si había
        // uno.. no lo puedo matar, tengo que ponerlo en el segundo.
        // pero ANTES de matar al tercero, ahí tengo que sentar al segundo
        elTres = elDos;
        elNombreTres = elNombreDos;

        elDos = elUno;
        elNombreDos = elNombreUno;

        elUno = gasto;
        elNombreUno = nombre;


    }
    else
    {   // acá SI, ya sé que tengo un valor que NO fue primero... pero.. podría ser segundo
        // podría ser tercero o ninguno !!! ...  
        if (gasto > elDos)
        {
            // SI ESTOY acá es porque este nuevo flaco gastó MENOS que el primero
            // pero más que el segundo.
            // eentonces... tengo un nuevo segundo... y un nuevo tercero
            elTres = elDos;
            elNombreTres = elNombreDos;
            elDos = gasto;
            elNombreDos = nombre;

        }
        else
        {
            if (gasto > elTres)
            {
                elTres = gasto;
                elNombreTres = nombre;
            }
        }

    }
}

Console.WriteLine("El pibe que más gastó 1 fue " + elNombreUno);
Console.WriteLine("El pibe que más gastó 2 fue " + elNombreDos);
Console.WriteLine("El pibe que más gastó 3 fue " + elNombreTres);
*/
/*
//Ejercicio 5 for
//-------------------------------------------------------------------------
//El usuario ingresa 5 pares de valores con el nombre del cliente
//y el total gastado, indicar el cliente que gastó más. 
int elMayorGasto=0;
string elnombredelmayor = "";
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese su nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el total gastado:");
    int gasto = int.Parse(Console.ReadLine());
    if(gasto>elMayorGasto)
    {
        elMayorGasto = gasto;
        elnombredelmayor=nombre;    
    }
}
Console.WriteLine("El que gasto mas fue " + elnombredelmayor + ", con un total gastado de: $" + elMayorGasto);
*/

/*
//EJERCICIO 4de for
//----------------------------------------------------------------
//De una lista de 8 números indicar cual es el mayor
List<int> numeros = new List<int>();
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese numeros enla lista :");
    int numero = int.Parse(Console.ReadLine());
    numeros.Add(numero);
}
int mayor = numeros.Max();
Console.WriteLine("El numero mayor de la lista es:"+ mayor);
*/
/*
//EJERCICIO 3 de for
//--------------------------------------------------------------------------
//Para calcular el total de una factura , el usuario ingresará pares
//de datos Costo y Total ; de unas 5 compras; informar el total adeudado.
int totalAdeudado =0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingresas costos:");
    string cost = Console.ReadLine();
    int costo = int.Parse(cost);
    Console.WriteLine("EL costo total es:");
    string tota = Console.ReadLine();
    int total = int.Parse(tota);
    totalAdeudado += total + totalAdeudado;   
} 
Console.WriteLine("el total adeudado es: $"+ totalAdeudado);
/*

/* 
//EJERCICIO 2 de for
//-------------------------------------------------------------------
//Se necesita calcular el promedio de 8 números ingresados por el usuario
Console.WriteLine("Ingresar valores numeros");
int suma = 0;
double promedio;
for (int i = 0; i < 8; i++)
{
    string num = Console.ReadLine();
    int numero = int.Parse(num);
    suma = numero + suma;    
}
promedio = suma / 8;
Console.WriteLine("El promedio de los 8 numero es:"+promedio);
/*
//EJERCICIO 1 DE FOR
//---------------------------------------------------------------------------
//El usuario necesita ingresar 5 valores enteros, el sistema deberá informar
//la suma de los 5


Console.WriteLine("Ingresar valores enteres");
int suma = 0;
for (int i = 0; i < 5; i++)
{
    string valores = Console.ReadLine();
    int valoresEnteros = int.Parse(valores);
    suma = valoresEnteros + suma;
}
Console.WriteLine("La suma de los 5 valores enteros son:"+ suma);   
*/
/*
//Ejercicio 5 de while
//----------------------------------------------------------------------------
//Para calcular el consumo total de un cliente, el usuario primero ingresará
//cuántos productos compró; luego el sistema solicitará que ingrese el total
//y costo de cada uno de esos productos consumidos; al terminar informará el
//total adeudado por el cliente. 
Console.WriteLine("Ingresar cuantos prodctos comprastes:");
string cantidadProductos = Console.ReadLine();

int productos = int.Parse(cantidadProductos);
int cantidadTotal = 0;
for (int i = 1; i <= productos; i++)
    {
        Console.WriteLine("Ingresar costo del producto");
        string costoProducto = Console.ReadLine();
        int costo = int.Parse(costoProducto); 
        cantidadTotal += costo;     
    }
Console.WriteLine("total adeudado por el cliente:" + cantidadTotal);
*/

/*
//---------------------------------------------------------------------
//EJERCICIO 4 de while
//Para calcular el total de una factura , el usuario ingresará pares
//de datos Costo y Total ; cuando se ingrese costo 0 finaliza el ingreso
//de datos; informar el total adeudado.
Console.WriteLine("Ingresar costo");
string costo = Console.ReadLine();
int costoNum = int.Parse(costo);
int suma = 0;

while (costoNum > 0)
{

    Console.WriteLine("Poner total");
    string total = Console.ReadLine();
    int totalNum = int.Parse(total);
    suma = suma + (costoNum * totalNum);

    Console.WriteLine("Ingresar el costo");
    costo = Console.ReadLine();
    costoNum = int.Parse(costo);
}
Console.WriteLine("Flaco , pusiste: " + suma);
*/
//EJERCIO 3 WHILE
//El usuario ingresará una lista de nombre de persona, cuando 
// se ingresé un nombre vacío, sin datos; el sistema informará 
//cuántos nombres de han ingresado.
//------------------------------------------------------------
/*
Console.WriteLine("Ingresar nombres:");
 string nombre = Console.ReadLine();
double contador=0;
while(nombre =="")
{
    contador = contador + 1;
    Console.WriteLine("Ingresar nombres:");
    nombre = Console.ReadLine();    

}
Console.WriteLine("La cantidad de nombres fueron:" + contador);
*/
/*
// EJERCICIO2 de WHILE @Siguiendo el ejercicio anterior, 
//calcular el promedio de losvalores ingresados
//------------------------------------------------------------------------------- 
Console.WriteLine("Ingresar valores y cuando no tengas más, pon un 0");
double sumita = 0;
double numero_doble;
double promedio = 0;
int cantidadIngresado = 0;
string valor = Console.ReadLine();
numero_doble = double.Parse(valor);
while (numero_doble > 0)
{
    sumita += numero_doble;
    cantidadIngresado++;
    promedio = sumita / cantidadIngresado;
    Console.WriteLine("Ingresar valor");
    valor = Console.ReadLine();
    numero_doble = double.Parse(valor);
}
Console.WriteLine("El promedio es de: " + promedio);
Console.WriteLine("El valor total es de: " + sumita);
*/

/* EJERCICIO 1 DE WHILE
// -------------------------------------------------------
Console.WriteLine("Ingresar valores y cuanto no tengas mas,poneme un 0");
Console.WriteLine("ingresar valor");
int sumita = 0;

string valor = Console.ReadLine();
int valorint = int.Parse(valor);

while (valorint > 0)
{
    sumita = sumita + valorint;

    Console.WriteLine("ingrsar valor");
    valor = Console.ReadLine();
    valorint = int.Parse(valor);
}
Console.WriteLine("El valoe toal:" + sumita);
*/

/*
// ------------------------------------------------------------------------
 * EJERCICIOS de DO- WHILE
//EJERCICIO 5:Siguiendo con el ejercicio anterior, al ingresar un
//menor a 3 cifras se mostrará el promedio de los ingresados. 
Console.WriteLine("Ingresar numeros");
string? numero;
double numero_doble;
double suma = 0;
double promedio = 0;
int cantidadIngresado = 0;
do
{
    numero = Console.ReadLine();
    numero_doble = double.Parse(numero);
    suma += numero_doble;
    cantidadIngresado++;
    promedio = suma / cantidadIngresado;
    if (numero_doble < 100) ;
    {
        Console.WriteLine("El promedio es de:"+promedio);
    }
} while (numero_doble <= 100);
Console.WriteLine("Perfecto, ingresaste un numero de 4 cifras o mas");
*/

/*
// -------------------------------------------------------------------
// EJERCICIO 4:Se le solicitará ingresar números al usuario, se repetirá el
//pedido hasta que ingrese un número mayor a 3 cifras
Console.WriteLine("Ingresar numeros");
string? numero;
int numero_entero;
do
{
    numero = Console.ReadLine();
    numero_entero = int.Parse(numero);  

}  while (numero_entero < 1000);

Console.WriteLine("correcto");
*/

/*
//-----------------------------------------------
//EJERCICIO 3:Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará
//el promedio de los números negativos ingresados 
/*
Console.WriteLine("Ingresar un numero");
string? numero;
double numero_doble;
double sumaNegativo = 0;
int negativosTotal = 0;
do
{
    numero = Console.ReadLine();
    numero_doble=double.Parse(numero);
    if (numero_doble < 0) ;
    {
        sumaNegativo += numero_doble;
        negativosTotal++;
    }
} while (numero_doble <= 0);
Console.WriteLine("Correcto, ingreso un positivo");
double promedio = sumaNegativo / negativosTotal;
Console.WriteLine("El promedio de los numeros negativos ingresados es de: " + promedio);
*/





/*//EJERCICIO 2:
 // Se le solicitará ingresar un número al usuario, se repetirá el pedido 
//hasta que ingrese un positivo.
// ---------------------------------------------------------
  Console.WriteLine("Ingresar un numero");
string? numero;
int? numero_entero;
do
{
    numero= Console.ReadLine();
    numero_entero = int.Parse(numero);
} while (numero_entero<=0);
Console.WriteLine("correcto");
/*
// -------------------------------------------------------------
Console.WriteLine("ingresar la clave");
string? clave;
do
{
    clave = Console.ReadLine();
} while (clave != "667788");
Console.WriteLine("perfecto");
*/

/*
// ---------------------------------------------------------------------------------
 * //EJERCICIO 1:Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave,
//repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788
Console.WriteLine("ingresar clave");
string? clave= Console.ReadLine();
while (clave != "667788");
{
    Console.WriteLine("No es corrercta, probar de nuevo");
    clave = Console.ReadLine();
}
Console.WriteLine("perfecto");
*/