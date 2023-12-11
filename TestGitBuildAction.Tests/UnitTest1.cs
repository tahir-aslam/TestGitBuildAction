using NUnit.Framework;

namespace TestGitBuildAction.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 2, 4)]
        [TestCase(10, 10, 20)]
        [TestCase(20, 20, 40)]
        [TestCase(200, 200, 400)]
        [TestCase(250, 250, 500)]
        public void Add(int a, int b, int result)
        {
            int expected = a + b;

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, 2, 4)]
        [TestCase(10, 10, 100)]
        [TestCase(20, 20, 400)]
        public void Multiply(int a, int b, int result)
        {
            int expected = a * b;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}