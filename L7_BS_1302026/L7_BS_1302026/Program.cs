using System;
using System.ComponentModel;
// Entrada
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
// Proceso + Salida
Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio 7!");


//Ejercicio 1: Suma controlada por contador (WHILE)
{

    //Ingreso de número a sumar
    Console.Write("Ingrese cuantos números desea sumar: ");
    string numeroSumar = Console.ReadLine();
    Convert.ToInt32(Console.Read());
    int cantidadNumero = Console.Read();
    int contador = 0;

    while (cantidadNumero > 0)
    {
        Console.WriteLine("Ingrese el número a sumar: ");
        contador++;
        Console.WriteLine("Total de suma :" + contador);


    }

}
