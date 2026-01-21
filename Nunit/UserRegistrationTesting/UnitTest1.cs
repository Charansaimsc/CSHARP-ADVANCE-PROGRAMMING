using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration registration;

    [SetUp]
    public void Setup()
    {
        registration = new UserRegistration();
    }

    [TestCase("sai123", "sai@gmail.com", "saicharan123")]
    [TestCase("charan", "charans@yahoo.com", "charan#129")]
    public void RegisterUser_ValidInputs_ShouldNotThrowException(string username, string email, string password)
    {
        Assert.DoesNotThrow(() =>
        {
            registration.RegisterUser(username, email, password);
        });
    }

    
    [TestCase("", "saii@gmail.com", "pass123")]        // invalid username
    [TestCase("charan", "sssaagmail.com", "pass123")]     // invalid email
    [TestCase("muchakarla", "muchakarla@gmail.com", "123")]        // invalid password
    [TestCase(" ", "saiiii@gmail.com", "pass123")]      // null username
    public void RegisterUser_InvalidInputs_ShouldThrowArgumentException(string username, string email, string password)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            registration.RegisterUser(username, email, password);
        });
    }
}
