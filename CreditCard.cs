using System;


class CreditCard
{
    public string CardNumber { get; }
    public string CardHolderName { get; }
    public string ExpiryDate { get; }
    public int PIN { get; private set; }
    public double CreditLimit { get; }
    public double Balance { get; private set; }

    
    public CreditCard(string cardNumber, string cardHolderName, string expiryDate, int pin, double creditLimit, double balance)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpiryDate = expiryDate;
        PIN = pin;
        CreditLimit = creditLimit;
        Balance = balance;
    }

   
    public void TopUp(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Рахунок поповнено на {amount}. Поточний баланс: {Balance}");
    }

    
    public void Spend(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Недостатньо коштів на рахунку!");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Витрачено {amount}. Поточний баланс: {Balance}");
    }

    
    public void StartUsingCredit()
    {
        Console.WriteLine("Початок використання кредитних коштів.");
    }

    
    public bool IsLimitReached(double amount)
    {
        return Balance + amount > CreditLimit;
    }

    
    public void ChangePIN(int newPIN)
    {
        PIN = newPIN;
        Console.WriteLine("PIN успішно змінений.");
    }
}
