using NUnit.Framework;
using System;
using StringOperation;
namespace StringOperation.Test
{
    [TestFixture]
    public class StringTests
    {
        [Test]
        public void Returns_Reversed_String()
        {
            Assert.AreEqual("IAS",StringUtils.Reverse("SAI"));
        }
        [Test]
        public void Palindrome_IsPalindrime_Yes()
        {
            Assert.IsTrue(StringUtils.IsPalindrome("markram"));
        }
        [Test]
        public void Palindrome_IsPalindrome_No()
        {
             Assert.IsFalse(StringUtils.IsPalindrome("charan"));
        }
        [Test]
        public void ToUpperCase_ValidString_ReturnsUppercase()
    {
        Assert.AreEqual("HELLO", StringUtils.ToUpperCase("hello"));
    }

    }
}