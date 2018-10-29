using System.Collections.Generic;

namespace TariffComparison.Core
{
    public interface ITariffСomparer
    {
        IEnumerable<Product> SortByAnnualConsumption(IEnumerable<Product> products, int annualConsumption);
    }
}
