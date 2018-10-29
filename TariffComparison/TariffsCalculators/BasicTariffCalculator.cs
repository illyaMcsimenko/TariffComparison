namespace TariffComparison.Core
{
    public class BasicTariffCalculator : ICostCalculator
    {
        public decimal CalculateAnnualCost(int annualConsumption) =>
           annualConsumption * (decimal)0.22 + 60;
    }
}
