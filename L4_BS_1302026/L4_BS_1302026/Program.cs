using System;
using System.ComponentModel;
// Entrada de usuario
Console.Write("¿Cómo te llamas? ");
string nombre = Console.ReadLine();
// Salida de datos
Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
Console.WriteLine(" ");


//Comienzo de Ejercicio 1: Registro de Nave Espacial
Console.WriteLine("Ejercicio 1: Registro de Nave Espacial ");
Console.WriteLine(" ");

//1. Modelo (tipo texto)
Console.Write("Ingrese el modelo de la nave espacial: ");
string modeloNaveEspacial = Console.ReadLine();

//2. Capacidad de carga (tipo numérico)
Console.Write("Ingrese la capacidad de carga de la nave espacial (en toneladas): ");
int capacidadCarga = int.Parse(Console.ReadLine());

//3. Nivel de combustible (con decimales)
Console.Write("Nivel de Combustible (en litros):");
float nivelCombustible = float.Parse(Console.ReadLine());

//4. Motor de Salto Activo (tipo booleano)
Console.Write("¿El motor de salto está activo? (ture/false): ");
string motorSaltoActivo = Console.ReadLine();

Console.WriteLine(" ");

//5. Escribimos el mensaje
Console.WriteLine("Modelo Asignado de Nave Espacial: " + modeloNaveEspacial + ", " + "Capacidad de Carga: " + capacidadCarga + "(T), " + "Nivel de Combustible: " + nivelCombustible + "(L), " + "Estado Motor: " + motorSaltoActivo);
Console.WriteLine(" ");
Console.WriteLine(" ");



//Comienzo de Ejercicio 2:  Expansión de Memoria (Conversión Implícita)
Console.WriteLine("Ejercicio 2:  Expansión de Memoria (Conversión Implícita) ");
Console.WriteLine(" ");

//1. Declaramos una variable short sensoresActivos = 128
short sensoresActivos = 128;

//2. Declaramos una variable int registroProcesador

int registroProcesador;

//3. Asignamos el valor de sensoresActivos a registroProcesador
registroProcesador = sensoresActivos;

//4. Declaramos una variable double precisionTotal y asígnale el valor de registroProcesador
double precisionTotal = registroProcesador;

//5. Escribimos el mensaje
Console.WriteLine("Precisión Total detectada: " + precisionTotal);
Console.WriteLine(" ");
Console.WriteLine(" ");




//Comienzo de Ejercicio 3: Ajuste de Energía (Casting Explícito)
Console.WriteLine("Ejercicio 3: Ajuste de Energía (Casting Explícito) ");
Console.WriteLine(" ");

//1. Declaramos una variable double energiaGenerada = 987.65
double energiaGenerada = 987.65;

//2. Creamos una variable int energiaLimitada
int energiaLimitada;

//3. Usamos casting explícito (int) para pasar el valor de energiaGenerada a energiaLimitada
energiaLimitada = (int)energiaGenerada;

//4.Escribimos el mensaje cómo se pierden los decimales
Console.WriteLine("Energía Original: " + energiaGenerada);
Console.WriteLine("Energía Limitada (Truncada): " + energiaLimitada);
Console.WriteLine(" ");
Console.WriteLine(" ");




//Comienzo de Ejercicio 4: Recepción de Coordenadas (Parse)
Console.WriteLine("Ejercicio 4: Recepción de Coordenadas (Parse) ");
Console.WriteLine(" ");

//1.Soliciamos al usuario que ingrese la distancia al planeta más cercano
Console.Write("Ingrese la distancia al planeta más cercano (ej. 500): ");

//2.Guardamos la entrada en un string entradaRadar
string entradaRadar = Console.ReadLine();

//3. Convertimos el string a int usando int.Parse() 
int distanciaRadar = int.Parse(entradaRadar);

//4. Sumamos 100 unidades y mostramos el resultado final
int resultadoFinalRadar = distanciaRadar + 100;
Console.WriteLine("Distancia final con margen de seguridad: " + resultadoFinalRadar);
Console.WriteLine(" ");
Console.WriteLine(" ");




//Comienzo de Ejercicio 5: Panel de Control (Clase Convert)
Console.WriteLine("Ejercicio 5: Panel de Control (Clase Convert) ");
Console.WriteLine(" ");

//1. Declaramos el string señalOxigeno = "true" 
string señalOxigeno = "true";

//2. Convierte la señal a bool usando Convert.ToBoolean()
bool oxigenoActivo = Convert.ToBoolean(señalOxigeno);

//3. Declaramos el string temperaturaCabina = "22.8"
string temperaturaCabina = "22.8";

//4. Convertimos el texto a double usando Convert.ToDouble()
double temperaturaNum = Convert.ToDouble(temperaturaCabina);

//5. Mostramos ambos estados
Console.WriteLine("Estado de Oxígeno: " + oxigenoActivo + " | Temperatura: " + temperaturaNum + "°C");
Console.WriteLine(" ");
Console.WriteLine(" ");




//Comienzo de Ejercicio 6: Reporte de Misión (ToString y Formato)
Console.WriteLine("Ejercicio 6: Reporte de Misión (ToString y Formato) ");
Console.WriteLine(" ");

//1. Creamos una variable double velocidadLuz = 299792.458
double velocidadLuz = 299792.458;

//2. Convertimos la variable a string usando .ToString()
string velocidadTextoSimple = velocidadLuz.ToString();

//3. Usamos .ToString("N3") para separador de miles y 3 decimales
string velocidadFormateada = velocidadLuz.ToString("N3");

Console.WriteLine("Velocidad Simple: " + velocidadTextoSimple);
Console.WriteLine("Velocidad Formateada (N3): " + velocidadFormateada);
Console.WriteLine(" ");
Console.WriteLine(" ");




//Comienzo de Ejercicio 7: Reto Final - Calculadora de Suministros
Console.WriteLine("Ejercicio 7: Reto Final - Calculadora de Suministros ");
Console.WriteLine(" ");

//1. Solicitamos al usuario el Precio por Galón de Litio
Console.Write("Ingrese el precio por Galón de Litio: ");
string entradaPrecio = Console.ReadLine();

//2. Convertimos a double 
double precioGalon = Convert.ToDouble(entradaPrecio);

//3. Calculamos el Impuesto Galáctico (12%)
double impuesto = precioGalon * 0.12;

//4. Calculamos el Costo Total
double costoTotal = precioGalon + impuesto;

//5. Mostramos el total y 6. El requisito: X debe ser int (casting explícito)
int totalRedondeado = (int)costoTotal;

Console.WriteLine("El costo final de suministro es: $" + totalRedondeado);

