using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    private BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount(1000); 
    }


    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        account.Deposit(500);

        Assert.AreEqual(1500, account.GetBalance());
    }

  
    [Test]
    public void Withdraw_ShouldDecreaseBalance()
    {
        account.Withdraw(300);

        Assert.AreEqual(700, account.GetBalance());
    }

  
    [Test]
    public void Withdraw_InsufficientFunds_ShouldThrowException()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            account.Withdraw(1500);
        });
    }
}
