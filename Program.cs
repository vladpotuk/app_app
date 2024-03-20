using System;

class Program
{
    static void Main()
    {
        
        CreditCard card = User.EnterCreditCardData();

        
        Action<double> topUpAction = card.TopUp;
        Action<double> spendAction = card.Spend;
        Action startUsingCreditAction = card.StartUsingCredit;
        Predicate<double> isLimitReachedPredicate = card.IsLimitReached;
        Action<int> changePINAction = card.ChangePIN;

        
        Console.Write("Введіть суму для поповнення рахунку: ");
        double topUpAmount = double.Parse(Console.ReadLine());
        topUpAction(topUpAmount);

       
        Console.Write("Введіть суму для витрати з рахунку: ");
        double spendAmount = double.Parse(Console.ReadLine());
        spendAction(spendAmount);

        
        startUsingCreditAction();

        
        Console.Write("Введіть суму для перевірки ліміту: ");
        double checkAmount = double.Parse(Console.ReadLine());
        if (isLimitReachedPredicate(checkAmount))
        {
            Console.WriteLine("Досягнуто ліміту кредитних коштів!");
        }
        else
        {
            Console.WriteLine("Ліміт кредитних коштів не досягнуто.");
        }

        
        Console.Write("Введіть новий PIN: ");
        int newPIN = int.Parse(Console.ReadLine());
        changePINAction(newPIN);
    }
}
