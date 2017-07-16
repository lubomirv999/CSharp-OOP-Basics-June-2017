using System;

public class BankAccount
{
    //Task 1 and 2

    private int id;
    private double balance;

    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public double Balance
    {
        get { return this.balance; }
        set
        {
            this.balance = value;

            if (value < 0)
            {
                throw new ArgumentException("Balance can not be negative");
            }
        }
    }

    public void Deposit(double amount)
    {
        this.Balance += amount;
    }
    public void Withdraw(double amount)
    {
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.id}, balance {this.balance:f2}";
    }
}