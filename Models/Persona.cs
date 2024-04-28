

namespace ItlaProyec.Models;

/*
Al incluir  EnviarCorreo() en la clase Persona, 
estás mezclando la lógica de manipulación de datos.
Esta función ImprimirDatos() se encarga de imprimir 
los datos de la persona, 
lo cual es otra responsabilidad. 
Sin embargo, al estar dentro de la misma clase Persona, 
estás añadiendo más de una responsabilidad para que la clase cambie.
 */
//codigo violacioletando el principio de SRP 
/*public class Persona
{
    private string nombre;
    private int edad;
    private string direccion;
    private string correo;

    public void EnviarCorreo(string mensaje)
    {

    }
    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Direccion: {direccion}");
        Console.WriteLine($"Correo: {correo}");
    }
}*/

public class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string direccion { get; set; }
    public string correo { get; set; }

}