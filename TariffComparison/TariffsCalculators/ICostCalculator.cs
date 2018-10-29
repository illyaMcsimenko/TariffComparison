namespace TariffComparison.Core
{
    public interface ICostCalculator
    {
        decimal CalculateAnnualCost(int annualConsumption);
    }
}
