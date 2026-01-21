/* Testing Banking Transactions
Problem:
Create a BankAccount class with:
● Deposit(double amount): Adds money to the balance.
● Withdraw(double amount): Reduces balance.
● GetBalance(): Returns the current balance.
✅ Write unit tests to check correct balance updates.
✅ Ensure withdrawals fail if funds are insufficient*/

using System;

public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");

        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive");

        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds");

        balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}
