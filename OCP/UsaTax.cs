using ItlaProyec.OCP.Interfaces;

namespace ItlaProyec.OCP;

public class UsaTax : ITax
{
    public decimal CalculateTax(decimal taxableIncome)
    {
        decimal taxAmount = 0;

        if (taxableIncome <= 5)
        {
            taxAmount = 0;
        }
        else
        {
            taxAmount = (taxableIncome - 5) * 5;
        }

        return taxAmount;
    }
}
