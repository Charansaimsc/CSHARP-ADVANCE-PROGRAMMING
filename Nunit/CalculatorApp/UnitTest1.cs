using NUnit.Framework;
using CalculatorApp;
using System;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc;

        
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            int result = calc.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = calc.Multiply(4, 3);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            int result = calc.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

       
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                calc.Divide(10, 0);
            });
        }
    }
}
