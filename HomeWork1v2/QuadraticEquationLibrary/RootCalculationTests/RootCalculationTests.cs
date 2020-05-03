using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadraticEquationLibrary;

namespace RootCalculationTests
{
    [TestClass]
    public class RootCalculationTests
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
        public void RootCalculation_Test_Two_roots()
        {
            //1.Preparation
            double a = 2;
            double b = 4;
            double c = 1;
            double x1;
            double x2;

            double expX1 = -1.7071067811865475;
            double expX2 = -0.2928932188134524;

            //2.Execution
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);

            //3.Assertion
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }

        [TestMethod]
        public void RootCalculation_Test_One_root()
        {
            //1.Preparation
            double a = 3;
            double b = 18;
            double c = 27;
            double x1;
            double x2;

            double expX1 = -3;
            double expX2 = 0;

            //2.Execution
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);

            //3.Assertion
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }

        [TestMethod]
        public void RootCalculation_Test_No_roots()
        {
            //1.Preparation
            double a = 1;
            double b = 3;
            double c = 4;
            double x1;
            double x2;

            double expX1 = 0;
            double expX2 = 0;

            //2.Execution
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);

            //3.Assertion
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }
        [TestMethod]
        public void RootCalculation_Test_1_1_10()
        {
            //1.Preparation
            double a = 1;
            double b = 1;
            double c = 10;
            double x1;
            double x2;

            double expX1 = 0;
            double expX2 = 0;

            //2.Execution
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);

            //3.Assertion
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }

        [TestMethod]
        public void RootCalculation_Test_10_1_1()
        {
            //1.Preparation
            double a = 10;
            double b = 1;
            double c = 1;
            double x1;
            double x2;

            double expX1 = 0;
            double expX2 = 0;

            //2.Execution
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);

            //3.Assertion
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }

        [TestMethod]
        public void RootCalculation_Test_1_10_1()
        {
            //1.Preparation
            double a = 1;
            double b = 10;
            double c = 1;
            double x1;
            double x2;

            double expX1 = -9.898979485566356;
            double expX2 = -0.10102051443364424;

            //2.Execution
            _solutionQuadraticEquation.RootCalculation(ref a, ref b, ref c, out x1, out x2);

            //3.Assertion
            Assert.AreEqual(x1, expX1);
            Assert.AreEqual(x2, expX2);
        }
    }
}
