using ItlaProyec.OCP.Interfaces;

namespace ItlaProyec.OCP;

public class RdTax : ITax
{
    public decimal CalculateTax(decimal taxableIncome)
    {
        decimal taxAmount = 0;

        if (taxableIncome <= 6)
        {
            taxAmount = 0;
        }
        else
        {
            taxAmount = (taxableIncome - 6) * 2;
        }

        return taxAmount;
    }
}
