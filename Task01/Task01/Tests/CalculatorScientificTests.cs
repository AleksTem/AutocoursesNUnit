using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Task01
{
    [TestFixture(Category = "ScientificCalculator")]
    [Description("Scientific calculator test fixture")]
    class CalculatorScientificTests
    {
        CalculatorScientific instance;

        [SetUp]
        public void SetUp()
        {
            instance = new CalculatorScientific();
        }

        [TearDown]
        public void TearDown()
        {
            instance = null;
        }

        [TestCase(0, -1, ExpectedResult = Double.PositiveInfinity)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(0, 1, ExpectedResult = 0)]
        [TestCase(-1, 1, ExpectedResult = -1)]
        [TestCase(0, 0, ExpectedResult = 1)]
        [TestCase(2147483647, 1, ExpectedResult = 2147483647)]
        [TestCase(-2147483648, 1, ExpectedResult = -2147483648)]
        public double PowTest(int v1, int v2)
        {
            return instance.Pow(v1, v2);
        }

        [TestCase(1, 1, 0.01)]
        [TestCase(2147483647, 10, 21474836.47)]
        [TestCase(2147483647, 1, 2147483646)]
        [TestCase(100, 50, 50)]
        public void PercentTest(int v1, int v2, double expected)
        {
            var result = instance.Percent(v1, v2);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(System.Double), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in {TestContext.CurrentContext.Test.Name} Test.");
            });
        }

        [Timeout(1)]
        [Repeat(10000)]
        [TestCase(0, 0)]
        [TestCase(Double.MinValue, -Double.MinValue)]
        [TestCase(Double.MaxValue, Double.MaxValue)]
        [TestCase(-1, 1)]
        public void ModTest(double v1, double expected)
        {
            var result = instance.Mod(v1);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(double), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in {TestContext.CurrentContext.Test.Name} Test.");
            });
        }

        [Test, Repeat(3)]
        [Description("Verify that the sum of provided list is exactly equal to expected")]
        public void GetListSumTest()
        {
            var request = new List<double>() { 1, 5, 15, 87, 9, 54 };
            var expected = 171;
            double result = instance.GetListSum(request);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(System.Double), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in {TestContext.CurrentContext.Test.Name} Test. ");
            });
        }

        [MaxTime(60), TestCase(28, new double[] { 1, 2, 3, 4, 5, 6, 7 })]
        [Retry(3), TestCase(28, new double[] { 1.89, 45.56, 3, 4.5, 5, 6.23, 7, 15.43, 52, 544.6, 54.55, 54.24, 47 })]
        [Description("Test with data provided from outer")]
        public void GetListSumWithDataProvidedTest(double expected, double[] testData)
        {
            double result = instance.GetListSum(testData);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(System.Double), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in {TestContext.CurrentContext.Test.Name} Test. ");
            });
        }
    }
}
