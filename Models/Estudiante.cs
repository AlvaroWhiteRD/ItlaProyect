using ItlaProyec.BaseModels;

namespace ItlaProyec.BaseModels;

class Estudiante : Persona
{
    public string Carrera { get; set; }
    public int Matricula { get; set; }

    public Estudiante(string nombre, int edad, string ciudad, string carrera, int matricula)
        : base(nombre, edad, ciudad)
    {
        Carrera = carrera;
        Matricula = matricula;
    }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Carrera: {Carrera}, Matrícula: {Matricula}");
    }

    public int CalcularEdad()
    {
        return base.CalcularEdad(DateTime.Now);
    }
}

