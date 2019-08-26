using NUnit.Framework;

namespace Task01
{
    [Category("String Tests")]
    [Description("")]
    class StringTests
    {
        [TestCase("particular")]
        public void ParticularTest(string testData)
        {
            Assert.Contains("part", testData);
        }
    }
}
