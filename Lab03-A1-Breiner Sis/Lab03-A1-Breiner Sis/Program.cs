using System;

namespace Lab03_A1_Breiner_Sis
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- PASO 1: SOLICITUD DE DATOS ---

            Console.Write("Por favor, ingresa tu nombre: ");
            // Declaramos la variable 'nombreEstudiante' y guardamos lo que el nombre del estudiante
            string nombreEstudiante = Console.ReadLine();

            Console.Write("¿Cuál es el nombre de tu curso actual?: ");
            // Declaramos la variable 'nombreCurso' para el curso que el estudiante está tomando y guardamos lo que el estudiante ingresa
            string nombreCurso = Console.ReadLine();

            // --- PASO 2: MOSTRAR RESULTADOS ---
            // Usamos una línea en blanco para que se vea ordenado
            Console.WriteLine();

            // Mostramos los datos y el mensaje personalizado en diferentes líneas
            Console.WriteLine("Resultado del Registro:");
            Console.WriteLine("Estudiante: " + nombreEstudiante);
            Console.WriteLine("Curso registrado: " + nombreCurso);

            // Mensaje personalizado
            Console.WriteLine("¡Felicidades " + nombreEstudiante + "! Estás dando tus primeros pasos en " + nombreCurso + ".");
            Console.WriteLine("El camino de un Ingeniero no es fácil, pero lo lograrás.  ¡sigue adelante!");

            // --- PASO 3: FINALIZACIÓN ---
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey(); // Detiene la ejecución hasta que se presione cualquier tecla
        }
    }
}