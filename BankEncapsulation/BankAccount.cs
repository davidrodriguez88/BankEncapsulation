﻿namespace BankEncapsulation;

public class BankAccount
{
    private double balance = 0;

    public BankAccount()
    {
        balance = 0;
    }
    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}