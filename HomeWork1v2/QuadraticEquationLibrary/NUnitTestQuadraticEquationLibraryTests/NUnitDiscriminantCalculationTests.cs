using NUnit.Framework;
using System;
using QuadraticEquationLibrary;
using System.Collections;

namespace NUnitTestQuadraticEquationLibraryTests
{
    public class NUnitDiscriminantCalculationTests
    {
        private QuadraticEquation _solutionQuadraticEquation;
        [SetUp]
        public void Setup()
        {
            _solutionQuadraticEquation = new QuadraticEquation();
        }

        [TestCase(2, 4, 1, 8)]
        [TestCase(2, 2, 2, -12)]
        [TestCase(1, 1, 1, -3)]
        [TestCase(1, 2, 1, 0)]
        [TestCase(1, 1, 2, -7)]
        [TestCase(-1, 1, -10, -39)]
        public void NUnitDiscriminantCalculation_TestCases(double a, double b, double c, double expected)
        {
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            Assert.AreEqual(expected, D);
        }

        [Test]
        [TestCaseSource(typeof(MyDiscriminantClass), "TestCases")]
        public double NUnitDiscriminantCalculation_Test(double a, double b, double c)
        {
            double result = default(double);
            Assert.DoesNotThrow(() =>
            {
                result = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            });
            return result;
        }
    }
    public class MyDiscriminantClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(2, 4, 1).Returns(8);
                yield return new TestCaseData(2, 2, 2).Returns(-12);
                yield return new TestCaseData(1, 1, 1).Returns(-3);
                yield return new TestCaseData(1, 2, 1).Returns(0);
                yield return new TestCaseData(1, 1, 2).Returns(-7);
                yield return new TestCaseData(-1, 1, -10).Returns(-39);
            }
        }
    }
}