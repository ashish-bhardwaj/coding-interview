using System;
using InterviewPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewPracticeTestCases
{
    [TestClass]
    public class StringRotationTest
    {
        [TestMethod]
        public void TestMethod1 ()
        {
            var obj = new StringRotation();

            Assert.IsTrue(obj.SubString("waterbottle", "erbottlewat"));

            Assert.IsTrue(obj.SubString("abcdef", "efabcd"));
            Assert.IsTrue(obj.SubString("abcdefaadd", "defaaddabc"));
            Assert.IsFalse(obj.SubString("abcdefaadd", "efaaddabc"));

        }
    }
}
