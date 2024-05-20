
using ItlaProyec.LSP.Base;

namespace ItlaProyec.LSP;

public class Rectangulo: FiguraGeometrica
{
    public override decimal CalcularArea()
    {
        return Base * Altura;
    }
}
