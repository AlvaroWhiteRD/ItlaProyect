using ItlaProyec.OCP.Interfaces;

namespace ItlaProyec.OCP;

public class IndiaTax : ITax
{
    public decimal CalculateTax(decimal taxableIncome)
    {
        decimal taxAmount = 0;

        if (taxableIncome <= 10)
        {
            taxAmount = 0;
        }
        else
        {
            taxAmount = (taxableIncome - 10) * 3;
        }

        return taxAmount;
    }
}
