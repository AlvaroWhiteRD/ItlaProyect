using ItlaProyec.Intefaces;
using ItlaProyec.Models;
using ItlaProyec.OCP;
using ItlaProyec.Services;

//OCP
TaxCalculator calculator = new TaxCalculator();

decimal income = 100;
decimal deduction = 20;
string country = "RD";

decimal taxAmount = calculator.Calculate(income, deduction, country);

Console.WriteLine($"El monto del impuesto para {country} es: {taxAmount}");





Persona persona = new Persona
{
    nombre = "Alvaro",
    edad = 30,
    direccion = "123 Calle Principal",
    correo = "juan@example.com"
};


ICorreoServices correoService = new CorreoServices();
IImprimirServices imprimirServices = new ImprimirServices();

correoService.EnviarCorreo("Hola, este es el correo");
imprimirServices.ImprimirDatos(persona);

















Rectangulo rectangulo = new Rectangulo(5, 10);
Circulo circulo = new Circulo(3);
Triangulo triangulo = new Triangulo(4, 6);

// Calcular áreas
double areaRectangulo = rectangulo.CalcularArea();
double areaCirculo = circulo.CalcularArea();
double areaTriangulo = triangulo.CalcularArea();


// Mostrar resultados
Console.WriteLine($"Área del rectángulo: {areaRectangulo}");
Console.WriteLine($"Área del círculo: {areaCirculo}");
Console.WriteLine($"Área del triángulo: {areaTriangulo}");
