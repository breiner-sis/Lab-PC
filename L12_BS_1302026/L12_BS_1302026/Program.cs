    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

    // --- MENÚ PARA PROBAR LOS EJERCICIOS ---
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine(" MENÚ\n");
                Console.WriteLine("1. Ejercicio 1 (Matriz 4x4)");
                Console.WriteLine("2. Ejercicio 2 (Matriz 3x5 Mayor)");
                Console.WriteLine("3. Ejercicio 3 (Multiplicar Matrices)");
                Console.WriteLine("4. Ejercicio 4 (Matriz 5x5 Diagonales)");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicio1(); break;
                    case "2": Ejercicio2(); break;
                    case "3": Ejercicio3(); break;
                    case "4": Ejercicio4(); break;
                    case "5": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }
    // EJERCICIO 1
    static void Ejercicio1()
    {
        Console.WriteLine("EJERCICIO 1\n:");
        int[,] matriz = new int[4, 4];

        // Procedimiento llenarMatriz
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Ingrese valor [{i},{j}]: ");
                // Corrección: Usamos int.Parse(Console.ReadLine())
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Fila a sumar (0-3): ");
        // Corrección: Usamos int.Parse(Console.ReadLine())
        int fila = int.Parse(Console.ReadLine());
        Console.WriteLine($"Suma de la fila {fila}: {SumaFila(matriz, fila)}");

        Console.Write("Columna a sumar (0-3): ");
        // Corrección: Usamos int.Parse(Console.ReadLine())
        int col = int.Parse(Console.ReadLine());
        Console.WriteLine($"Suma de la columna {col}: {SumaColumna(matriz, col)}");
    }

    static int SumaFila(int[,] m, int fila)
        {
            int suma = 0;
            for (int j = 0; j < 4; j++) suma += m[fila, j];
            return suma;
        }

        static int SumaColumna(int[,] m, int col)
        {
            int suma = 0;
            for (int i = 0; i < 4; i++) suma += m[i, col];
            return suma;
        }

        // EJERCICIO 2
        static void Ejercicio2()
        {
            Console.WriteLine("EJERCICIO 2:\n");
            float[,] matriz = new float[3, 5];

            // Procedimiento cargarMatriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Ingrese valor flotante [{i},{j}]: ");
                    matriz[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"El número mayor es: {MayorMatriz(matriz)}");
        }

        static float MayorMatriz(float[,] m)
        {
            float mayor = m[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (m[i, j] > mayor) mayor = m[i, j];
                }
            }
            return mayor;
        }

        // EJERCICIO 3
        static void Ejercicio3()
        {
            Console.WriteLine("EJERCICIO 3:\n");
            // Según la rúbrica: A(2x3) y B(3x2)
            int[,] A = new int[2, 3];
            int[,] B = new int[3, 2];

            Console.WriteLine("Llenar matriz A (2x3):");
            LlenarMatrizGenerica(A, 2, 3);

            Console.WriteLine("Llenar matriz B (3x2):");
            LlenarMatrizGenerica(B, 3, 2);

            int[,] R = Multiplicar(A, B);

            Console.WriteLine("Matriz Resultante R (2x2):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(R[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void LlenarMatrizGenerica(int[,] m, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int[,] Multiplicar(int[,] A, int[,] B)
        {
            int[,] R = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    R[i, j] = 0;
                    // Índice 'k' común para la multiplicación
                    for (int k = 0; k < 3; k++)
                    {
                        R[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return R;
        }

    
        // EJERCICIO 4
            static void Ejercicio4()
        {
            Console.WriteLine("EJERCICIO 4:\n");
            int[,] matriz = new int[5, 5];

            // Procedimiento llenar
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Valor [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Suma Diagonal Principal: {SumaDiagonalPrincipal(matriz)}");
            Console.WriteLine($"Suma Diagonal Secundaria: {SumaDiagonalSecundaria(matriz)}");
        }

        static int SumaDiagonalPrincipal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, i];
            }
            return suma;
        }

        static int SumaDiagonalSecundaria(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, 4 - i]; // 4 es el índice máximo (n-1)
            }
            return suma;
        }
    }