using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewPractice.DailyCodingProblem;

namespace InterviewPracticeTestCases.DailyCodingProblem
{
    [TestClass]
    public class Problem2Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Problem2 p = new Problem2();
            int[] arr = new int[] { 3, 2, 1 };
            p.Solve(arr);
            CollectionAssert.AreEqual(arr, new int[] { 2, 3, 6 });
        }
    }
}
