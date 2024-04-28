using ItlaProyec.Models;

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
