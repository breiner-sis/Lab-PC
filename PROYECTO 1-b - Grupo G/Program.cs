using System;

namespace SistemaParqueoSmartPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. DECLARACIÓN DE VARIABLES (Según Proyecto 1-a) 
            string nombreOperador = "", codTurno = "";
            int capacidadMax = 0;
            int ticketsCreados = 0, ticketsCerrados = 0, tiempoSimulado = 0, minutoEntrada = 0;
            double totalRecaudado = 0;
            bool existeTicketActivo = false;

            // Datos del vehículo actual
            string placaActiva = "", nombreCliente = "";
            int tipoVehiculo = 0;
            bool esVIP = false;

            // 2. CONFIGURACIÓN INICIAL (Validación obligatoria)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== CONFIGURACIÓN INICIAL SMARTPARK ===");
            Console.ResetColor();

            do
            {
                Console.Write("Ingrese nombre del operador: ");
                nombreOperador = Console.ReadLine();
                Console.Write("Ingrese código de turno (4 caracteres): ");
                codTurno = Console.ReadLine();
                Console.Write("Ingrese capacidad (mínimo 10): ");
                int.TryParse(Console.ReadLine(), out capacidadMax);

                if (codTurno.Length != 4 || capacidadMax < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: El código debe tener 4 caracteres y capacidad >= 10.");//Si no se cumple la capacidad minima de letras y capacidad máxima, se muestra un mensaje de error y se vuelve a solicitar la información. 
                    Console.ResetColor();
                }
            } while (codTurno.Length != 4 || capacidadMax < 10); 

            //  3. INICIALIZACIÓN de vairables en 0 
            ticketsCreados = 0;
            ticketsCerrados = 0;
            totalRecaudado = 0;
            tiempoSimulado = 0;
            existeTicketActivo = false;

            //  4. MENÚ PRINCIPAL (Ciclo) 
            string opcion = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"--- MENÚ SMARTPARK | Operador: {nombreOperador} | Tiempo: {tiempoSimulado} min ---");
                Console.ResetColor();
                Console.WriteLine("A. Crear Ticket de Entrada");
                Console.WriteLine("B. Registrar Salida y Cobrar");
                Console.WriteLine("C. Ver Estado del Parqueo");
                Console.WriteLine("D. Simular Paso del Tiempo");
                Console.WriteLine("E. Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = Console.ReadLine().ToUpper();

                switch (opcion)
                {
                    case "A":
                        if (!existeTicketActivo && (ticketsCreados - ticketsCerrados) < capacidadMax)
                        {
                            do
                            {
                                Console.Write("Placa (6-8 caracteres, sin espacios): ");
                                placaActiva = Console.ReadLine();
                            } while (placaActiva.Length < 6 || placaActiva.Length > 8 || placaActiva.Contains(" "));

                            Console.Write("Tipo (1:Moto, 2:Auto, 3:Pickup): ");
                            int.TryParse(Console.ReadLine(), out tipoVehiculo);
                            Console.Write("Nombre del cliente: ");
                            nombreCliente = Console.ReadLine();
                            Console.Write("¿Es VIP? (S/N): ");
                            esVIP = Console.ReadLine().ToUpper() == "S";

                            minutoEntrada = tiempoSimulado;
                            existeTicketActivo = true;
                            ticketsCreados++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ticket creado exitosamente.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No se puede crear ticket (Parqueo lleno o ya hay uno activo).");
                        }
                        break;

                    case "B":
                        if (existeTicketActivo)
                        {
                            int minutosEstacionados = tiempoSimulado - minutoEntrada; 
                            double tarifaHora = (tipoVehiculo == 1) ? 5 : (tipoVehiculo == 2) ? 10 : 15; // 

                            // Cálculo por fracción de hora: (minutos + 59) / 60
                            int horasACobrar = (minutosEstacionados + 59) / 60; 
                            double subtotal = horasACobrar * tarifaHora;

                            if (minutosEstacionados <= 15) subtotal = 0; // Gratuidad 

                            double multa = (minutosEstacionados > 360) ? 25 : 0; // Multa > 6 horas 
                            double totalFinal = subtotal + multa;

                            if (esVIP) totalFinal *= 0.90; // Descuento VIP

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nRECIBO: {placaActiva} | Cobro: Q{totalFinal:F2}");
                            totalRecaudado += totalFinal;
                            ticketsCerrados++;
                            existeTicketActivo = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: No hay ticket activo.");
                        }
                        break;

                    case "C":
                        Console.WriteLine("\n--- ESTADO ACTUAL ---");
                        Console.WriteLine($"Espacios: {capacidadMax - (existeTicketActivo ? 1 : 0)} disponibles de {capacidadMax}");
                        Console.WriteLine($"Recaudado: Q{totalRecaudado:F2} | Tiempo: {tiempoSimulado} min");
                        break;

                    case "D":
                        Console.Write("Minutos a avanzar (1-1440): ");
                        if (int.TryParse(Console.ReadLine(), out int m) && m >= 1 && m <= 1440)
                        {
                            tiempoSimulado += m;
                        }
                        break;
                }

                if (opcion != "E")
                {
                    Console.ResetColor();
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != "E"); 

            // 5. RESUMEN FINAL
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== RESUMEN FINAL DEL TURNO ===");
            Console.WriteLine($"Operador: {nombreOperador} | Total Recaudado: Q{totalRecaudado:F2}");
            Console.ResetColor();
        }
    }
}