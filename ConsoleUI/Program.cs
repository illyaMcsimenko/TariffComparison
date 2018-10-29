using System.Collections.Generic;
using TariffComparison.Core;
using static System.Console;

namespace TariffComparison.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = (IEnumerable<Product>)new List<Product> {
                new Product { Id = 1, Name = "Basic", CostCalculator=new BasicTariffCalculator() },
                new Product { Id = 2, Name = "Packaged", CostCalculator=new PackagedTariffCalculator() } };

            var tariffСomparer = new TariffСomparer();

            for (int i = 0; i <= 8000; i += 1000)
            {
                Write("Consumption: {0} kWh/year ", i);
                var SortedList = tariffСomparer.SortByAnnualConsumption(list, i);

                var iterator = SortedList.GetEnumerator();
                iterator.MoveNext();

                Write("{0} (Annual cost: {1}) better than ", iterator.Current.Name, iterator.Current.CostCalculator.CalculateAnnualCost(i));
                iterator.MoveNext();
                WriteLine("{0} (Annual cost: {1}) ", iterator.Current.Name, iterator.Current.CostCalculator.CalculateAnnualCost(i));
            }
            ReadLine();
        }
    }
}