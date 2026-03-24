using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Laboratorio 9 - Procedimientos");

        Console.WriteLine("\n-------------------------------------------------\n");

        //EJERCICIO 1: SALUDO MODULARIZADO
        Console.WriteLine(" EJERCICIO 1: SALUDO MODULARIZADO ");

        Console.Write("Ingrese su nombre: ");
        string nombreUsuario = Console.ReadLine();
        saludarUsuario(nombreUsuario);
        mostrarInfoCurso();

        Console.WriteLine("\n-------------------------------------------------\n");

        //EJERCICIO 2: CALCULADORA CON PROCEDIMIENTOS
        Console.WriteLine(" EJERCICIO 2: CALCULADORA CON PROCEDIMIENTOS ");

        Console.Write("Ingrese el lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());
        AreaCuadrado(lado);

        Console.Write("Ingrese la base del rectangulo: ");
        double baseRect = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del rectangulo: ");
        double alturaRect = double.Parse(Console.ReadLine());
        AreaRectangulo(baseRect, alturaRect);

        Console.Write("Ingrese la base del triangulo: ");
        double baseTri = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del triangulo: ");
        double alturaTri = double.Parse(Console.ReadLine());
        AreaTriangulo(baseTri, alturaTri);

        Console.WriteLine("\n-------------------------------------------------\n");

        //EJERCICIO 3: MENÚ DE FIGURAS
        Console.WriteLine(" EJERCICIO 3: MENÚ DE FIGURAS ");

        int opcionFigura;
        do
        {
            Console.WriteLine("\n1. Cuadrado\n2. Triangulo\n3. Linea\n4. Salir");
            Console.Write("Seleccione una opcion: ");
            opcionFigura = int.Parse(Console.ReadLine());

            if (opcionFigura >= 1 && opcionFigura <= 3)
            {
                Console.Write("Ingrese N (tamaño): ");
                int n = int.Parse(Console.ReadLine());

                switch (opcionFigura)
                {
                    case 1: DibujarCuadrado(n); break;
                    case 2: DibujarTriangulo(n); break;
                    case 3: DibujarLinea(n); break;
                }
            }
        } while (opcionFigura != 4);

        Console.WriteLine("\n-------------------------------------------------\n");

        //EJERCICIO 4: REGISTRO DE NOTAS
        Console.WriteLine(" EJERCICIO 4: REGISTRO DE NOTAS ");

        double sumaNotas = 0;
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese la nota " + i + ": ");
            double nota = double.Parse(Console.ReadLine());
            sumaNotas += nota;
            EvaluarNota(nota, ref aprobados, ref reprobados);
        }

        double promedio = sumaNotas / 5;
        MostrarResumenNotas(promedio, aprobados, reprobados);

        Console.WriteLine("\n-------------------------------------------------\n");

        //EJERCICIO 5: INTERCAMBIO DE VALORES (REF)
        Console.WriteLine(" EJERCICIO 5: INTERCAMBIO DE VALORES (REF) ");

        Console.Write("Ingrese el primer numero (A): ");
        int numeroA = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero (B): ");
        int numeroB = int.Parse(Console.ReadLine());

        Console.WriteLine("Antes: " + numeroA + ", " + numeroB);
        IntercambiarValores(ref numeroA, ref numeroB);
        Console.WriteLine("Despues: " + numeroA + ", " + numeroB);

        Console.WriteLine("\n-------------------------------------------------\n");
        Console.WriteLine("Fin del Laboratorio 09. Presione cualquier tecla para salir...");
        Console.ReadKey();
    }



    // ==========================================================
    // PROCEDIMIENTOS (FUERA DEL MAIN)
    // ==========================================================

    // Procedimientos Ejercicio 1
    static void saludarUsuario(string nombre)
    {
        Console.WriteLine("Hola " + nombre + ", Bienvenido al LAB-9 de PC");
    }

    static void mostrarInfoCurso()
    {
        Console.WriteLine("Curso: Pensamiento Computacional (Práctica) - Lab 09");
    }

    // Procedimientos Ejercicio 2 
    static void AreaCuadrado(double lado)
    {
        Console.WriteLine("El area del cuadrado es: " + (lado * lado));
    }

    static void AreaRectangulo(double b, double h)
    {
        Console.WriteLine("El area del rectangulo es: " + (b * h));
    }

    static void AreaTriangulo(double b, double h)
    {
        Console.WriteLine("El area del triangulo es: " + ((b * h) / 2));
    }

    //  Procedimientos Ejercicio 3 
    static void DibujarCuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            DibujarLinea(n); 
        }
    }

    static void DibujarTriangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            DibujarLinea(i); 
        }
    }

    static void DibujarLinea(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine(); 
    }

    //  Procedimientos Ejercicio 4 
    static void EvaluarNota(double nota, ref int ap, ref int rep)
    {
        if (nota >= 61)
        {
            Console.WriteLine("Estudiante Aprobado");
            ap++;
        }
        else
        {
            Console.WriteLine("Estudiante Reprobado");
            rep++;
        }
    }

    static void MostrarResumenNotas(double prom, int ap, int rep)
    {
        Console.WriteLine("\n--- Resumen ---");
        Console.WriteLine("Promedio de la clase: " + prom);
        Console.WriteLine("Estudiantes Aprobados: " + ap);
        Console.WriteLine("Estudiantes Reprobados: " + rep);
    }

    // Procedimientos Ejercicio 5
    static void IntercambiarValores(ref int a, ref int b)
    {
        int temporal = a;
        a = b;
        b = temporal;
    }
}