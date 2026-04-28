using System;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Bienvenido(a), " + nombre);
        Console.WriteLine("------------------------------\n");

        Console.WriteLine("1. Manejo de cadenas – Validación de contraseña\n");
        Console.Write("Ingrese su Contraseña: ");
        string contraseña = Console.ReadLine();


        //Declarar variables para validación de contraseña
        string caracteresEspeciales = "!@#$%^&*()_+-=[]{}|;':,.<>/?";
        string numeros = "0123456789";
        string letrasMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        if (contraseña.Length >= 8) ;
        {
            string cantidadCaracteres = contraseña.Length.ToString();
                   if (contraseña[] = numeros }
    }
}