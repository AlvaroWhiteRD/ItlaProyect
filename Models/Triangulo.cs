﻿using ItlaProyec.BaseModels;

namespace ItlaProyec.Models;

class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura / 2;
    }
}
