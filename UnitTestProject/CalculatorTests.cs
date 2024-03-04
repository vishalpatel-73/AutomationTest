using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        readonly Calculator calculator = new Calculator();

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(4, calculator.Add(2, 2));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(2, calculator.Subtract(4, 2));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
        }
    }
}
