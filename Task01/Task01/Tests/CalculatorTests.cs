using NUnit.Framework;

namespace Task01
{
    [TestFixture(Category = "Calculator")]
    class CalculatorTests
    {
        Calculator instance;

        [SetUp]
        public void SetUp()
        {
            instance = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            instance = null;
        }

        //static List<int> list = new List<int>()
        //{
        //   1, 2 ,3
        //};


        //[Test, TestCaseSource("list")]
        //public void Tes(int value)
        //{

        //}

        [Test]
        [TestCase(0, 12, ExpectedResult = 10)]
        [TestCase(-1, 1, ExpectedResult = 0)]
        [TestCase(0, 1, ExpectedResult = 1)]
        [TestCase(2147483647, 1, ExpectedResult = -2147483648)]
        [TestCase(-2147483648, 1, ExpectedResult = -2147483647)]
        public int AddTest(int v1, int v2)
        {
            return instance.Add(v1, v2);
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(2147483647, 1, 2147483645)]
        [TestCase(2147483647, 1, 2147483646)]
        [TestCase(-2147483648, 1, 2147483647)]
        public void SubtractTest(int v1, int v2, int expected)
        {
            int result = instance.Subtruct(v1, v2);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(System.Int32), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in Subtract Test. Input: {v1} - {v2}.");
            });
        }

        [Test]
        [TestCase(0, 100, 0)]
        [TestCase(2147483647, 1, 2147483647)]
        [TestCase(-2147483648, 1, -2147483648)]
        [TestCase(0, 0, 0)]
        public void MultipleTest(int v1, int v2, int expected)
        {
            int result = instance.Multiple(v1, v2);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(System.Int32), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in Multiple Test. Input: {v1} * {v2}.");
            });
        }

        [Test]
        [TestCase(0, 100, 0)]
        [TestCase(-1, -1, 1)]
        [TestCase(2147483647, 2147483647, 1)]
        [TestCase(-2147483647, 2147483647, -1)]
        [TestCase(0, 0, 0)]
        public void DevideTest(int v1, int v2, int expected)
        {
            double result = instance.Multiple(v1, v2);
            Assert.Multiple(() =>
            {
                Assert.NotNull(result);
                Assert.IsNotNull(result);
                Assert.IsInstanceOf(typeof(System.Double), result);
                Assert.AreEqual(expected, result,
                    $"Get unexpected result in Devide Test. Input: {v1} / {v2}.");
            });
        }
    }
}
