using System;

namespace GestionGranja
{
    public class Parcela
    {
        public string TipoCultivo { get; set; }
        public int MesesCrecimiento { get; set; }
        public int MesesRequeridos { get; set; }
        public int IngresoCosecha { get; set; }
        public bool RegadaEsteMes { get; set; }

        public Parcela()
        {
            TipoCultivo = "Vacía";
            MesesCrecimiento = 0;
            MesesRequeridos = 0;
            IngresoCosecha = 0;
            RegadaEsteMes = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- BIENVENIDO A LA GESTIÓN DE GRANJA --- ");

            // 1. Configuración Inicial
            int dinero = PedirEnteroValido("Ingrese la cantidad de dinero inicial: Q");
            int numEmpleados = PedirEnteroValido("Ingrese número de empleados: ");
            int sueldoEmpleado = PedirEnteroValido("Ingrese sueldo por empleado: Q");
            int meses = PedirEnteroValido("Ingrese cantidad de meses a simular: ");
            int filas = PedirEnteroValido("Ingrese la cantidad de filas para la granja: ");
            int columnas = PedirEnteroValido("Ingrese la cantidad de columnas para la granja: ");

            // Variables para el reporte final
            int totalIngresos = 0;
            int totalEgresos = 0;
            int riegosRealizados = 0;
            int papasSembradas = 0, tomatesSembrados = 0, fresasSembradas = 0;
            int papasCosechadas = 0, tomatesCosechados = 0, fresasCosechadas = 0;
            int mesesSimuladosTotal = 0;

            // 2. Inicialización de la Matriz
            Parcela[,] granja = new Parcela[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    granja[i, j] = new Parcela();
                }
            }

            int opcion = 0;

            // 3. Ciclo Principales del Menú
            while (meses > 0 && dinero > 0 && opcion != 5)
            {
                Console.WriteLine($"\n--- MESES RESTANTES: {meses} | DINERO: Q{dinero} ---");
                Console.WriteLine("1. Sembrar");
                Console.WriteLine("2. Regar Parcelas");
                Console.WriteLine("3. Consultar parcela");
                Console.WriteLine("4. Avanzar de mes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: // OPCIÓN 1: SEMBRAR
                            Console.WriteLine("\n--- SEMBRAR ---");
                            int fSiembra = PedirEnteroValido("Fila (1 a " + filas + "): ") - 1;
                            int cSiembra = PedirEnteroValido("Columna (1 a " + columnas + "): ") - 1;

                            if (fSiembra >= 0 && fSiembra < filas && cSiembra >= 0 && cSiembra < columnas)
                            {
                                Parcela p = granja[fSiembra, cSiembra];
                                if (p.TipoCultivo == "Vacía")
                                {
                                    Console.WriteLine(" \n Opciones a sembrar: 1. Papa (2 meses) | 2. Tomate (3 meses) | 3. Fresa (4 meses)");
                                    int tipo = PedirEnteroValido("Seleccione cultivo: ");

                                    p.MesesCrecimiento = 0;
                                    p.RegadaEsteMes = false;

                                    if (tipo == 1) { p.TipoCultivo = "Papa"; p.MesesRequeridos = 2; p.IngresoCosecha = 450; papasSembradas++; }
                                    else if (tipo == 2) { p.TipoCultivo = "Tomate"; p.MesesRequeridos = 3; p.IngresoCosecha = 650; tomatesSembrados++; }
                                    else if (tipo == 3) { p.TipoCultivo = "Fresa"; p.MesesRequeridos = 4; p.IngresoCosecha = 900; fresasSembradas++; }
                                    else { Console.WriteLine("Opción de cultivo no válida. Se cancela siembra."); continue; }

                                    Console.WriteLine($"Se ha sembrado {p.TipoCultivo} con éxito.");
                                }
                                else
                                {
                                    Console.WriteLine("Error: La parcela ya está ocupada.");
                                }
                            }
                            else { Console.WriteLine("Coordenadas fuera de límite."); }
                            break;

                        case 2: // OPCIÓN 2: REGAR
                            Console.WriteLine("\n--- REGAR ---");
                            int fRiego = PedirEnteroValido("Fila (1 a " + filas + "): ") - 1;
                            int cRiego = PedirEnteroValido("Columna (1 a " + columnas + "): ") - 1;

                            if (fRiego >= 0 && fRiego < filas && cRiego >= 0 && cRiego < columnas)
                            {
                                Parcela p = granja[fRiego, cRiego];
                                if (p.TipoCultivo == "Vacía") Console.WriteLine("No se puede regar una parcela vacía.");
                                else if (p.RegadaEsteMes) Console.WriteLine("La parcela ya fue regada este mes.");
                                else if (dinero < 40) Console.WriteLine("Fondos insuficientes para regar (Q40).");
                                else
                                {
                                    dinero -= 40;
                                    totalEgresos += 40;
                                    p.RegadaEsteMes = true;
                                    riegosRealizados++;
                                    Console.WriteLine("Parcela regada. Se descontaron Q40.");
                                }
                            }
                            else { Console.WriteLine("Coordenadas fuera de límite."); }
                            break;

                        case 3: // OPCIÓN 3: CONSULTAR
                            Console.WriteLine("\n--- CONSULTAR ---");
                            int fConsulta = PedirEnteroValido("Fila (1 a " + filas + "): ") - 1;
                            int cConsulta = PedirEnteroValido("Columna (1 a " + columnas + "): ") - 1;

                            if (fConsulta >= 0 && fConsulta < filas && cConsulta >= 0 && cConsulta < columnas)
                            {
                                Parcela p = granja[fConsulta, cConsulta];
                                if (p.TipoCultivo == "Vacía")
                                {
                                    Console.WriteLine("La parcela se encuentra vacía y disponible para siembra.");
                                }
                                else
                                {
                                    Console.WriteLine($"Tipo de cultivo: {p.TipoCultivo}");
                                    Console.WriteLine($"Crecimiento: {p.MesesCrecimiento}/{p.MesesRequeridos} meses");
                                    string estadoRiego = p.RegadaEsteMes ? "Sí" : "No";
                                    Console.WriteLine($"Regada este mes: {estadoRiego}");
                                }
                            }
                            else { Console.WriteLine("Coordenadas fuera de límite."); }
                            break;

                        case 4: // OPCIÓN 4: AVANZAR MES
                            Console.WriteLine("\n--- AVANZANDO DE MES ---");
                            meses--;
                            mesesSimuladosTotal++;

                            // Pago a empleados
                            int pagoNomina = numEmpleados * sueldoEmpleado;
                            dinero -= pagoNomina;
                            totalEgresos += pagoNomina;
                            Console.WriteLine($"Se pagó Q{pagoNomina} a los empleados.");

                            // Simular crecimiento y cosechas
                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    Parcela p = granja[i, j];
                                    if (p.TipoCultivo != "Vacía")
                                    {
                                        // Aumenta 2 meses si se regó, 1 mes si no
                                        int avance = p.RegadaEsteMes ? 2 : 1;
                                        p.MesesCrecimiento += avance;
                                        p.RegadaEsteMes = false; // Reinicio de riego

                                        if (p.MesesCrecimiento >= p.MesesRequeridos)
                                        {
                                            dinero += p.IngresoCosecha;
                                            totalIngresos += p.IngresoCosecha;
                                            Console.WriteLine($"¡Cosecha lista en [{i + 1},{j + 1}]! Se recolectó {p.TipoCultivo} (+Q{p.IngresoCosecha}).");

                                            // Contabilizar cosecha para el reporte
                                            if (p.TipoCultivo == "Papa") papasCosechadas++;
                                            else if (p.TipoCultivo == "Tomate") tomatesCosechados++;
                                            else if (p.TipoCultivo == "Fresa") fresasCosechadas++;

                                            // Vaciar la parcela tras cosechar
                                            p.TipoCultivo = "Vacía";
                                            p.MesesCrecimiento = 0;
                                            p.MesesRequeridos = 0;
                                            p.IngresoCosecha = 0;
                                        }
                                    }
                                }
                            }

                            if (dinero <= 0) Console.WriteLine("\n¡ALERTA! Te has quedado sin fondos. Bancarrota.");
                            if (meses <= 0) Console.WriteLine("\n¡El tiempo de simulación ha terminado!");
                            break;

                        case 5: // OPCIÓN 5: SALIR
                            Console.WriteLine("\nFinalizando simulación a petición del usuario...");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Intente con un número del 1 al 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor, ingrese un formato numérico válido.");
                }
            }

            // 4. Reporte Final
            // Contar parcelas vacías restantes
            int parcelasVaciasFin = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (granja[i, j].TipoCultivo == "Vacía") parcelasVaciasFin++;
                }
            }

            Console.WriteLine("\n--- REPORTE FINAL ---");
            Console.WriteLine($"Dinero final: Q{dinero}");
            Console.WriteLine($"Total de ingresos: Q{totalIngresos}");
            Console.WriteLine($"Total de egresos: Q{totalEgresos}");
            Console.WriteLine($"Meses simulados: {mesesSimuladosTotal}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("CANTIDAD SEMBRADA:");
            Console.WriteLine($"- Papas: {papasSembradas} | Tomates: {tomatesSembrados} | Fresas: {fresasSembradas}");
            Console.WriteLine("CANTIDAD COSECHADA:");
            Console.WriteLine($"- Papas: {papasCosechadas} | Tomates: {tomatesCosechados} | Fresas: {fresasCosechadas}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Cantidad total de riegos realizados: {riegosRealizados}");
            Console.WriteLine($"Cantidad de parcelas vacías al finalizar: {parcelasVaciasFin}");
            Console.WriteLine("===============================================\n");
        }

        static int PedirEnteroValido(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.WriteLine("Error: Dato incorrecto. Debe ingresar un número entero mayor a 0.");
                Console.Write(mensaje);
            }
            return valor;
        }
    }
}