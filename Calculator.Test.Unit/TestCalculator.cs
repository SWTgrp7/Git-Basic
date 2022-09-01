
namespace Calculator.Test.Unit
{
    public class CalculatorUnitTests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            //var uut = new Calculator(); buvbwuvbwuovbw
            Assert.That(uut.Add(4,8),Is.EqualTo(12));
        }

        [Test]
        public void TestSubtract()
        {
            //var uut = new Calculator();
            Assert.That(uut.Subtract(27,18), Is.EqualTo(9));
        }

        [Test]
        public void TestMultiply()
        {
            //var uut = new Calculator();
            Assert.That(uut.Multiply(10, 52), Is.EqualTo(520));
        }

        [TestCase(2,2,4)]
        [TestCase(2,8,256)]
        public void TestPower(double x, double exp, double result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }
    }
}