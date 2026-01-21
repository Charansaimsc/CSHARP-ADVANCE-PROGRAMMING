using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

  
    [TestCase("Password1")]
    [TestCase("StrongPass9")]
    [TestCase("HelloWorld7")]
    public void IsValid_ValidPasswords_ShouldReturnTrue(string password)
    {
        bool result = validator.IsValid(password);

        Assert.IsTrue(result);
    }

   
    [TestCase("password1")]   
    [TestCase("Password")]    // no digit
    [TestCase("Pass1")]       // too short
    [TestCase("password")]    
    [TestCase("")]            // empty
    public void IsValid_InvalidPasswords_ShouldReturnFalse(string password)
    {
        bool result = validator.IsValid(password);

        Assert.IsFalse(result);
    }
}
