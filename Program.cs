using ItlaProyec.Intefaces;
using ItlaProyec.LSP.Base;
using ItlaProyec.LSP;
using ItlaProyec.Models;
using ItlaProyec.OCP;
using ItlaProyec.Services;
using ItlaProyec.ISP.ConRefactoring.Interfaz;
using ItlaProyec.ISP.SinRefactoring.Interfaz;
using ItlaProyec.ISP.SinRefactoring;
using ItlaProyec.ISP.ConRefactoring;


//ISP
IAve2 loro = new Loro2();
loro.Cantar();
loro.PonerHuevos();
((IAveVoladora)loro).Volar();

IAve2 pinguino = new Pinguino2();
pinguino.Cantar();
pinguino.PonerHuevos();
((IAveNadadora)pinguino).Nadar();

IAve2 aguila = new Aguila2();
aguila.Cantar();
aguila.PonerHuevos();
((IAveVoladora)aguila).Volar();
((IAveCazadora)aguila).Cazar();


//LSP
FiguraGeometrica rectangulo1 = new  ItlaProyec.LSP.Rectangulo { Base = 4, Altura = 5 };
FiguraGeometrica cuadrado1 = new Cuadrado { Base = 4, Altura = 5 }; // Violación del LSP

Console.WriteLine($"Área del rectángulo: {rectangulo1.CalcularArea()}");
Console.WriteLine($"Área del cuadrado: {cuadrado1.CalcularArea()}"); // Esto falla al no ser un cuadrado.





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

















ItlaProyec.Models.Rectangulo rectangulo = new ItlaProyec.Models.Rectangulo(5, 10);
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
