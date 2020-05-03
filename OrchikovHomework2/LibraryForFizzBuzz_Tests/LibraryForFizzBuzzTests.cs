using System;
using LibraryForFizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForFizzBuzzTests
{
    [TestClass]
    public class LibraryForFizzBuzzTests
    {
        [TestInitialize]
        public void BeforeAll()
        {
            var fizzBuzzLib = new SolutionFizzBuzz();
        }

        [TestMethod]
        public void CheckFirstFinishPoint_Test_1_100()
        {
            //1.Preparation
            int startPoint = 1;
            int finishPoint = 100;

            int expStartPoint = 1;
            int expFinishPoint = 100;
            //2.Execution
            SolutionFizzBuzz.CheckFirstFinishPoint(ref startPoint, ref finishPoint);
            //3.Assertion
            Assert.AreEqual(startPoint, expStartPoint);
            Assert.AreEqual(finishPoint, expFinishPoint);
        }

        [TestMethod]
        public void CheckFirstFinishPoint_Test_100_1()
        {
            //1.Preparation
            int startPoint = 100;
            int finishPoint = 1;

            int expStartPoint = 1;
            int expFinishPoint = 100;
            //2.Execution
            SolutionFizzBuzz.CheckFirstFinishPoint(ref startPoint, ref finishPoint);
            //3.Assertion
            Assert.AreEqual(startPoint, expStartPoint);
            Assert.AreEqual(finishPoint, expFinishPoint);
        }

        [TestMethod]
        public void CheckFirstFinishPoint_Test_100_100()
        {
            //1.Preparation
            int startPoint = 100;
            int finishPoint = 100;

            int expStartPoint = 100;
            int expFinishPoint = 100;
            //2.Execution
            SolutionFizzBuzz.CheckFirstFinishPoint(ref startPoint, ref finishPoint);
            //3.Assertion
            Assert.AreEqual(startPoint, expStartPoint);
            Assert.AreEqual(finishPoint, expFinishPoint);
        }
    }
}
