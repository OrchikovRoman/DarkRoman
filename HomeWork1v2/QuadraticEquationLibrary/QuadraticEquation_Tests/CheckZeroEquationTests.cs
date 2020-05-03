using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadraticEquationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation_Tests
{
    [TestClass]
    public class CheckZeroNumbersTests
    {
        private QuadraticEquation _solutionQuadraticEquation;

        [TestInitialize]
        public void BeforeAll()
        {
            _solutionQuadraticEquation = new QuadraticEquation();
        }


        [TestMethod]
        public void CheckZeroNumbers_Tests_10()
        {
            //1.Preparation
            double num = 10;

            //2.Execution
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            //3.Assertion
            Assert.AreEqual(10, exp);
        }

        [TestMethod]
        public void CheckZeroNumbers_Tests_minus10()
        {
            //1.Preparation
            double num = -10;

            //2.Execution
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            //3.Assertion
            Assert.AreEqual(-10, exp);
        }

        [TestMethod]
        public void CheckZeroNumbers_Tests_minusDouble10()
        {
            //1.Preparation
            double num = -10.0;

            //2.Execution
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            //3.Assertion
            Assert.AreEqual(-10.0, exp);
        }

        [TestMethod]
        public void CheckZeroNumbers_Tests_Double10()
        {
            //1.Preparation
            double num = 10.0;

            //2.Execution
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            //3.Assertion
            Assert.AreEqual(10.0, exp);
        }

        [TestMethod]
        public void CheckZeroNumbers_Tests_MaxValue()
        {
            //1.Preparation
            double num = double.MaxValue;

            //2.Execution
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            //3.Assertion
            Assert.AreEqual(double.MaxValue, exp);
        }

        [TestMethod]
        public void CheckZeroNumbers_Tests_MinValue()
        {
            //1.Preparation
            double num = double.MinValue;

            //2.Execution
            double exp = _solutionQuadraticEquation.CheckZeroNumbers(num);
            //3.Assertion
            Assert.AreEqual(double.MinValue, exp);
        }
    }
}
