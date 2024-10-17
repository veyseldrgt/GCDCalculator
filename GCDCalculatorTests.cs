using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCDLib;

namespace GCDUnitTest
{
    [TestClass]
    public class GCDCalculatorTests
    {
        [TestMethod]
        public void TestGCD_subtraction()
        {
            Assert.AreEqual(1, GCDCalculator.GCD_subtraction(103, 3));
            Assert.AreEqual(1, GCDCalculator.GCD_subtraction(106, 3));
            Assert.AreEqual(1, GCDCalculator.GCD_subtraction(1010, 3));
        }

        [TestMethod]
        public void TestGCD_modulo()
        {
            Assert.AreEqual(1, GCDCalculator.GCD_modulo(103, 3));
            Assert.AreEqual(1, GCDCalculator.GCD_modulo(106, 3));
            Assert.AreEqual(1, GCDCalculator.GCD_modulo(1010, 3));
        }
    }
}
