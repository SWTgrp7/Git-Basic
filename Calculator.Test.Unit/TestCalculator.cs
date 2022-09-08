
using System.Reflection;

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
            //var uut = new Calculator();
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

        [TestCase(16, 8, 2)]
        [TestCase(100, 20, 5)]
        public void TestDivide(double dividend, double divisor, double result)
        {
            Assert.That(uut.Divide(dividend, divisor), Is.EqualTo(result));
        }

        [TestCase(2,2,4)]
        [TestCase(2,8,256)]
        public void TestPower(double x, double exp, double result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(10, 2, 12)]
        [TestCase(10, 17, 27)]
        public void TestOverloadedAdd(double accumulator, double number, double result)
        {
            uut.Add(0, accumulator);
            Assert.That(uut.Add(number), Is.EqualTo(result));
        }

        [TestCase(10, 2, 8)]
        [TestCase(10, 17, -7)]
        public void TestOverloadedSubtract(double accumulator, double number, double result)
        {
            uut.Add(0, accumulator);
            Assert.That(uut.Subtract(number), Is.EqualTo(result));
        }

        [TestCase(10, 2, 20)]
        [TestCase(10, 17, 170)]
        public void TestOverloadedMultiply(double accumulator, double number, double result)
        {
            uut.Add(0, accumulator);
            Assert.That(uut.Multiply(number), Is.EqualTo(result));
        }

        [TestCase(10, 2, 100)]
        [TestCase(5,4 , 625)]
        public void TestOverloadedPower(double accumulator, double exp, double result)
        {
            uut.Add(0, accumulator);
            Assert.That(uut.Power(exp), Is.EqualTo(result));
        }
    }
}