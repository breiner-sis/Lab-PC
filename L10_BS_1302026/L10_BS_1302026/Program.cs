using System;

class Program
{
    static void Main()
    {
        
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        // 1: Suma de Dígitos
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("1: Parámetros por Valor - Suma de dígitos\n");
        Console.Write("Introduce un número entero (positivo): ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Entrada no válida.");
            return;
        }
        int resultado = SumarDigitos(numero);
        Console.WriteLine($"La suma de los dígitos de {numero} es: {resultado}");



        // 2: Parámetro por Referencia
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("2: Parámetros por Referencia - Cuadrado\n");
        Console.Write("Introduce un número para elevar al cuadrado: ");
        if (int.TryParse(Console.ReadLine(), out int numRef))
        {
            string mensaje = ElevarAlCuadrado(ref numRef);
            Console.WriteLine($"{mensaje} El resultado es = {numRef}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }


        // 3: Integración (Valor y Referencia)
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("3: Descuentos Dinámicos\n");

        Console.Write("Introduce el precio del producto: ");
        double.TryParse(Console.ReadLine(), out double precioProducto);

        Console.Write("Introduce el porcentaje de descuento (ej. 0.25): ");
        double.TryParse(Console.ReadLine(), out double descuentoPorcentaje);

        Console.WriteLine($"[Antes] Precio = {precioProducto}, descuento = {descuentoPorcentaje}");

        // Llamada a la función combinada
        double montoDescontado = AplicarDescuento(descuentoPorcentaje, ref precioProducto);

        Console.WriteLine($"[Después] Precio final = {precioProducto}, Descuento aplicado = {montoDescontado}");


        // 4: Funciones de Videojuego
        // ---------------------------------------------------------
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("4: Sistema de Energía del Jugador\n");

        Console.Write("Introduce la energía inicial del jugador (0 al 20): ");
        if (int.TryParse(Console.ReadLine(), out int energiaJugador))
        {
            Console.WriteLine($"\n-> Estado inicial: {obtenerEstado(energiaJugador)} | Rendimiento: {calcularRendimiento(energiaJugador)}");

            // Acción 1: Consumir
            Console.WriteLine("\n¡El jugador realizó una acción y consumió energía!");
            consumirEnergia(ref energiaJugador);
            Console.WriteLine($"Energía actual: {energiaJugador} | Nuevo Estado: {obtenerEstado(energiaJugador)}");

            // Acción 2: Recargar
            Console.WriteLine("\n¡El jugador recogió una poción y recargó energía!");
            recargarEnergia(ref energiaJugador);
            Console.WriteLine($"Energía final: {energiaJugador} | Estado final: {obtenerEstado(energiaJugador)} | Rendimiento: {calcularRendimiento(energiaJugador)}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }

        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }


    // DECLARACIÓN DE LAS FUNCIONES (El "Contexto" que faltaba)

    // Función 1
    static int SumarDigitos(int n)
    {
        n = Math.Abs(n);
        int suma = 0;
        while (n > 0)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma;
    }

    // Función 2
    static string ElevarAlCuadrado(ref int numero)
    {
        numero = numero * numero;
        return "Operación realizada.";
    }

    // Función 3
    static double AplicarDescuento(double porcentaje, ref double precio)
    {
        double descuentoApli = precio * porcentaje;
        precio = precio - descuentoApli;
        return descuentoApli;
    }

    // Funciones 4
    static int consumirEnergia(ref int energia)
    {
        energia -= 4;
        if (energia < 0) energia = 0;
        return energia;
    }

    static int recargarEnergia(ref int energia)
    {
        energia += 6;
        if (energia > 20) energia = 20;
        return energia;
    }

    static string obtenerEstado(int energia)
    {
        if (energia >= 15 && energia <= 20) return "Alta";
        if (energia >= 8 && energia <= 14) return "Media";
        return "Baja";
    }

    static string calcularRendimiento(int energia)
    {
        if (energia == 20) return "S";
        if (energia >= 15 && energia <= 19) return "A";
        if (energia >= 8 && energia <= 14) return "B";
        return "C";
    }
}