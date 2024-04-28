using ItlaProyec.BaseModels;

namespace ItlaProyec.Models;

class Rectangulo : Figura
{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }

    public Rectangulo(double lado1, double lado2)
    {
        Lado1 = lado1;
        Lado2 = lado2;
    }

    public override double CalcularArea()
    {
        return Lado1 * Lado2;
    }
}

