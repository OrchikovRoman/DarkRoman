using NUnit.Framework;
using QuadraticEquationLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestQuadraticEquationLibraryTests
{
    public class NUnitCheckZeroEquationTests
    {
        private QuadraticEquation _solutionQuadraticEquation;
        [SetUp]
        public void Setup()
        {
            _solutionQuadraticEquation = new QuadraticEquation();
        }

        [TestCase(10, 10)]
        [TestCase(-10, -10)]
        [TestCase(-10.0, -10.0)]
        [TestCase(10.0, 10.0)]
        [TestCase(double.MaxValue, double.MaxValue)]
        [TestCase(double.MinValue, double.MinValue)]
        public void NUnitCheckZeroEquation_Test(double num, double expected)
        {
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            Assert.AreEqual(expected, num);
        }
    }
}
