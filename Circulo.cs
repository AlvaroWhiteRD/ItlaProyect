using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItlaProyec;


class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}
