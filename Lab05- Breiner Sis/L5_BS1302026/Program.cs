


//EJERCICIO 1: PANEL DE ACCESO
Console.WriteLine(" EJERCICIO 1: PANEL DE ACCESO ");
int idUsuario, pinUsuario, tokenSeguridad, modoSeguro;

Console.Write("ID de usuario: ");
idUsuario = int.Parse(Console.ReadLine());
if (idUsuario == 2026) Console.WriteLine("Usuario reconocido.");
else Console.WriteLine("Usuario no reconocido.");

Console.Write("PIN: ");
pinUsuario = int.Parse(Console.ReadLine());
if (pinUsuario == 1234) Console.WriteLine("PIN correcto.");
else Console.WriteLine("PIN incorrecto.");

Console.Write("Token: ");
tokenSeguridad = int.Parse(Console.ReadLine());
if (tokenSeguridad == 777) Console.WriteLine("Token válido.");
else Console.WriteLine("Token inválido.");

Console.Write("Modo seguro (1=Si, 0=No): ");
modoSeguro = int.Parse(Console.ReadLine());
if (modoSeguro == 1) Console.WriteLine("Modo seguro activado: se aplican reglas extra.");
else Console.WriteLine("Modo seguro desactivado.");

if (idUsuario == 2026 && pinUsuario == 1234 && tokenSeguridad == 777)
    Console.WriteLine("Acceso total concedido.");
else Console.WriteLine("Acceso denegado.");

if (modoSeguro == 1)
{
    if (tokenSeguridad >= 700) Console.WriteLine("Regla extra aprobada.");
    else Console.WriteLine("Regla extra fallida.");
}

Console.WriteLine("\n-------------------------------------------------\n");



//  EJERCICIO 2: VALIDADOR DE PIN 
Console.WriteLine(" EJERCICIO 2: VALIDADOR DE PIN ");
Console.Write("Ingrese su PIN: ");
int pinInput = int.Parse(Console.ReadLine());

if (pinInput >= 1000 && pinInput <= 9999) Console.WriteLine("PIN de 4 dígitos: OK.");
else Console.WriteLine("PIN inválido: debe tener 4 dígitos.");

if (pinInput % 2 == 0) Console.WriteLine("PIN par.");
else Console.WriteLine("PIN impar.");

if (pinInput % 5 == 0) Console.WriteLine("Múltiplo de 5.");
else Console.WriteLine("No es múltiplo de 5.");

if ((pinInput >= 1000 && pinInput <= 9999) && (pinInput % 2 == 0) && (pinInput % 5 != 0))
    Console.WriteLine("PIN aceptado por política.");
else Console.WriteLine("PIN rechazado por política.");

Console.WriteLine("\n-------------------------------------------------\n");



//  EJERCICIO 3: ACTIVACION 
Console.WriteLine(" EJERCICIO 3: ACTIVACION DE CUENTA ");
Console.Write("Código de activación: ");
int codAct = int.Parse(Console.ReadLine());
Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());
Console.Write("Aceptó términos (1/0): ");
int terminos = int.Parse(Console.ReadLine());
Console.Write("Activó 2FA (1/0): ");
int fa2 = int.Parse(Console.ReadLine());
Console.Write("Puntaje (0-100): ");
int puntaje = int.Parse(Console.ReadLine());

if (codAct == 2026) Console.WriteLine("Código correcto.");
else Console.WriteLine("Código incorrecto.");

if (edad >= 18) Console.WriteLine("Edad válida.");
else Console.WriteLine("Edad no válida.");

if (terminos == 1) Console.WriteLine("Términos aceptados.");
else Console.WriteLine("Debe aceptar términos.");

if (fa2 == 1) Console.WriteLine("2FA activado.");
else Console.WriteLine("2FA no activado.");

if (puntaje >= 70) Console.WriteLine("Puntaje suficiente.");
else Console.WriteLine("Puntaje insuficiente.");

if (codAct == 2026 && edad >= 18 && terminos == 1 && fa2 == 1 && puntaje >= 70)
    Console.WriteLine("Cuenta activada exitosamente.");
else Console.WriteLine("Cuenta NO activada.");

Console.WriteLine("\n-------------------------------------------------\n");




//  RETO FINAL: SALA DE EXAMEN 
Console.WriteLine(" RETO FINAL: ACCESO A SALA ");
Console.Write("Nota previa: ");
int nota = int.Parse(Console.ReadLine());
Console.Write("Minutos de retraso: ");
int tarde = int.Parse(Console.ReadLine());
Console.Write("Solvencia (1/0): ");
int solvencia = int.Parse(Console.ReadLine());
Console.Write("Identificación física (1/0): ");
int idFisica = int.Parse(Console.ReadLine());
Console.Write("Calculadora (1/0): ");
int calc = int.Parse(Console.ReadLine());

if (nota >= 61) Console.WriteLine("Requisito académico aprobado.");
else Console.WriteLine("Requisito académico NO aprobado.");

if (tarde <= 10) Console.WriteLine("Hora válida.");
else Console.WriteLine("Llegada tarde: fuera de tiempo.");

if (solvencia == 1) Console.WriteLine("Solvencia validada.");
else Console.WriteLine("Sin solvencia.");

if (idFisica == 1) Console.WriteLine("Identificación validada.");
else Console.WriteLine("Sin identificación.");

if (calc == 1) Console.WriteLine("Calculadora permitida: OK.");
else Console.WriteLine("Sin calculadora permitida.");

if (nota >= 61 && tarde <= 10 && solvencia == 1 && idFisica == 1)
    Console.WriteLine("Acceso a sala de examen concedido.");
else Console.WriteLine("Acceso denegado.");

if (tarde > 0 && tarde <= 10)
    Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar.");

Console.WriteLine("\n-------------------------------------------------\n");

//  BONUS: SAN VALENTIN 
Console.WriteLine(" BONUS: SAN VALENTÍN ");
Console.Write("Nombre: ");
string nombre = Console.ReadLine();
Console.Write("Valentía (0-100): ");
int val = int.Parse(Console.ReadLine());
Console.Write("¿Le gusta programación? (1/0): ");
int progra = int.Parse(Console.ReadLine());
Console.Write("¿Le gustan memes técnicos? (1/0): ");
int memes = int.Parse(Console.ReadLine());
Console.Write("Nivel de interés (0-100): ");
int inte = int.Parse(Console.ReadLine());
Console.Write("¿Está soltero? (1/0): ");
int soltero = int.Parse(Console.ReadLine());

if (inte >= 70) Console.WriteLine("Interés alto detectado.");
else Console.WriteLine("Interés insuficiente.");

if (val >= 70) Console.WriteLine("Valentía favorable.");
else Console.WriteLine("Nivel de valentía bajo.");

if (soltero == 1) Console.WriteLine("Estado sentimental favorable.");
else Console.WriteLine("Estado sentimental comprometido.");

if (progra == 1 && memes == 1) Console.WriteLine("Compatibilidad geek detectada.");
else Console.WriteLine("Compatibilidad parcial o inexistente.");

if (inte >= 70 && soltero == 1 && progra == 1 && memes == 1 && val >= 70)
    Console.WriteLine("DECLARACIÓN APROBADA. Proceder con chocolates y flores.");
else if (inte >= 70 && soltero == 1 && progra == 1 && memes == 1 && val < 70)
    Console.WriteLine("No le tenga miedo al éxito que vida solo hay 1.");
else
    Console.WriteLine(nombre + ", no te ama.. por ahora.");