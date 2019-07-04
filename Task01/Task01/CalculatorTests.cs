using NUnit.Framework;

namespace Task01
{
    [TestFixture]
    class CalculatorTests
    {
        Calculator instance;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            instance = new Calculator();
        }

        [Test]
        [TestCase(0, 12, ExpectedResult = 10)]
        [TestCase(-1, 1, ExpectedResult = 0)]
        [TestCase(0, 1, ExpectedResult = 1)]
        [TestCase(2147483647, 1, ExpectedResult = -2147483648)]
        [TestCase(-2147483648, 1, ExpectedResult = -2147483647)]
        public int AddingTest(int v1, int v2)
        {
            return instance.Add(v1, v2);
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(2147483647, 1, 2147483645)]
        [TestCase(2147483647, 1, 2147483646)]
        [TestCase(-2147483648, 1, 2147483647)]
        public void Subtract(int v1, int v2, int expected)
        {
            int result = instance.Subtruct(v1, v2);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in Subtract Test. Input: {v1} - {v2}.");
            });
        }
    }
}
