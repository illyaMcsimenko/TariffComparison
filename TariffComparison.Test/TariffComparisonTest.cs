using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TariffComparison.Core;

namespace TariffComparison.Test
{
    [TestClass]
    public class TariffComparisonTest
    {
        [TestMethod]
        public void AProfitableThenBLow()
        {
            var tariffComparison = new TariffСomparer();
            var products = InitializeProducts();
            var consumption = 3350;

            var productsList = new List<Product>(
                tariffComparison.SortByAnnualConsumption(products, consumption));

            Assert.AreEqual(productsList[0].Id, 1);
            Assert.AreEqual(productsList[1].Id, 2);
        }

        [TestMethod]
        public void BProfitableThenA()
        {
            var tariffComparison = new TariffСomparer();
            var products = InitializeProducts();
            var consumption = 3500;

            var productsList = new List<Product>(
                tariffComparison.SortByAnnualConsumption(products, consumption));

            Assert.AreEqual(productsList[0].Id, 2);
            Assert.AreEqual(productsList[1].Id, 1);
        }

        [TestMethod]
        public void AProfitableThenBHigh()
        {
            var tariffComparison = new TariffСomparer();
            var products = InitializeProducts();
            var consumption = 5800;

            var productsList = new List<Product>(
                tariffComparison.SortByAnnualConsumption(products, consumption));

            Assert.AreEqual(productsList[0].Id, 1);
            Assert.AreEqual(productsList[1].Id, 2);
        }

        [TestMethod]
        public void BasicTariffCalculatorCostConsumption1000()
        {
            var BasicTariffCalculator = new BasicTariffCalculator();
            int consumption = 1000;

            decimal cost = BasicTariffCalculator.CalculateAnnualCost(consumption);

            Assert.AreEqual(cost, 280);
        }

        [TestMethod]
        public void PackagedTariffCalculatorCostConsumption1000()
        {
            var BasicTariffCalculator = new PackagedTariffCalculator();
            int consumption = 1000;

            decimal cost = BasicTariffCalculator.CalculateAnnualCost(consumption);

            Assert.AreEqual(cost, 800);

        }

        [TestMethod]
        public void BasicTariffCalculatorCostConsumption4000()
        {
            var BasicTariffCalculator = new BasicTariffCalculator();
            int consumption = 4000;

            decimal cost = BasicTariffCalculator.CalculateAnnualCost(consumption);

            Assert.AreEqual(cost, 940);
        }

        [TestMethod]
        public void PackagedTariffCalculatorCostConsumption4000()
        {
            var BasicTariffCalculator = new PackagedTariffCalculator();
            int consumption = 4000;

            decimal cost = BasicTariffCalculator.CalculateAnnualCost(consumption);

            Assert.AreEqual(cost, 800);
        }

        private IEnumerable<Product> InitializeProducts() => new List<Product> {
                new Product { Id = 1, Name = "Basic", CostCalculator=new BasicTariffCalculator() },
                new Product { Id = 2, Name = "Packaged", CostCalculator=new PackagedTariffCalculator()  } };

    }
}
