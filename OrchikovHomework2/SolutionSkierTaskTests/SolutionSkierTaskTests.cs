using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryForSkierTask;

namespace SolutionSkierTaskTests
{
    [TestClass]
    public class LibraryForSkierTaskTests
    {
        private SolutionSkierTask _solutionSkierTask;

        [TestInitialize]
        public void BeforeAll()
        {
            _solutionSkierTask = new SolutionSkierTask();
        }
        [TestCleanup]
        public void AfterAll()
        {
            _solutionSkierTask.Dispose();
        }

        private void Dispose()
        {
            //we are disposing it
        }

        [TestMethod]
        public void SolutionSkierTask_Test_1_2_100()
        {
            //1.Preparation
            double distX = 1;
            double growthY = 2;
            double targetZ = 100;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(101, result);
        }

        [TestMethod]
        public void SolutionSkierTask_Test_10_1_100()
        {
            //1.Preparation
            double distX = 10;
            double growthY = 1;
            double targetZ = 100;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(87, result);
        }

        [TestMethod]
        public void SolutionSkierTask_Test_0_1_100()
        {
            //1.Preparation
            double distX = 0;
            double growthY = 1;
            double targetZ = 100;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(103, result);
        }

        [TestMethod]
        public void SolutionSkierTask_Test_0_0_100()
        {
            //1.Preparation
            double distX = 0;
            double growthY = 0;
            double targetZ = 100;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SolutionSkierTask_Test_0_5_20()
        {
            //1.Preparation
            double distX = 0;
            double growthY = 5;
            double targetZ = 20;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(23, result);
        }
        [TestMethod]
        public void SolutionSkierTask_Test_0_0_0()
        {
            //1.Preparation
            double distX = 0;
            double growthY = 0;
            double targetZ = 0;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SolutionSkierTask_Test_minus1_2_100()
        {
            //1.Preparation
            double distX = -1;
            double growthY = 2;
            double targetZ = 100;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(105, result);
        }

        [TestMethod]
        public void SolutionSkierTask_Test_1_minus2_100()
        {
            //1.Preparation
            double distX = 1;
            double growthY = -2;
            double targetZ = 100;
            //2.Execution
            double result = _solutionSkierTask.Solution(distX, growthY, targetZ);
            //3.Assertion
            Assert.AreEqual(0, result);
        }
    }
}
