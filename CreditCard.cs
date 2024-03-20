using System;

public class CreditCard
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string PIN { get; set; }
    public decimal CreditLimit { get; set; }
    public decimal Balance { get; set; }

    
    public event Action<decimal> AccountReplenished;
    public event Action<decimal> MoneySpent;
    public event Action CreditStarted;
    public event Action<decimal> LimitReached;
    public event Action<string> PINChanged;

    
    public CreditCard(string cardNumber, string cardHolderName, DateTime expiryDate, string pin, decimal creditLimit)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpiryDate = expiryDate;
        PIN = pin;
        CreditLimit = creditLimit;
    }

    
    public void ReplenishAccount(decimal amount)
    {
        Balance += amount;
        AccountReplenished?.Invoke(amount);
    }

    public void SpendMoney(decimal amount)
    {
        Balance -= amount;
        MoneySpent?.Invoke(amount);
    }

    public void StartCredit()
    {
        CreditStarted?.Invoke();
    }

    public void CheckLimit()
    {
        if (Balance >= CreditLimit)
        {
            LimitReached?.Invoke(Balance);
        }
    }

    public void ChangePIN(string newPIN)
    {
        PIN = newPIN;
        PINChanged?.Invoke(newPIN);
    }
}
