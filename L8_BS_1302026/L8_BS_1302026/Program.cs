using System;

class Program
{
    static void Main()
    {
        // Saludo inicial requerido
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        Console.WriteLine("\n-------------------------------------------------\n");

        // EJERCICIO 1: ANÁLISIS DE NOTAS
        Console.WriteLine(" EJERCICIO 1: ANÁLISIS DE NOTAS ");

        int aprobados = 0;
        int reprobados = 0;
        double sumaNotas = 0;

        // Se leen las 10 notas solicitadas usando un ciclo for
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese la nota del estudiante {i}: ");
            int nota = int.Parse(Console.ReadLine());
            sumaNotas += nota;

            // Determinar si aprueba con 61 o más
            if (nota >= 61)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = sumaNotas / 10;
        Console.WriteLine($"\nPromedio de la clase: {promedio}");
        Console.WriteLine($"Cantidad de aprobados: {aprobados}");
        Console.WriteLine($"Cantidad de reprobados: {reprobados}");

        Console.WriteLine("\n-------------------------------------------------\n");

        // EJERCICIO 2: RANGO DE NÚMEROS Y CONTEO
        Console.WriteLine(" EJERCICIO 2: RANGO DE NÚMEROS Y CONTEO ");

        Console.Write("Ingrese un número entero positivo: ");
        int numeroLimite = int.Parse(Console.ReadLine());

        int sumaRango = 0;
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= numeroLimite; i++)
        {
            sumaRango += i;

            // Validar si es par o impar usando el operador módulo (%)
            if (i % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine($"\nSuma de todos los números: {sumaRango}");
        Console.WriteLine($"Cantidad de números pares: {pares}");
        Console.WriteLine($"Cantidad de números impares: {impares}");

        Console.WriteLine("\n-------------------------------------------------\n");

        // EJERCICIO 3: MENÚ DE LA TIENDA
        Console.WriteLine(" EJERCICIO 3: MENÚ DE LA TIENDA ");

        int opcionTienda;
        double totalVentas = 0;
        int clientesAtendidos = 0;

        // Se usa do-while para garantizar que el menú se muestre al menos una vez
        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1) Registrar compra");
            Console.WriteLine("2) Mostrar total de ventas");
            Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4) Salir");
            Console.Write("Seleccione una opción: ");

            opcionTienda = int.Parse(Console.ReadLine());

            // Estructura switch para manejar cada opción del menú
            switch (opcionTienda)
            {
                case 1:
                    Console.Write("Ingrese el monto de la compra: Q");
                    double monto = double.Parse(Console.ReadLine());
                    totalVentas += monto;
                    clientesAtendidos++;
                    Console.WriteLine("Compra registrada con éxito.");
                    break;
                case 2:
                    Console.WriteLine($"Total acumulado de ventas: Q{totalVentas}");
                    break;
                case 3:
                    Console.WriteLine($"Clientes atendidos: {clientesAtendidos}");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del menú de la tienda...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcionTienda != 4);

        Console.WriteLine("\n-------------------------------------------------\n");

        // EJERCICIO 4: LECTURA DE NÚMEROS HASTA 0
        Console.WriteLine(" EJERCICIO 4: LECTURA DE NÚMEROS HASTA 0 ");

        int numIngresado;
        int totalNumeros = 0;
        int positivos = 0;
        int negativos = 0;
        int sumaTotal = 0;

        Console.WriteLine("Ingrese números (Ingrese 0 para terminar):");

        do
        {
            numIngresado = int.Parse(Console.ReadLine());

            // Solo procesamos el número si no es el cero que finaliza el ciclo
            if (numIngresado != 0)
            {
                totalNumeros++;
                sumaTotal += numIngresado;

                if (numIngresado > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }
        } while (numIngresado != 0); // El ciclo termina cuando se ingresa 0

        Console.WriteLine($"\nTotal de números ingresados: {totalNumeros}");
        Console.WriteLine($"Cantidad de números positivos: {positivos}");
        Console.WriteLine($"Cantidad de números negativos: {negativos}");
        Console.WriteLine($"Suma total: {sumaTotal}");

        Console.WriteLine("\n-------------------------------------------------\n");

        // EJERCICIO 5: FIGURA DE NÚMEROS
        Console.WriteLine(" EJERCICIO 5: FIGURA DE NÚMEROS ");

        Console.Write("Ingrese el tamaño de la figura (N): ");
        int n = int.Parse(Console.ReadLine());

        // Ciclos anidados para generar la figura
        for (int fila = 1; fila <= n; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write(columna);
            }
            Console.WriteLine(); // Salto de línea después de imprimir los números de la fila
        }


        // Pausa final para que la consola no se cierre automáticamente
        Console.ReadLine();
    }
}