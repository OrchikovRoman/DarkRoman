using NUnit.Framework;
using SkierLibrary;
using System;
using System.Collections;

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

        [Test]
        [TestCaseSource(typeof(MyFactoryClass), "TestCases")]
        public double NUnitSolutionSkier(double distX, double growthY, double targetZ)
        {
            double result = default(double);
            Assert.DoesNotThrow(() =>
            {
                result = _solutionSkier.Solution(distX, growthY, targetZ);
            });
            return result;
        }

        [TestCase(1, 2, 100, 101)]
        [TestCase(10, 1, 100, 87)]
        [TestCase(0, 1, 100, 0)]
        [TestCase(0, 0, 100, 0)]
        [TestCase(0, 5, 20, 0)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(-1, 2, 100, 0)]
        [TestCase(1, -2, 100, 0)]
        public void NUnitSolutionSkierTestCases(double distX, double growthY, double targetZ, double expected)
        {
            double result = _solutionSkier.Solution(distX, growthY, targetZ);
            Assert.AreEqual(expected, result);
        }
    }

    public class MyFactoryClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1, 2, 100).Returns(101);
                yield return new TestCaseData(10, 1, 100).Returns(87);
                yield return new TestCaseData(0, 1, 100).Returns(0);
                yield return new TestCaseData(0, 0, 100).Returns(0);
                yield return new TestCaseData(0, 5, 20).Returns(0);
                yield return new TestCaseData(0, 0, 0).Returns(0);
                yield return new TestCaseData(-1, 2, 100).Returns(0);
                yield return new TestCaseData(1, -2, 100).Returns(0);
            }
        }
    }
}