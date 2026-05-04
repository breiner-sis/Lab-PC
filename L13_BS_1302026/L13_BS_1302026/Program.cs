using System;

namespace L13_BS_1302026
{
   // EJERCICIO 1 - CLASE PERSONA 
   // Definimos la plantilla para crear objetos Persona con sus respectivos atributos.
    class Persona
    {
        public string nombre;
        public int edad;
        public double altura;
        public bool estudiante;
    }

    // EJERCICIO 2 - CLASE VEHICULO
    class Vehiculo
    {
        public string marca;
        public string modelo;
        public int anio;
        public string color;
        public string placa;
    }

    // EJERCICIO 3 - CLASE PRODUCTO
    class Producto
    {
        public string codigo;
        public string nombre;
        public double precio;
        public int stock;
        public bool disponible;
    }

    // EJERCICIO 4 - CLASE MASCOTA
    class Mascota
    {
        public string nombre;
        public string especie;
        public int edad;
        public double peso;
        public bool vacunado;
    }

    
    // CLASE PRINCIPAL
    class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1: PERSONA
            Console.WriteLine("EJERCICIO 1: PERSONA");
            // 1. Creación e instanciación del objeto
            Persona persona1 = new Persona();

            // 2. Asignación de valores a los atributos
            persona1.nombre = "Carlos Perez";
            persona1.edad = 20;
            persona1.altura = 1.75;
            persona1.estudiante = true;

            // 3. Impresión de los atributos
            Console.WriteLine("Nombre: " + persona1.nombre);
            Console.WriteLine("Edad: " + persona1.edad + " años");
            Console.WriteLine("Altura: " + persona1.altura + " m");
            Console.WriteLine("Es estudiante: " + persona1.estudiante);
            Console.WriteLine();


            // EJERCICIO 2: VEHICULO
            Console.WriteLine("EJERCICIO 2: VEHICULO");
            Vehiculo miAuto = new Vehiculo();

            miAuto.marca = "Toyota";
            miAuto.modelo = "Corolla";
            miAuto.anio = 2022;
            miAuto.color = "Gris Plata";
            miAuto.placa = "P-123ABC";

            Console.WriteLine("Marca: " + miAuto.marca);
            Console.WriteLine("Modelo: " + miAuto.modelo);
            Console.WriteLine("Año: " + miAuto.anio);
            Console.WriteLine("Color: " + miAuto.color);
            Console.WriteLine("Placa: " + miAuto.placa);
            Console.WriteLine();

            // EJERCICIO 3: PRODUCTO
            // Requiere crear DOS objetos diferentes porque se pide comparar su información
            Console.WriteLine("EJERCICIO 3: PRODUCTO");

            // Creación del primer objeto
            Producto prod1 = new Producto();
            prod1.codigo = "A001";
            prod1.nombre = "Laptop Dell";
            prod1.precio = 7500.50;
            prod1.stock = 15;
            prod1.disponible = true;

            // Creación del segundo objeto
            Producto prod2 = new Producto();
            prod2.codigo = "A002";
            prod2.nombre = "Mouse Inalámbrico";
            prod2.precio = 150.00;
            prod2.stock = 0;
            prod2.disponible = false;

            // Se muestra la información de ambos productos para comparar
            Console.WriteLine("Producto 1: " + prod1.nombre + " (Cód: " + prod1.codigo + ") - Precio: Q" + prod1.precio + " - Stock: " + prod1.stock);
            Console.WriteLine("Producto 2: " + prod2.nombre + " (Cód: " + prod2.codigo + ") - Precio: Q" + prod2.precio + " - Stock: " + prod2.stock);
            Console.WriteLine();

            // EJERCICIO 4: MASCOTA
            Console.WriteLine("EJERCICIO 4: MASCOTA");
            Mascota miMascota = new Mascota();

            miMascota.nombre = "Firulais";
            miMascota.especie = "Perro";
            miMascota.edad = 3;
            miMascota.peso = 12.5;
            miMascota.vacunado = true;

            Console.WriteLine("Nombre: " + miMascota.nombre);
            Console.WriteLine("Especie: " + miMascota.especie);
            Console.WriteLine("Edad: " + miMascota.edad + " años");
            Console.WriteLine("Peso: " + miMascota.peso + " kg");
            Console.WriteLine("Vacunado: " + miMascota.vacunado);
            Console.WriteLine();

            // Evitar que la consola se cierre inmediatamente
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}