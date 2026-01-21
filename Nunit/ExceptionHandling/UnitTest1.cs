using System;
using NUnit.Framework;
using ExceptionHandling.check;
namespace ExceptionHandling.check.Test
{
    [TestFixture]
    public class Calculation
    {
        private DivisionByZero ByZero;
        [SetUp]
        public void SetUp()
        {
            ByZero = new DivisionByZero();

        }
        [Test]
        public void CheckDivideByZero_Exception()
        {
           Assert.Throws<NullReferenceException>(()=>{ByZero.Divide(22,0);});
        }
    }
}