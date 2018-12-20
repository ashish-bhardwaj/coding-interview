using System;
using InterviewPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewPracticeTestCases
{
    [TestClass]
    public class PalindromePermutationTest
    {
        [TestMethod]
        public void TestMethod1 ()
        {
            var obj = new PalindromePermutation();
            Assert.IsTrue(obj.IsPalindrome("taa"));
            Assert.IsFalse(obj.IsPalindrome("ataa"));
            Assert.IsTrue(obj.IsPalindrome("attaa"));

            Assert.IsTrue(obj.IsPalindrome("at taa"));

        }
    }
}
