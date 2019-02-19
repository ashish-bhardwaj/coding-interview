using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewPractice.DailyCodingProblem;

namespace InterviewPracticeTestCases.DailyCodingProblem
{
    [TestClass]
    public class Problem1Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Problem1 p = new Problem1();
            
            bool res = p.NumbersHaveSum(new int[] { 10, 15, 3, 7 }, 17 );
            Assert.IsTrue(res);
        }
    }
}
