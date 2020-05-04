using NUnit.Framework;
using QuadraticEquationLibrary;
using System;
using System.Collections;
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
        public void NUnitCheckZeroEquation_TestCases(double num, double expected)
        {
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            Assert.AreEqual(expected, num);
        }


        [Test]
        [TestCaseSource(typeof(MyCheckZeroClass), "TestCases")]
        public double NUnitCheckZeroEquation_Test(double num)
        {
            double result = default(double);
            Assert.DoesNotThrow(() =>
            {
                result = _solutionQuadraticEquation.CheckZeroNumbers(num);
            });
            return result;
        }
    }
    public class MyCheckZeroClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(10).Returns(10);
                yield return new TestCaseData(-10).Returns(-10);
                yield return new TestCaseData(10.0).Returns(10.0);
                yield return new TestCaseData(-10.0).Returns(-10.0);
            }
        }
    }
}
