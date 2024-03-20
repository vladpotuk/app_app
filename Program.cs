using System;

class Program
{
    static void Main(string[] args)
    {
        CreditCard card = new CreditCard("1234 5678 9012 3456", "John Doe", DateTime.Now.AddYears(3), "1234", 5000);

        
        card.AccountReplenished += amount => Console.WriteLine($"Рахунок поповнено на {amount} грн");
        card.MoneySpent += amount => Console.WriteLine($"З рахунку списано {amount} грн");
        card.CreditStarted += () => Console.WriteLine("Початок використання кредитних коштів");
        card.LimitReached += balance => Console.WriteLine($"Досягнуто ліміт кредиту: {balance} грн");
        card.PINChanged += newPIN => Console.WriteLine($"PIN змінено на {newPIN}");

        
        card.ReplenishAccount(1000);
        
        card.SpendMoney(500);
        
        card.StartCredit();
        
        card.ChangePIN("5678");
        
        card.CheckLimit();
    }
}
