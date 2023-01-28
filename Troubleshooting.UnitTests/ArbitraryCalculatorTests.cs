using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Troubleshooting.UnitTests
{
    [TestClass]
    public class ArbitraryCalculatorTests
    {
        [TestMethod]
        public void SetsStartingNumber()
        {
            // Arrange & Act
            ArbitraryCalculator testCalculator = new ArbitraryCalculator(5);

            // Assert
            Assert.AreEqual(5, testCalculator.StartingNumber);
        }

        [TestMethod]
        public void GetsResult()
        {
            // Arrange
            ArbitraryCalculator testCalculator = new ArbitraryCalculator(5);

            // Act
            int result = testCalculator.Calculate(82364257, 59);

            // Assert
            Assert.AreEqual(29, result);
        }

        [TestMethod]
        public void GetsLastResultDoubledProperty()
        {
            // Arrange
            ArbitraryCalculator testCalculator = new ArbitraryCalculator(5);

            // Act
            int result = testCalculator.Calculate(82364246, 62);

            // Assert
            Assert.AreEqual(58, testCalculator.LastResultDoubled);
        }

        [TestMethod]
        public void ChecksNumberOfOperations()
        {
            // Arrange
            ArbitraryCalculator testCalculator = new ArbitraryCalculator(5);

            // Act
            int testResult = testCalculator.Calculate(31266867, 143569);

            // Assert
            Assert.AreEqual(5, testCalculator.NumberOfCalculations);
        }
    }
}