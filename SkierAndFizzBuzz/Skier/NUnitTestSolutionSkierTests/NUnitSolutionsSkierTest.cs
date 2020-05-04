using NUnit.Framework;
using SkierLibrary;

namespace NUnitTestSolutionSkierTests
{
    public class NUnitSolutionsSkierTest
    {
        private SolutionSkier _solutionSkier;
        [SetUp]
        public void Setup()
        {
            _solutionSkier = new SolutionSkier();
        }

        [TestCase (1,2,100, 101)]
        [TestCase(10, 1, 100, 87)]
        [TestCase(0, 1, 100, 103)]
        [TestCase(0, 0, 100, 0)]
        [TestCase(0, 5, 20, 23)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(-1, 2, 100, 105)]
        [TestCase(1, -2, 100, 0)]
        public void NUnitSolutionSkier(double distX, double growthY, double targetZ, double expected)
        {
            double result = _solutionSkier.Solution(distX, growthY, targetZ);
            Assert.AreEqual(expected, result);
        }
    }
}