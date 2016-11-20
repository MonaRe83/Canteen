using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanteenFoodOrdering;

namespace CanteenUnitTesting
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void PriceTest()
        {
            Product product = new Product("Banana", 3.50f);

            Assert.IsTrue(product.ToString() == "Banana - $3.50");

        }
    }
}
