namespace TestProject
{
    public class CalculatorUnitTest
    {
        readonly Calculator calculator = new Calculator();

        [Fact]
        public void TestAddition()
        {
            Assert.Equal(4, calculator.Add(2, 2));
        }

        [Fact]
        public void TestSubtraction()
        {
            Assert.Equal(2, calculator.Subtract(4, 2));
        }

        [Fact]
        public void TestMultiplication()
        {
            Assert.Equal(6, calculator.Multiply(2, 3));
        }

        [Fact]
        public void TestDivision()
        {
            Assert.Equal(2, calculator.Divide(6, 3));
        }
    }
}