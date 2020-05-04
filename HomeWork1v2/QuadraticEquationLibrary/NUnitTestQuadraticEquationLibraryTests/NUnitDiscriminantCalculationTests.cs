using NUnit.Framework;
using System;
using QuadraticEquationLibrary;

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
        public void NUnitDiscriminantCalculation_Test(double a, double b, double c, double expected)
        {
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            Assert.AreEqual(expected, D);
        }
    }
}