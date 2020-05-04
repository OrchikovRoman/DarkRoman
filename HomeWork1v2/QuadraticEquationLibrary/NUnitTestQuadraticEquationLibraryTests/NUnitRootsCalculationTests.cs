using NUnit.Framework;
using QuadraticEquationLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestQuadraticEquationLibraryTests
{
    public class NUnitRootsCalculationTests
    {
        private QuadraticEquation _solutionQuadraticEquation;
        [SetUp]
        public void Setup()
        {
            _solutionQuadraticEquation = new QuadraticEquation();
        }

        [TestCase(2, 4, 1, -1.7071067811865475, -0.2928932188134524)]
        [TestCase(3, 18, 27, -3, 0)]
        [TestCase(1, 3, 4, 0, 0)]
        [TestCase(1, 1, 10, 0,0)]
        [TestCase(10, 1, 1, 0, 0)]
        [TestCase(1, 10, 1, -9.898979485566356, -0.10102051443364424)]
        public void NUnitRootsCalculation_TestCases(double a, double b, double c, double expX1, double expX2)
        {
            double x1, x2;
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }
    }
}
