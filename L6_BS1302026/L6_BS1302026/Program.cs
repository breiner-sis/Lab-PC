using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;//se usta UTF8 para que se pueda reconocer el simbolo de euro (€) en la consola

        // --- SECCIÓN DE BIENVENIDA ---
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
        Console.WriteLine("\n-------------------------------------------------\n");


        // EJERCICIO 1: CLASIFICACIÓN DE VEHÍCULOS
        Console.WriteLine(" EJERCICIO 1: CLASIFICACIÓN DE VEHÍCULOS ");
        Console.WriteLine("1: Bicicleta, 2: Motocicleta, 3: Auto, 4: Camión, 5: Autobús");
        Console.Write("Ingrese su tipo de vehículo: ");
        int tipoV = int.Parse(Console.ReadLine());

        // Estructura múltiple para clasificar según el tipo ingresado
        switch (tipoV)
        {
            case 1:
                Console.WriteLine("Clasificación: Bicicleta -> No motorizado");
                break;
            case 2:
                Console.WriteLine("Clasificación: Motocicleta -> Ligero");
                break;
            case 3:
                Console.WriteLine("Clasificación: Auto -> Mediano");
                break;
            case 4:
                Console.WriteLine("Clasificación: Camión -> Pesado");
                break;
            case 5:
                Console.WriteLine("Clasificación: Autobús -> Transporte público");
                break;
            default:
                // Si se selecciona una opción fuera del rango permitido, se muestra un mensaje de error (mensaje por defecto)
                Console.WriteLine("Error: El número ingresado no está en el rango permitido.");
                break;
        }

        Console.WriteLine("\n-------------------------------------------------\n");


        // EJERCICIO 2: AUMENTO DE CRÉDITO
        Console.WriteLine(" EJERCICIO 2: AUMENTO DE LÍMITE DE CRÉDITO ");
        Console.Write("Ingrese su límite de crédito actual: ");
        double limiteActual = double.Parse(Console.ReadLine());
        Console.Write("Ingrese tipo de tarjeta (1, 2, 3 u otro): ");
        int tipoT = int.Parse(Console.ReadLine());

        double aumento;
        // Determinamos el porcentaje según el tipo de tarjeta
        switch (tipoT)
        {
            case 1:
                aumento = 0.25; // 25% de aumento
                break;
            case 2:
                aumento = 0.35; // 35% de aumento
                break;
            case 3:
                aumento = 0.40; // 40% de aumento
                break;
            default:
                aumento = 0.50; // 50% para cualquier otro tipo
                break;
        }

        double nuevoLimite = limiteActual + (limiteActual * aumento);
        Console.WriteLine("Aumento aplicado: " + (aumento * 100) + "%");
        Console.WriteLine("Nuevo límite de crédito: Q" + nuevoLimite);

        Console.WriteLine("\n-------------------------------------------------\n");


        // EJERCICIO 3: EVALUACIÓN DE EMPLEADOS
        Console.WriteLine(" EJERCICIO 3: EVALUACIÓN ANUAL ");
        Console.Write("Ingrese puntuación (0.0, 0.4, 0.6 o más): ");
        double puntos = double.Parse(Console.ReadLine());

        // Validamos que los puntos sean los permitidos
        if (puntos == 0.0 || puntos == 0.4 || puntos >= 0.6)
        {
            string nivel = "";
            if (puntos == 0.0) nivel = "Inaceptable";
            else if (puntos == 0.4) nivel = "Aceptable";
            else nivel = "Meritorio"; // Para 0.6 o más

            double bono = 2400 * puntos; // Cálculo del beneficio
            Console.WriteLine("Nivel de rendimiento: " + nivel);
            Console.WriteLine("Incentivo recibido: " + bono + "€");
        }
        else
        {
            Console.WriteLine("Puntuación inválida: No se permiten valores intermedios.");
        }

        Console.WriteLine("\n-------------------------------------------------\n");


        // EJERCICIO 4: PIZZERÍA BELLA NAPOLI
        Console.WriteLine(" EJERCICIO 4: CONFIGURACIÓN DE PIZZA ");
        Console.Write("¿Desea pizza vegetariana? (1=Si, 0=No): ");
        int opcionVeg = int.Parse(Console.ReadLine());

        string tipoPizza = "";
        string ingredienteExtra = "";

        // Estructura anidada para seleccionar ingredientes según el tipo de pizza
        if (opcionVeg == 1)
        {
            tipoPizza = "Vegetariana";
            Console.WriteLine("Ingredientes: 1. Pimiento, 2. Tofu");
            Console.Write("Seleccione uno: ");
            int ing = int.Parse(Console.ReadLine());
            ingredienteExtra = (ing == 1) ? "Pimiento" : "Tofu";
        }
        else
        {
            tipoPizza = "No Vegetariana";
            Console.WriteLine("Ingredientes: 1. Peperoni, 2. Jamón, 3. Salmón");
            Console.Write("Seleccione un ingrediente: ");
            int ing = int.Parse(Console.ReadLine());

            switch (ing)
            {
                case 1: ingredienteExtra = "Peperoni"; break;
                case 2: ingredienteExtra = "Jamón"; break;
                case 3: ingredienteExtra = "Salmón"; break;
                default: ingredienteExtra = "No seleccionado/Inválido"; break;
            }
        }

        // Resultado final con todos los ingredientes
        Console.WriteLine("\nResumen de orden:");
        Console.WriteLine("Tipo de pizza: " + tipoPizza);
        Console.WriteLine("Ingredientes: Mozzarella, Tomate y " + ingredienteExtra);

        Console.WriteLine("\n-------------------------------------------------\n");
        Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}