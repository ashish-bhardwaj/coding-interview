using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewPractice.DailyCodingProblem;

namespace InterviewPracticeTestCases.DailyCodingProblem
{
    [TestClass]
    public class Problem17Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Problem17 p = new Problem17();
            
            int len = p.GetAbsolutePath("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext");
            Assert.AreEqual(32, len);
        }
    }
}
