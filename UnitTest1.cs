using Microsoft.VisualStudio.TestTools.UnitTesting;
using stringModifierClassLibrary;

namespace libraryTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("returntype")]
        public void TestMUCReturnsString()
        {
            string sample = "Test String";
            Assert.IsInstanceOfType(ChangeMyString.MakeAllUpperCase(sample), typeof(string));
        }

        [TestMethod]
        [TestCategory("returntype")]
        public void TestMRReturnsString()
        {
            string sample = "Test String";
            Assert.IsInstanceOfType(ChangeMyString.MakeReverse(sample), typeof(string));
        }

        [TestMethod]
        [TestCategory("functionality")]
        public void TestMakeAllUpperCase()
        {
            string sample = "Test String";
            Assert.AreEqual("TEST STRING", ChangeMyString.MakeAllUpperCase(sample));
        }

        [TestMethod]
        [TestCategory("functionality")]
        public void TestMakeReverse()
        {
            string sample = "Test String";
            Assert.AreEqual("gnirtS tseT", ChangeMyString.MakeReverse(sample));
        }
    }
}
