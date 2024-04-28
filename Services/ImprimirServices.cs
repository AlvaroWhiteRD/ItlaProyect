

using ItlaProyec.Intefaces;
using ItlaProyec.Models;

namespace ItlaProyec.Services;

public class ImprimirServices: IImprimirServices
{
    public void ImprimirDatos(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.nombre}");
        Console.WriteLine($"Edad: {persona.edad}");
        Console.WriteLine($"Direccion: {persona.direccion}");
        Console.WriteLine($"Correo: {persona.correo}");
    }
}
