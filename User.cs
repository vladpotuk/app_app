using System;

class User
{
   
    public static CreditCard EnterCreditCardData()
    {
        Console.WriteLine("Введіть дані про кредитну картку:");

        Console.Write("Номер карти: ");
        string cardNumber = Console.ReadLine();

        Console.Write("ПІБ власника: ");
        string cardHolderName = Console.ReadLine();

        Console.Write("Термін дії карти: ");
        string expiryDate = Console.ReadLine();

        Console.Write("PIN: ");
        int pin = int.Parse(Console.ReadLine());

        Console.Write("Кредитний ліміт: ");
        double creditLimit = double.Parse(Console.ReadLine());

        Console.Write("Сума грошей: ");
        double balance = double.Parse(Console.ReadLine());

        return new CreditCard(cardNumber, cardHolderName, expiryDate, pin, creditLimit, balance);
    }
}
