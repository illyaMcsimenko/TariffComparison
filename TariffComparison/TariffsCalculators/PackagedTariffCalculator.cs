namespace TariffComparison.Core
{
    public class PackagedTariffCalculator : ICostCalculator
    {
        public decimal CalculateAnnualCost(int annualConsumption) =>
            annualConsumption <= 4000 ? 800 :
            (annualConsumption - 4000) * (decimal)0.3 + 800;
    }
}
