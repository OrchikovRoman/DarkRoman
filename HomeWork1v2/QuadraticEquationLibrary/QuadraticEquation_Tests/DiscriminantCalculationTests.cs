using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadraticEquationLibrary;

namespace QuadraticEquation_Tests
{
    [TestClass]
    public class DiscriminantCalculationTests
    {
        private QuadraticEquation _solutionQuadraticEquation;
        
        [TestInitialize]
        public void BeforeAll()
        {
            _solutionQuadraticEquation = new QuadraticEquation();
        }
        [TestCleanup]
        public void AfterAll()
        {
            _solutionQuadraticEquation.Dispose();
        }

        [TestMethod]
        public void DiscriminantCalculation_Test_2_4_1()
        {
            //1.Preparation
            double a = 2;
            double b = 4;
            double c = 1;
            //2.Execution
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            //3.Assertion
            Assert.AreEqual(8, D);
        }

        [TestMethod]
        public void DiscriminantCalculation_Test_2_2_2()
        {
            //1.Preparation
            double a = 2;
            double b = 2;
            double c = 2;
            //2.Execution
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            //3.Assertion
            Assert.AreEqual(-12, D);
        }

        [TestMethod]
        public void DiscriminantCalculation_Test_1_1_1()
        {
            //1.Preparation
            double a = 1;
            double b = 1;
            double c = 1;
            //2.Execution
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            //3.Assertion
            Assert.AreEqual(-3, D);
        }
        [TestMethod]
        public void DiscriminantCalculation_Test_1_2_1()
        {
            //1.Preparation
            double a = 1;
            double b = 2;
            double c = 1;
            //2.Execution
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            //3.Assertion
            Assert.AreEqual(0, D);
        }
        [TestMethod]
        public void DiscriminantCalculation_Test_1_1_2()
        {
            //1.Preparation
            double a = 1;
            double b = 1;
            double c = 2;
            //2.Execution
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            //3.Assertion
            Assert.AreEqual(-7, D);
        }
        [TestMethod]
        public void DiscriminantCalculation_Test_minus1_1_minus10()
        {
            //1.Preparation
            double a = -1;
            double b = 1;
            double c = -10;
            //2.Execution
            double D = _solutionQuadraticEquation.DiscriminantCalculation(a, b, c);
            //3.Assertion
            Assert.AreEqual(-39, D);
        }
    }
}
