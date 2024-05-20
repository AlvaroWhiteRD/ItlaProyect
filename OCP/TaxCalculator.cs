using ItlaProyec.OCP.Interfaces;

namespace ItlaProyec.OCP;

public class TaxCalculator
{
    private readonly IDictionary<string, ITax> _tax;
    public TaxCalculator()
    {
        _tax = new Dictionary<string, ITax>
        {
            { "India", new IndiaTax() },
            { "USA", new UsaTax() },
            { "RD", new RdTax() }
        };
    }
    public decimal Calculate(decimal income, decimal deduction, string country)
    {
        if (!_tax.ContainsKey(country))
        {
            throw new NotImplementedException($"El impuesto para el país '{country}' no está implementada.");
        }

        decimal taxableIncome = income - deduction;
        ITax taxStrategy = _tax[country];
        return taxStrategy.CalculateTax(taxableIncome);
    }
}
