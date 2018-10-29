namespace TariffComparison.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICostCalculator CostCalculator { get; set; }
    }
}
