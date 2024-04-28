

using ItlaProyec.Intefaces;

namespace ItlaProyec.Services;

public class CorreoServices: ICorreoServices
{
    public void EnviarCorreo(string mensaje)
    {
        Console.WriteLine($"Enviando correo  -- {mensaje}");
    }
}
