using System;
using System.Collections.Generic;
using System.Linq;

namespace TariffComparison.Core
{
    public class TariffСomparer : ITariffСomparer
    {
        public IEnumerable<Product> SortByAnnualConsumption(IEnumerable<Product> products, int annualConsumption) =>
            products?.OrderBy(x => x.CostCalculator?.CalculateAnnualCost(annualConsumption));
        
    }
}
